using System;
using System.ComponentModel;
using Zork.Common;
using Newtonsoft.Json;
using System.IO;

namespace Zork.Builder
{
    internal class GameViewModel : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public BindingList<Room> Rooms { get; set; }

        public string StartingLocation
        {
            get => _game.StartingLocation;
            set => _game.StartingLocation = value;
        }

        public string WelcomeMessage
        {
            get => _game.WelcomeMessage;
            set => _game.WelcomeMessage = value;
        }

        public string ExitMessage 
        {
            get => _game.ExitMessage;
            set => _game.ExitMessage = value;
        }

        public Game Game
        {
            set
            {
                if (_game != value)
                {
                    _game = value;

                    if (_game != null)
                    {
                        StartingLocation = _game.StartingLocation;

                        WelcomeMessage = _game.WelcomeMessage;

                        ExitMessage = _game.ExitMessage;

                        Rooms = new BindingList<Room>(_game.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }

        public static string Filename { get; internal set; }

        public void SaveWorld()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            using (StreamWriter streamWriter = new StreamWriter(Filename))

            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _game);
            }
        }

        private Game _game;
    }
}