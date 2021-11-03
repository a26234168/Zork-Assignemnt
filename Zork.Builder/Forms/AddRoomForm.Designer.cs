
namespace Zork.Builder
{
    partial class AddRoomForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label roomNameLabel;
            this.roomCancelButton = new System.Windows.Forms.Button();
            this.roomOkButton = new System.Windows.Forms.Button();
            this.roomNameText = new System.Windows.Forms.TextBox();
            roomNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roomNameLabel.Location = new System.Drawing.Point(91, 50);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(98, 20);
            roomNameLabel.TabIndex = 0;
            roomNameLabel.Text = "Room Name";
            // 
            // roomCancelButton
            // 
            this.roomCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.roomCancelButton.Location = new System.Drawing.Point(145, 100);
            this.roomCancelButton.Name = "roomCancelButton";
            this.roomCancelButton.Size = new System.Drawing.Size(89, 26);
            this.roomCancelButton.TabIndex = 3;
            this.roomCancelButton.Text = "&Cancel";
            this.roomCancelButton.UseVisualStyleBackColor = true;
            // 
            // roomOkButton
            // 
            this.roomOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.roomOkButton.Enabled = false;
            this.roomOkButton.Location = new System.Drawing.Point(50, 100);
            this.roomOkButton.Name = "roomOkButton";
            this.roomOkButton.Size = new System.Drawing.Size(89, 26);
            this.roomOkButton.TabIndex = 2;
            this.roomOkButton.Text = "&OK";
            this.roomOkButton.UseVisualStyleBackColor = true;
            // 
            // roomNameText
            // 
            this.roomNameText.Location = new System.Drawing.Point(12, 73);
            this.roomNameText.Multiline = true;
            this.roomNameText.Name = "roomNameText";
            this.roomNameText.Size = new System.Drawing.Size(253, 21);
            this.roomNameText.TabIndex = 1;
            this.roomNameText.TextChanged += new System.EventHandler(this.RoomNameText_TextChanged);
            // 
            // AddRoomForm
            // 
            this.AcceptButton = this.roomOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.roomCancelButton;
            this.ClientSize = new System.Drawing.Size(274, 178);
            this.Controls.Add(this.roomCancelButton);
            this.Controls.Add(this.roomOkButton);
            this.Controls.Add(this.roomNameText);
            this.Controls.Add(roomNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoomForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roomCancelButton;
        private System.Windows.Forms.Button roomOkButton;
        private System.Windows.Forms.TextBox roomNameText;
    }
}