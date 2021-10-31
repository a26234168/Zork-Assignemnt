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

        private bool IsWorldLoaded
        {
            get => isWorldLoaded;
            set
            {
                isWorldLoaded = value;
                projectTab.Enabled = IsWorldLoaded;
            }
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
            IsWorldLoaded = false;
        }

        private void openGameFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                //ViewModel.Filename = openFileDialog;
                //Dont know why it wont let me reference Filename
                IsWorldLoaded = true;

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
        private bool isWorldLoaded;


        private void editRoomNameText_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(EditName);
            clearButton.Enabled = !string.IsNullOrEmpty(EditName);

        }

        private void saveGameFile_Click(object sender, EventArgs e)
        {
            ViewModel.SaveWrold();
        }

        private void saveGameFileAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GameViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWrold();
            }
        }
    }
}