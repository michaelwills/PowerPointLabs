﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PowerPointLabs
{
    public partial class ColorPane : UserControl
    {
        [DllImport("Gdi32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPixel(
            System.IntPtr hdc,    // handle to DC
            int nXPos,  // x-coordinate of pixel
            int nYPos   // y-coordinate of pixel
        );

        [DllImport("User32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetDC(IntPtr wnd);

        [DllImport("User32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ReleaseDC(IntPtr dc);

        LMouseListener _native;

        public ColorPane()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            _native = new LMouseListener();
            _native.RButtonClicked +=
                 new EventHandler<SysMouseEventInfo>(_native_RButtonClicked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = panel1.BackColor;
            colorDialog1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = Control.MousePosition;
            IntPtr dc = GetDC(IntPtr.Zero);
            this.panel1.BackColor = ColorTranslator.FromWin32(GetPixel(dc, p.X, p.Y));
        }

        void _native_RButtonClicked(object sender, SysMouseEventInfo e)
        {
            timer1.Stop();
            _native.Close();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Color selectedColor = panel1.BackColor;
            Color complementaryColor = ColorHelper.GetComplementaryColor(selectedColor);

            List<Color> analogousColors = ColorHelper.GetAnalogousColorsForColor(selectedColor);
            AnalogousLighter.BackColor = analogousColors[0];
            AnalogousDarker.BackColor = analogousColors[1];
            AnalogousSelected.BackColor = selectedColor;

            List<Color> complementaryColors = ColorHelper.GetSplitComplementaryColorsForColor(selectedColor);
            ComplementaryLighter.BackColor = complementaryColors[0];
            ComplementaryDarker.BackColor = complementaryColors[1];
            ComplementarySelected.BackColor = complementaryColor;

            List<Color> triadicColors = ColorHelper.GetTriadicColorsForColor(selectedColor);
            TriadicLower.BackColor = triadicColors[0];
            TriadicHigher.BackColor = triadicColors[1];
            TriadicSelected.BackColor = selectedColor;

            List<Color> tetradicColors = ColorHelper.GetTetradicColorsForColor(selectedColor);
            Tetradic1.BackColor = tetradicColors[0];
            Tetradic2.BackColor = tetradicColors[1];
            Tetradic3.BackColor = tetradicColors[2];
            TetradicSelected.BackColor = selectedColor;
        }
    }

    public class SysMouseEventInfo : EventArgs
    {
        public string WindowTitle { get; set; }
    }
    public class LMouseListener
    {
        public LMouseListener()
        {
            this.CallBack += new HookProc(MouseEvents);
            //Module mod = Assembly.GetExecutingAssembly().GetModules()[0];
            //IntPtr hMod = Marshal.GetHINSTANCE(mod);
            using (System.Diagnostics.Process process = System.Diagnostics.Process.GetCurrentProcess())
            using (System.Diagnostics.ProcessModule module = process.MainModule)
            {
                IntPtr hModule = GetModuleHandle(module.ModuleName);
                _hook = SetWindowsHookEx(WH_MOUSE_LL, this.CallBack, hModule, 0);
                //if (_hook != IntPtr.Zero)
                //{
                //    Console.WriteLine("Started");
                //}
            }
        }
        int WH_MOUSE_LL = 14;
        int HC_ACTION = 0;
        HookProc CallBack = null;
        IntPtr _hook = IntPtr.Zero;

        public event EventHandler<SysMouseEventInfo> RButtonClicked;

        int MouseEvents(int code, IntPtr wParam, IntPtr lParam)
        {
            //Console.WriteLine("Called");

            if (code < 0)
                return CallNextHookEx(_hook, code, wParam, lParam);

            if (code == this.HC_ACTION)
            {
                // Left button pressed somewhere
                if (wParam.ToInt32() == (uint)WM.WM_LBUTTONUP)
                {
                    MSLLHOOKSTRUCT ms = new MSLLHOOKSTRUCT();
                    ms = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                    IntPtr win = WindowFromPoint(ms.pt);
                    string title = GetWindowTextRaw(win);
                    if (RButtonClicked != null)
                    {
                        RButtonClicked(this, new SysMouseEventInfo { WindowTitle = title });
                    }
                }
            }
            return CallNextHookEx(_hook, code, wParam, lParam);
        }

        public void Close()
        {
            if (_hook != IntPtr.Zero)
            {
                UnhookWindowsHookEx(_hook);
            }
        }
        public delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowsHookEx", SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(int xPoint, int yPoint);

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(POINT Point);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, [Out] StringBuilder lParam);

        public static string GetWindowTextRaw(IntPtr hwnd)
        {
            // Allocate correct string length first
            //int length = (int)SendMessage(hwnd, (int)WM.WM_GETTEXTLENGTH, IntPtr.Zero, IntPtr.Zero);
            StringBuilder sb = new StringBuilder(65535);//THIS COULD BE BAD. Maybe you shoudl get the length
            SendMessage(hwnd, (int)WM.WM_GETTEXT, (IntPtr)sb.Capacity, sb);
            return sb.ToString();
        }
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct MSLLHOOKSTRUCT
    {
        public POINT pt;
        public int mouseData;
        public int flags;
        public int time;
        public UIntPtr dwExtraInfo;
    }
    enum WM : uint
    {//all windows messages here
        WM_LBUTTONUP = 0x0202,
        WM_GETTEXT = 0x000D,
        WM_GETTEXTLENGTH = 0x000E
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public POINT(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
