using System;
using System.Windows.Forms;

namespace Zork.Builder
{
    public partial class AddRoomForm : Form
    {
        public string RoomName 
        {
            get => roomNameText.Text;
            set => roomNameText.Text = value;
        }

        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void RoomNameText_TextChanged(object sender, EventArgs e)
        {
            roomOkButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
