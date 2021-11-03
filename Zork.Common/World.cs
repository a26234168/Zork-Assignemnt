using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Zork.Common

{
    public class World: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //public Room[] Rooms { get; set; }
        public List<Room> Rooms { get; set; }

        public World()
        {
            //Rooms = new Room[] { };
            Rooms = new List<Room>();
        }

        public Dictionary<string, Room> RoomsByName { get; set; }

        [OnDeserialized]
        private void Ondeserialized(StreamingContext context)
        {
            RoomsByName = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                RoomsByName.Add(room.Name, room);
            }

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }
    }
}