﻿namespace PowerPointLabs
{
    partial class ColorPane
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AnalogousColorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AnalogousLighter = new System.Windows.Forms.Panel();
            this.AnalogousSelected = new System.Windows.Forms.Panel();
            this.AnalogousDarker = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ComplementaryLighter = new System.Windows.Forms.Panel();
            this.ComplementarySelected = new System.Windows.Forms.Panel();
            this.ComplementaryDarker = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.TriadicLower = new System.Windows.Forms.Panel();
            this.TriadicSelected = new System.Windows.Forms.Panel();
            this.TriadicHigher = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Tetradic1 = new System.Windows.Forms.Panel();
            this.TetradicSelected = new System.Windows.Forms.Panel();
            this.Tetradic2 = new System.Windows.Forms.Panel();
            this.Tetradic3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.AnalogousColorPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 47);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Eyedropper";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnalogousColorPanel
            // 
            this.AnalogousColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnalogousColorPanel.Controls.Add(this.label1);
            this.AnalogousColorPanel.Controls.Add(this.AnalogousLighter);
            this.AnalogousColorPanel.Controls.Add(this.AnalogousSelected);
            this.AnalogousColorPanel.Controls.Add(this.AnalogousDarker);
            this.AnalogousColorPanel.Location = new System.Drawing.Point(20, 141);
            this.AnalogousColorPanel.Name = "AnalogousColorPanel";
            this.AnalogousColorPanel.Size = new System.Drawing.Size(256, 87);
            this.AnalogousColorPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Analogous Colors";
            // 
            // AnalogousLighter
            // 
            this.AnalogousLighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnalogousLighter.Location = new System.Drawing.Point(3, 29);
            this.AnalogousLighter.Name = "AnalogousLighter";
            this.AnalogousLighter.Size = new System.Drawing.Size(75, 47);
            this.AnalogousLighter.TabIndex = 0;
            // 
            // AnalogousSelected
            // 
            this.AnalogousSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnalogousSelected.Location = new System.Drawing.Point(84, 29);
            this.AnalogousSelected.Name = "AnalogousSelected";
            this.AnalogousSelected.Size = new System.Drawing.Size(75, 47);
            this.AnalogousSelected.TabIndex = 1;
            // 
            // AnalogousDarker
            // 
            this.AnalogousDarker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnalogousDarker.Location = new System.Drawing.Point(165, 29);
            this.AnalogousDarker.Name = "AnalogousDarker";
            this.AnalogousDarker.Size = new System.Drawing.Size(75, 47);
            this.AnalogousDarker.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.ComplementaryLighter);
            this.flowLayoutPanel2.Controls.Add(this.ComplementarySelected);
            this.flowLayoutPanel2.Controls.Add(this.ComplementaryDarker);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(20, 234);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(256, 112);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // ComplementaryLighter
            // 
            this.ComplementaryLighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComplementaryLighter.Location = new System.Drawing.Point(3, 55);
            this.ComplementaryLighter.Name = "ComplementaryLighter";
            this.ComplementaryLighter.Size = new System.Drawing.Size(75, 47);
            this.ComplementaryLighter.TabIndex = 0;
            // 
            // ComplementarySelected
            // 
            this.ComplementarySelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComplementarySelected.Location = new System.Drawing.Point(84, 55);
            this.ComplementarySelected.Name = "ComplementarySelected";
            this.ComplementarySelected.Size = new System.Drawing.Size(75, 47);
            this.ComplementarySelected.TabIndex = 1;
            // 
            // ComplementaryDarker
            // 
            this.ComplementaryDarker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComplementaryDarker.Location = new System.Drawing.Point(165, 55);
            this.ComplementaryDarker.Name = "ComplementaryDarker";
            this.ComplementaryDarker.Size = new System.Drawing.Size(75, 47);
            this.ComplementaryDarker.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.TriadicLower);
            this.flowLayoutPanel3.Controls.Add(this.TriadicSelected);
            this.flowLayoutPanel3.Controls.Add(this.TriadicHigher);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(20, 352);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(256, 85);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // TriadicLower
            // 
            this.TriadicLower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadicLower.Location = new System.Drawing.Point(3, 29);
            this.TriadicLower.Name = "TriadicLower";
            this.TriadicLower.Size = new System.Drawing.Size(75, 47);
            this.TriadicLower.TabIndex = 0;
            // 
            // TriadicSelected
            // 
            this.TriadicSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadicSelected.Location = new System.Drawing.Point(84, 29);
            this.TriadicSelected.Name = "TriadicSelected";
            this.TriadicSelected.Size = new System.Drawing.Size(75, 47);
            this.TriadicSelected.TabIndex = 1;
            // 
            // TriadicHigher
            // 
            this.TriadicHigher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadicHigher.Location = new System.Drawing.Point(165, 29);
            this.TriadicHigher.Name = "TriadicHigher";
            this.TriadicHigher.Size = new System.Drawing.Size(75, 47);
            this.TriadicHigher.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.Tetradic1);
            this.flowLayoutPanel4.Controls.Add(this.TetradicSelected);
            this.flowLayoutPanel4.Controls.Add(this.Tetradic2);
            this.flowLayoutPanel4.Controls.Add(this.Tetradic3);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(20, 443);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(256, 138);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // Tetradic1
            // 
            this.Tetradic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tetradic1.Location = new System.Drawing.Point(3, 29);
            this.Tetradic1.Name = "Tetradic1";
            this.Tetradic1.Size = new System.Drawing.Size(75, 47);
            this.Tetradic1.TabIndex = 0;
            // 
            // TetradicSelected
            // 
            this.TetradicSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TetradicSelected.Location = new System.Drawing.Point(84, 29);
            this.TetradicSelected.Name = "TetradicSelected";
            this.TetradicSelected.Size = new System.Drawing.Size(75, 47);
            this.TetradicSelected.TabIndex = 1;
            // 
            // Tetradic2
            // 
            this.Tetradic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tetradic2.Location = new System.Drawing.Point(165, 29);
            this.Tetradic2.Name = "Tetradic2";
            this.Tetradic2.Size = new System.Drawing.Size(75, 47);
            this.Tetradic2.TabIndex = 1;
            // 
            // Tetradic3
            // 
            this.Tetradic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tetradic3.Location = new System.Drawing.Point(3, 82);
            this.Tetradic3.Name = "Tetradic3";
            this.Tetradic3.Size = new System.Drawing.Size(75, 47);
            this.Tetradic3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "Complementary Colors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Triadic Colors   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tetradic Colors";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(101, 45);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ColorPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.AnalogousColorPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "ColorPane";
            this.Size = new System.Drawing.Size(304, 635);
            this.AnalogousColorPanel.ResumeLayout(false);
            this.AnalogousColorPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel AnalogousColorPanel;
        private System.Windows.Forms.Panel AnalogousLighter;
        private System.Windows.Forms.Panel AnalogousSelected;
        private System.Windows.Forms.Panel AnalogousDarker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel ComplementaryLighter;
        private System.Windows.Forms.Panel ComplementarySelected;
        private System.Windows.Forms.Panel ComplementaryDarker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel TriadicLower;
        private System.Windows.Forms.Panel TriadicSelected;
        private System.Windows.Forms.Panel TriadicHigher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel Tetradic1;
        private System.Windows.Forms.Panel TetradicSelected;
        private System.Windows.Forms.Panel Tetradic2;
        private System.Windows.Forms.Panel Tetradic3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenerateButton;
    }
}
