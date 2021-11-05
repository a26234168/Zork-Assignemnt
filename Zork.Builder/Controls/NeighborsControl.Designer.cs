
namespace Zork.Builder.Controls
{
    partial class NeighborsControl
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
            this.neighborsDirectionTextbox = new System.Windows.Forms.TextBox();
            this.neighborsSelectedDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // neighborsDirectionTextbox
            // 
            this.neighborsDirectionTextbox.Location = new System.Drawing.Point(3, 3);
            this.neighborsDirectionTextbox.Name = "neighborsDirectionTextbox";
            this.neighborsDirectionTextbox.ReadOnly = true;
            this.neighborsDirectionTextbox.Size = new System.Drawing.Size(68, 20);
            this.neighborsDirectionTextbox.TabIndex = 0;
            // 
            // neighborsSelectedDropDown
            // 
            this.neighborsSelectedDropDown.DropDownWidth = 115;
            this.neighborsSelectedDropDown.FormattingEnabled = true;
            this.neighborsSelectedDropDown.Location = new System.Drawing.Point(74, 3);
            this.neighborsSelectedDropDown.Name = "neighborsSelectedDropDown";
            this.neighborsSelectedDropDown.Size = new System.Drawing.Size(115, 21);
            this.neighborsSelectedDropDown.TabIndex = 1;
            // 
            // NeighborsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighborsSelectedDropDown);
            this.Controls.Add(this.neighborsDirectionTextbox);
            this.Name = "NeighborsControl";
            this.Size = new System.Drawing.Size(192, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox neighborsDirectionTextbox;
        private System.Windows.Forms.ComboBox neighborsSelectedDropDown;
    }
}
