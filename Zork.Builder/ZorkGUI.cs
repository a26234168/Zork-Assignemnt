using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Zork.Common;

namespace Zork.Builder
{
    public partial class ZorkGUI : Form
    {
        internal GameViewModel ViewModel { get; private set; }
        public ZorkGUI()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
        }

        private void openGameFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));

            }
        }

        private void quitFile_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}