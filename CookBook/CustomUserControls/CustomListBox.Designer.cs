﻿namespace CookBook.CustomUserControls
{
    partial class CustomListBox
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
            CustomLbx = new ListBox();
            SuspendLayout();
            // 
            // CustomLbx
            // 
            CustomLbx.FormattingEnabled = true;
            CustomLbx.ItemHeight = 15;
            CustomLbx.Location = new Point(3, 4);
            CustomLbx.Name = "CustomLbx";
            CustomLbx.Size = new Size(303, 424);
            CustomLbx.TabIndex = 0;
            // 
            // CustomListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomLbx);
            Name = "CustomListBox";
            Size = new Size(309, 433);
            ResumeLayout(false);
        }

        #endregion

        private ListBox CustomLbx;
    }
}
