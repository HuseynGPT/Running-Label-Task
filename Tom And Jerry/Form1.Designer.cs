﻿namespace Tom_And_Jerry
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = Properties.Resources.JERRY_V2;
            label1.Location = new Point(312, 167);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "         ";
            label1.MouseHover += label1_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tom_and_jerry_task;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(656, 394);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tom And Jerry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}