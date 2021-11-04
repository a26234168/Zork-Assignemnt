using System.Collections.Generic;
using System.Windows.Forms;
using Zork.Common;

namespace Zork.Builder.DirectionControl
{
    public partial class DirectionControl : UserControl
    {
        public static readonly Room NoNeighbor = new Room() { Name = "None" };
        public static readonly Room NotImplementedNeighbor = new Room() { Name = "NotCurrentlyImplemented" };

        public Direction Directions { get; internal set; }
       
        public Room Room
        {
            get => _Room;
            set
            {
                if (_Room != value)
                {
                    _Room = value;

                    if (Room != null)
                    {
                        var room = new List<Room>(_world.Rooms);
                        room.Insert(0, NoNeighbor);
                        room.Insert(1, NotImplementedNeighbor);
                        neighborsDropDown.SelectedIndexChanged -= NeighborsDropDown_SelectedIndexChanged;
                        neighborsDropDown.DataSource = room;

                        if(_Room.Neighbors.TryGetValue(NeighborDirection, out Room currentRoom))
                        {
                            CurrentRoom = currentRoom;
                        }
                        else
                        {
                            CurrentRoom = NoNeighbor;
                        }

                        neighborsDropDown.SelectedIndexChanged += NeighborsDropDown_SelectedIndexChanged;
                    }
                    else
                    {
                        neighborsDropDown.DataSource = null;
                    }
                }
            }
        }
        
        public Direction NeighborDirection
        {
            get => _Direction;
            set
            {
                _Direction = value;
                directionsDropDown.Text = value.ToString();
            }
        }

        public Room CurrentRoom
        {
            get => (Room)neighborsDropDown.SelectedItem;
            set => neighborsDropDown.SelectedItem = value;
        }

        public DirectionControl()
        {
            InitializeComponent();
        }

        private void NeighborsDropDown_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (_Room != null)
            {
                Room selectedRoom = (Room)neighborsDropDown.SelectedItem;

                if(selectedRoom == NoNeighbor)
                {
                    _Room.Neighbors.Remove(NeighborDirection);
                }
                else
                {
                    _Room.Neighbors[NeighborDirection] = selectedRoom;
                }
            }
        }

        private Direction _Direction;
        private Room _Room;
        private World _world;
    }
}
