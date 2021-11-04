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
            this.Directionss = new System.Windows.Forms.TextBox();
            this.neighbor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Directionss
            // 
            this.Directionss.Location = new System.Drawing.Point(0, 0);
            this.Directionss.Name = "Directionss";
            this.Directionss.ReadOnly = true;
            this.Directionss.Size = new System.Drawing.Size(68, 20);
            this.Directionss.TabIndex = 0;
            // 
            // neighbor
            // 
            this.neighbor.FormattingEnabled = true;
            this.neighbor.Location = new System.Drawing.Point(74, 0);
            this.neighbor.Name = "neighbor";
            this.neighbor.Size = new System.Drawing.Size(115, 21);
            this.neighbor.TabIndex = 1;
            // 
            // DirectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighbor);
            this.Controls.Add(this.Directionss);
            this.Name = "DirectionControl";
            this.Size = new System.Drawing.Size(192, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Directionss;
        private System.Windows.Forms.ComboBox neighbor;
    }
}
