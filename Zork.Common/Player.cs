using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork
{

    public class Player
    {
        public int score = 0;
        public int move = 0;
        public World World { get; }
        [JsonIgnore]
        public Room CurrentRoom { get; set; }
        [JsonIgnore]

        public Room PreviousRoom { get; set; }

        public List<Item> Inventory { get; set; }

        public Player(World world)
        {
            World = world;
        }

        public bool Move(Direction direction)
        {
            bool isValidMove = CurrentRoom.Neighbors.TryGetValue(direction, out Room neighbor);

            if (isValidMove)
            {
                CurrentRoom = neighbor;
            }
            return isValidMove;
        }

    }
}

