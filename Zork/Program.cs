﻿using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork");

            string inputString = Console.ReadLine();
            inputString = inputString.ToUpper();
            if (inputString == "QUIT")
            {
                Console.WriteLine("Thank you for playing");
            }
            else if (inputString == "LOOK")
            {
                Console.WriteLine("This is anopen field west of a white house,with a boarded front door.\n Arubber mat saying'Welcome to Zork' lies by the door.");
            }
            else
            {
                Console.WriteLine("Unrecognized command.");
            }
        }
    }
}
