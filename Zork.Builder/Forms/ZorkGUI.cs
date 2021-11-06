using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Zork.Common;
using System.Reflection;
using System.Collections.Generic;
using Zork.Builder.Controls;

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

        public ZorkGUI()
        {
            InitializeComponent();

            ViewModel = new GameViewModel();

            IsWorldLoaded = false;

          _NeighborsControlMap = new Dictionary<Direction, NeighborsControl>
            {
                  { Direction.NORTH, northNeighborsControl },
                  { Direction.SOUTH, eastNeighborsControl },
                  { Direction.EAST, southNeighborsControl },
                  { Direction.WEST, westNeighborsControl },
                  { Direction.UP, upNeighborsControl },
                  { Direction.DOWN, downNeighborsControl }
            };
        }

        private GameViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }
            }
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
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented. Type Inside of TextBox Instead.");
        }

        private void CurrentRoomTextbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = currentRoomTextbox.SelectedItem != null;

            Room selectedRoom = currentRoomTextbox.SelectedItem as Room;

           foreach (KeyValuePair<Direction, NeighborsControl> entry in _NeighborsControlMap)
           {
               entry.Value.Room = selectedRoom;
           }
        }

        private void EditRoomNameText_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(EditName);

            clearButton.Enabled = !string.IsNullOrEmpty(EditName);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented. Type Inside of TextBox Instead.");
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

        private void newGameFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We spent hours trying to figure this out but couldn't in time. We did genuinely try, though");
        }

       private GameViewModel _viewModel;
        private bool isWorldLoaded;

        private readonly Dictionary<Direction, NeighborsControl> _NeighborsControlMap;
    }
}