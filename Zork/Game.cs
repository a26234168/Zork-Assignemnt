﻿using Newtonsoft.Json;
using System.Runtime.Serialization;
using System;

namespace Zork
{
    public class Game
    {
        public World World { get; set; }

        public string StartingLocation { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }
        public string WelcomeMessage { get; set; }
        public string ExitMessage { get; set; }
        public void Run()
        {

            Console.WriteLine(WelcomeMessage);

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.WriteLine(Player.CurrentRoom);
                if (Player.PreviousRoom != Player.CurrentRoom)
                {
                    Console.WriteLine(Player.CurrentRoom.Description);
                    Player.PreviousRoom = Player.CurrentRoom;
                }
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim().ToUpper());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = ExitMessage;
                        break;
                    case Commands.LOOK:
                        outputString = (Player.CurrentRoom.Description);
                        break;
                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Player.Move(command) ? $"you moved {command}," : "The way is shut!";
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
    }
}