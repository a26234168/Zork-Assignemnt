using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zork.Common
{
    public class Room: INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public string Name { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public Dictionary<Direction, Room> Neighbors { get; set; }

        [JsonProperty(PropertyName = "Neighbors")]
        private Dictionary<Direction, string> NeighborsNames { get; set; }

        public Room(string name, string description = "")
        {
            Name = name;
            Description = description;
        }

        public Room()
        {

        }

        public void UpdateNeighbors(World world)
        {
            Neighbors = new Dictionary<Direction, Room>();

            foreach (var pair in NeighborsNames)
            {
                (Direction direction, string name) = (pair.Key, pair.Value);
                Neighbors.Add(direction, world.RoomsByName[name]);
            }
        }

        public override string ToString() => Name;
    }
}