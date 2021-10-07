using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    class Program
    {

        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));
            game.Run();
        }
        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}




//       private static Room Location
//       {
//           get
//           {
//               return Rooms[LocationRow, LocationColumn];
//           }
//       }

//
//
//
//         Room previousRoom = null;
//
//         Console.WriteLine("Welcome to Zork");
//
//         Commands command = Commands.UNKNOWN;
//         while (command != Commands.QUIT)
//         {
//             Console.WriteLine(Location.Name);
//             if (previousRoom != Location)
//             {
//                 Console.WriteLine(Location.Description);
//                 previousRoom = Location;
//             }
//             Console.Write("> ");
//             command = ToCommand(Console.ReadLine().Trim().ToUpper());
//
//             string outputString;
//             switch (command)
//             {
//                 case Commands.QUIT:
//                     outputString = "Thank you for playing.";
//                     break; 
//                 case Commands.LOOK:
//                     outputString = (Location.Description);
//                     break;
//                 case Commands.NORTH:
//                 case Commands.SOUTH:
//                 case Commands.EAST:
//                 case Commands.WEST:
//                     outputString = Move(command) ? $"you moved {command}," : "The way is shut!";
//                     break;
//
//                 default:
//                     outputString = "Unrecognized command";
//                     break;
//             }
//             Console.WriteLine(outputString);
//
//         }
//     }
//      private static Commands ToCommand(string commandString)
//      {
//          return Enum.TryParse<Commands>(commandString, out Commands command) ? command : Commands.UNKNOWN;
//      }
//      public bool Move(Commands command)
//      {
//          bool didMove = false;
//
//          switch (command)
//          {
//              case Commands.NORTH when (Location.Row < Rooms.GetLength(0) - 1):
//                  Location.Row++;
//                  didMove = true;
//                  break;
//              case Commands.SOUTH when (Location.Row > 0):
//                  Location.Row--;
//                  didMove = true;
//                  break;
//
//              case Commands.EAST when (Location.Column < Rooms.GetLength(1) - 1):
//                  Location.Column++;
//                  didMove = true;
//                  break;
//
//              case Commands.WEST when (Location.Column > 0):
//                  Location.Column--;
//                  didMove = true;
//
//                  break;
//          }
//          return didMove;
//      }
//
//      private static void InitializeRoomDescriptions(string roomDescriptionsFilename)
//      {
//          Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomDescriptionsFilename));
//      }
//      private static  Room[,] Rooms = {
//          { new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View")},
//          { new Room("Forest"), new Room("West of House"), new Room("Behind House")},
//          { new Room("Dense Woods"), new Room("North of House"), new Room("Clearing")}
//      };
//
//      private enum Fields
//      {
//          Name = 0,
//          Description = 1
//      }
//
//      private static int LocationColumn = 1;//this is moving to X
//      private static int LocationRow = 1; //this is moving to Y
//
//
