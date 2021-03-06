﻿using System;
using System.Linq;
using Trestlebridge.Actions;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge
{
    class Program
    {
        public static void DisplayBanner ()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
            Console.WriteLine();
        }

        static bool InputWasInvalid = false;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Farm Trestlebridge = new Farm();

            while (true)
            {
                DisplayBanner();
                Console.WriteLine("1. Create Facility");
                Console.WriteLine("2. Purchase Animals");
                Console.WriteLine("3. Purchase Seeds");
                Console.WriteLine("4. Display Farm Status");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                if (InputWasInvalid)
                {
                    Console.WriteLine("Input was invalid, please try again.");
                }
                Console.WriteLine("Choose a FARMS option");
                Console.Write("> ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    DisplayBanner();
                    InputWasInvalid = false;
                    CreateFacility.CollectInput(Trestlebridge);
                }
                else if (option == "2")
                {
                    DisplayBanner();
                    InputWasInvalid = false;
                    PurchaseStock.CollectInput(Trestlebridge);
                }
                  else if (option == "3")
                {
                    DisplayBanner();
                    PurchaseSeed.CollectInput(Trestlebridge);
                }
                else if (option == "4")
                {
                    DisplayBanner();
                    InputWasInvalid = false;
                    Console.WriteLine(Trestlebridge);
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                }
                else if (option == "5")
                {
                    Console.WriteLine("Today is a great day for farming");
                    break;
                }
                else
                {
                    InputWasInvalid = true;
                }
            }
        }
    }
}
