﻿namespace MiraToolkit.Controls.Debugger
{
    partial class ucBreakpoints
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
            this.lstBreakpoints = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstBreakpoints
            // 
            this.lstBreakpoints.CheckBoxes = true;
            this.lstBreakpoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstBreakpoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBreakpoints.GridLines = true;
            this.lstBreakpoints.Location = new System.Drawing.Point(0, 0);
            this.lstBreakpoints.Name = "lstBreakpoints";
            this.lstBreakpoints.Size = new System.Drawing.Size(293, 469);
            this.lstBreakpoints.TabIndex = 1;
            this.lstBreakpoints.UseCompatibleStateImageBehavior = false;
            this.lstBreakpoints.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Address";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hit Count";
            this.columnHeader3.Width = 91;
            // 
            // ucBreakpoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstBreakpoints);
            this.Name = "ucBreakpoints";
            this.Size = new System.Drawing.Size(293, 469);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstBreakpoints;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
