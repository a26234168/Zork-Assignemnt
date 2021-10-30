using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Zork.Common;

namespace Zork.Builder
{
    public partial class ZorkGUI : Form
    {
        //For the name of the default room you get by clicking addButton.
        private int DefaultNameNumber = 0;
        public string EditName
        {
            get => editRoomNameText.Text;
            set => editRoomNameText.Text = value;
        }
        public string SeletRoom
        {
            get => selectDropDown.Text;
            set => selectDropDown.Text = value;
        }
        private GameViewModel ViewModel 
        {
            get => _viewModel;
            set
            {
                if(_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }
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

        private void addButton_Click(object sender, EventArgs e)
        {
           /*
           Need to find a way to work around BindingLists being read-only. Since ViewModel.Rooms is a BindingList, it creates an error.

           Room room = new Room() { Name = $"DefaultRoom{DefaultNameNumber}"};
           ViewModel.Rooms.Add(room);
           DefaultNameNumber++; 
           */
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private GameViewModel _viewModel;

        private void editRoomNameText_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(EditName);
            clearButton.Enabled = !string.IsNullOrEmpty(EditName);

        }

    }
}