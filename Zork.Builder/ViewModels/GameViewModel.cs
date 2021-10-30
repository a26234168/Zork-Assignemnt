using System;
using System.ComponentModel;
using Zork.Common;

namespace Zork.Builder
{
    internal class GameViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BindingList<Room> Rooms { get; set; }
        public string StartingLocation { get; set; }
        public string WelcomeMessage { get; set; }
        public string ExitMessage { get; set; }

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

        private Game _game;
    }
}

