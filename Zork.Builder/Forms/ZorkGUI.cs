using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Zork.Common;
using System.Reflection;

namespace Zork.Builder
{
    public partial class ZorkGUI : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);
                }
            }
            /*
            Room room = new Room() { Name = $"DefaultRoom{DefaultNameNumber}"};
            ViewModel.Rooms.Add(room);
            DefaultNameNumber++; 
            */
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void CurrentRoomTextbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = currentRoomTextbox.SelectedItem != null;
        }

        private void EditRoomNameText_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(EditName);
            clearButton.Enabled = !string.IsNullOrEmpty(EditName);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }

        private void OpenGameFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                GameViewModel.Filename = openFileDialog.FileName;
                
                IsWorldLoaded = true;

            }
        }

        private void QuitFile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)selectDropDown.SelectedItem);
                selectDropDown.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }

        private void SaveGameFile_Click(object sender, EventArgs e)
        {
            ViewModel.SaveWorld();
        }

        private void SaveGameFileAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GameViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        private GameViewModel _viewModel;
        private bool isWorldLoaded;
    }
}