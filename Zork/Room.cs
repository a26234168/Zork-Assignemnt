namespace Zork
{
    public class Room
    {
        public string Name { get; }

        public string Description { get; set; }

        public Room(string name,string descritipn = "")
        {
            Name = name;
            Description = descritipn;
        
        }
    }
}
