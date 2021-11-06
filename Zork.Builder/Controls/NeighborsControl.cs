using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zork.Common;

namespace Zork.Builder.Controls
{
    public partial class NeighborsControl : UserControl
    {
        private static readonly Room NoNeighbor = new Room() { Name = "None" };
        private static readonly Room NotImplemented = new Room() { Name = "Not Implemented" };

        public Room Room
        {
            get => _Room;
            set
            {
                if (_Room != null)
                {
                    _Room = value;

                    if (Room != null)
                    {
                        var room = new List<Room>(_viewModel.Rooms);
                        room.Insert(0, NoNeighbor);
                        room.Insert(1, NotImplemented);
                        neighborsSelectedDropDown.SelectedIndexChanged -= NeighborsSelectedDropDown_SelectedIndexChanged;
                        neighborsSelectedDropDown.DataSource = room;

                        if (_Room.Neighbors.TryGetValue(NeighborsDirection, out Room currentNeighbor))
                        {
                            CurrentNeighbor = currentNeighbor;
                        }
                        else
                        {
                            CurrentNeighbor = NoNeighbor;
                        }

                        if (currentNeighbor == (Room)neighborsSelectedDropDown.SelectedItem)
                        {
                            room.Remove(currentNeighbor);
                        }

                        neighborsSelectedDropDown.SelectedIndexChanged += NeighborsSelectedDropDown_SelectedIndexChanged;
                    }
                    else
                    {
                        neighborsSelectedDropDown.DataSource = null;
                    }
                }
            }
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

        public NeighborsControl()
        {
            InitializeComponent();
        }

        public Direction NeighborsDirection
        {
            get => _NeighborsDirection;
            set
            {
                _NeighborsDirection = value;
                neighborsDirectionTextbox.Text = _NeighborsDirection.ToString();
            }
        }

        public Room CurrentNeighbor 
        {
            get => (Room)neighborsSelectedDropDown.SelectedItem;
            set=> neighborsSelectedDropDown.SelectedItem = value;
        }

        public NeighborsControl(Direction neighborsDirection, Room room)
        {
            NeighborsDirection = neighborsDirection;
            Room = room ?? throw new ArgumentNullException(nameof(room));
        }

        private void NeighborsSelectedDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_Room != null)
            {
                Room selectedRoom = (Room)neighborsSelectedDropDown.SelectedItem;
                if (selectedRoom == NoNeighbor)
                {
                    _Room.Neighbors.Remove(NeighborsDirection);
                }
                else
                {
                    _Room.Neighbors[NeighborsDirection] = selectedRoom;
                }
            }
        }

        private Room _Room;
        private GameViewModel _viewModel;
        private Direction _NeighborsDirection;
    }
}