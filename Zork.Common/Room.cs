using System.Collections.Generic;
using Newtonsoft.Json;
namespace Zork
{
    public class Room
    {
        public string Name { get; private set; }

        public string Description { get; private set; }
        [JsonIgnore]
        public Dictionary<Direction, Room> Neighbors { get; set; }
        [JsonProperty(PropertyName = "Neighbors")]
        public Dictionary<Direction, string> NeighborsNames { get; set; }





        public Room(string name,string description = "")
        {
            Name = name;
            Description = description;
        
        }
        public void UpdateNeighbors(World world)
        {
            foreach (var pair in NeighborsNames)
            {
                Neighbors = new Dictionary<Direction, Room>();
                (Directions direction, string name) = (pair, Key, pair.Value);
                Neighbors.Add(direction, world.RoomsByName[name]);
            
            

            }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
