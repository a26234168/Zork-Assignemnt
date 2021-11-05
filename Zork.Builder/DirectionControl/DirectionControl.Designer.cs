using System;

namespace Zork.Builder.DirectionControl
{
    partial class DirectionControl
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
            this.directionsDropDown = new System.Windows.Forms.TextBox();
            this.neighborsDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // directionsDropDown
            // 
            this.directionsDropDown.Location = new System.Drawing.Point(0, 0);
            this.directionsDropDown.Name = "directionsDropDown";
            this.directionsDropDown.ReadOnly = true;
            this.directionsDropDown.Size = new System.Drawing.Size(68, 20);
            this.directionsDropDown.TabIndex = 0;
            // 
            // neighborsDropDown
            // 
            this.neighborsDropDown.FormattingEnabled = true;
            this.neighborsDropDown.Location = new System.Drawing.Point(74, 0);
            this.neighborsDropDown.Name = "neighborsDropDown";
            this.neighborsDropDown.Size = new System.Drawing.Size(115, 21);
            this.neighborsDropDown.TabIndex = 1;
            // 
            // DirectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighborsDropDown);
            this.Controls.Add(this.directionsDropDown);
            this.Name = "DirectionControl";
            this.Size = new System.Drawing.Size(192, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void NeighborsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox directionsDropDown;
        private System.Windows.Forms.ComboBox neighborsDropDown;
    }
}