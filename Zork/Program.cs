﻿using System;

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
            InitializeRoomDescriptions();
            Console.WriteLine("Welcome to Zork");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{Location.Name}\n> ");
                command = ToCommand(Console.ReadLine().Trim().ToUpper());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing.";
                        break;
                    case Commands.LOOK:
                        outputString = 
                            
                            "This is anopen field west of a white house,with a boarded front door.\nArubber mat saying'Welcome to Zork' lies by the door.";

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
        private  static bool Move(Commands command)
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

        private static void InitializeRoomDescriptions()
        {
            Rooms[0, 0].Description = "You are on a rock-strwn trail.";
            Rooms[0, 1].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";
            Rooms[0, 2].Description = "You are at the top of the Great Canyon on its south wall.";
            Rooms[1, 0].Description = "This is a forest, with trees in all directions around you.";
            Rooms[1, 1].Description = "This is an open field west of a white house, with house, with a boarded front door";
            Rooms[1, 2].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly jar";
            Rooms[2, 0].Description = "This is a dimly lit forest, with large trees all around. To the east, there appears to be sunlight.";
            Rooms[2, 1].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred";
            Rooms[2, 2].Description = "You are in a clearing, with a forest surrounding you on the west and south";

        }
        private static readonly Room[,] Rooms = {
            { new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View")},
            { new Room("Forest"), new Room("West of House"), new Room("Behind House")},
            { new Room("Dense Woods"), new Room("North of House"), new Room("Clearing")}
        };

    private static int LocationColumn = 1;//this is moving to X
    private static int LocationRow = 1; //this is moving to Y
    }
}