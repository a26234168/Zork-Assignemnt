using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Zork.Common
{
    public class Game: INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public World World { get; set; }

        public string StartingLocation { get; set; }
        public string WelcomeMessage { get; set; }
        public string ExitMessage { get; set; }

        [JsonIgnore]
        public Player Player { get;  set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World);
            Player.CurrentRoom = World.RoomsByName[StartingLocation];
        }

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

                command = ToCommand(Console.ReadLine().Trim());

                string outputString;

                switch (command)
                {
                    case Commands.SCORE:
                        outputString = $"Your score: {Player.score}\nYour move(s): {Player.move}";
                        break;

                    case Commands.REWARD:
                        outputString = "Your earned 1 points!";
                        Player.score++;
                        break;

                    case Commands.QUIT:
                        outputString = ExitMessage;
                        break;

                    case Commands.LOOK:
                        outputString = Player.CurrentRoom.Description;
                        Player.move++;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Direction direction = (Direction)command;

                        if(Player.Move(direction) == false)
                        {
                            outputString = "The way is shut!";
                        }
                        else
                        {
                            outputString = "";
                        }

                        Player.move++;
                        break;

                    default:
                        outputString = "Unrecognized command";
                        Player.move++;
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static Commands ToCommand(string commandString)=> Enum.TryParse<Commands>(commandString,true, out Commands command) ? command : Commands.UNKNOWN;
    }
}