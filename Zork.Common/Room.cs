using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zork.Common
{
    //AddedJsonConverter
    [JsonConverter(typeof(RoomConverter))]
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

        //added Dictionary to Constructor
        public Room(string name, string description = "", Dictionary<Direction, string> neighborsNames = null)
        {
            Name = name;
            Description = description;
            //Added
            NeighborsNames = neighborsNames;
            Neighbors = new Dictionary<Direction, Room>();
        }

        //Added BuildNeighborsFromNames
        public void  BuildNeighborsFromNames(List<Room> rooms)
        {
            Neighbors = (from entry in NeighborsNames
                         let room = rooms.Find(r => r.Name.Equals(entry.Value, System.StringComparison.InvariantCultureIgnoreCase))
                         where room != null
                         select (NeighborsDirection: entry.Key, Room: room)).ToDictionary(pair => pair.NeighborsDirection, pair => pair.Room);

            NeighborsNames.Clear();
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

        //Added RoomConverter Class
        public class RoomConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Room));
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jsonObject = JObject.Load(reader);

                string name = jsonObject["Name"].Value<string>();
                string description = jsonObject["Description"].Value<string>();

                Dictionary<Direction, string> neighborsNames;

                if (jsonObject.TryGetValue("Neighbors", out JToken neighborsNamesToken))
                {
                    neighborsNames = neighborsNamesToken.ToObject<Dictionary<Direction, string>>();
                }
                else
                {
                    neighborsNames = new Dictionary<Direction, string>();
                }

                return new Room(name, description, neighborsNames);
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                Room room = (Room)value;
                JToken neighborsNamesToken = JToken.FromObject(room.Neighbors.ToDictionary(pair => pair.Key, pair => pair.Value.Name), serializer);

                JObject roomObject = new JObject
                {
                    { nameof(Room.Name), room.Name },
                    { nameof(Room.Description), room.Description },
                    { nameof(Room.Neighbors), neighborsNamesToken },
                };

                roomObject.WriteTo(writer);
            }

        }

        public override string ToString() => Name;
    }
}