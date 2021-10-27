using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Zork;

namespace Programming
{
    public partial class ZorkGUI : Form
    {
        public ZorkGUI()
        {
            InitializeComponent();
        }

        private void OpenGameFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string JsonString = File.ReadAllText(openFileDialog.FileName);
                JsonConvert.DeserializeObject<World>(JsonString);

            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
