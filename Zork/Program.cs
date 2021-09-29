using System;
using System.Collections.Generic;
using System.IO;

namespace Zork
{
    class Program
    {

        private static Room Location
        {
            get
            {
                return Rooms[LocationRow, LocationColumn];
            }
        }
        static void Main(string[] args)
        {
            const string roomDescriptionsFilename = "Rooms.txt";
            InitializeRoomDescriptions(roomDescriptionsFilename);

            Room previousRoom = null;

            Console.WriteLine("Welcome to Zork");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.WriteLine(Location.Name);
                if (previousRoom != Location)
                {
                    Console.WriteLine(Location.Description);
                    previousRoom = Location;
                }
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim().ToUpper());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing.";
                        break;
                    case Commands.LOOK:
                        outputString = (Location.Description);
                        break;
                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"you moved {command}," : "The way is shut!";
                        break;

                    default:
                        outputString = "Unrecognized command";
                        break;
                }
                Console.WriteLine(outputString);

            }
        }
        private static Commands ToCommand(string commandString)
        {
            return Enum.TryParse<Commands>(commandString, out Commands command) ? command : Commands.UNKNOWN;
        }
        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when (LocationRow < Rooms.GetLength(0) - 1):
                    LocationRow++;
                    didMove = true;
                    break;
                case Commands.SOUTH when (LocationRow > 0):
                    LocationRow--;
                    didMove = true;
                    break;

                case Commands.EAST when (LocationColumn < Rooms.GetLength(1) - 1):
                    LocationColumn++;
                    didMove = true;
                    break;

                case Commands.WEST when (LocationColumn > 0):
                    LocationColumn--;
                    didMove = true;

                    break;
            }
            return didMove;
        }

        private static void InitializeRoomDescriptions(string roomDescriptionsFilename)
        {
            var roomMap = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                roomMap.Add(room.Name, room);
            }

            string[] lines = File.ReadAllLines(roomDescriptionsFilename);
            foreach (string line in lines)
            {
                const string delimiter = "##";
                const int expectedFieldCount = 2;

                string [] fields = line.Split(delimiter);
                if (fields.Length != expectedFieldCount)
                {
                    Console.WriteLine("Invalid record");
                }
                (string name, string description) = (fields[(int)Fields.Name], fields[(int)Fields.Description]);
                roomMap[name].Description = description;
            }
        }
        private static readonly Room[,] Rooms = {
            { new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View")},
            { new Room("Forest"), new Room("West of House"), new Room("Behind House")},
            { new Room("Dense Woods"), new Room("North of House"), new Room("Clearing")}
        };

        private enum Fields
        {
            Name = 0,
            Description = 1
        }

        private static int LocationColumn = 1;//this is moving to X
        private static int LocationRow = 1; //this is moving to Y
    }
    
}