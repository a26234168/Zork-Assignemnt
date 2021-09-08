using System;

namespace Zork
{
    class Program
    {

        private static string Location
        {
            get
            {
                return Rooms[LocationRow, LocationColumn];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{Location}\n> ");
                command = ToCommand(Console.ReadLine().Trim().ToUpper());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing.";
                        break;
                    case Commands.LOOK:
                        outputString = "This is anopen field west of a white house,with a boarded front door.\nArubber mat saying'Welcome to Zork' lies by the door.";

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
                case Commands.NORTH:
                case Commands.SOUTH:
                    break;

                case Commands.EAST when LocationColumn < Rooms.GetLength(1) - 1:
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
        private static string[,] Rooms = {
            { "Rocky Trail", "South of House", "Canyon View"},
            { "Forest", "West of House", "Behind House"},
            { "Dense Woods", "North of House", "Clearing"}
        };


    private static int LocationColumn = 1;
    private static int LocationRow = 0;
    }
}