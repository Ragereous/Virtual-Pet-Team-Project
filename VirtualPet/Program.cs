﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace VirtualPet
{
    class Program
    {

        static void Main(string[] args)
        {
            //what is the species of your pet?

            //pet name=petname
            //while //tic? status
            //what do you want to do
            //1 feed
            //2
            //3
            //4
            //switch()
            //{

            //} 
            Pet pet = new Pet();
            Console.WriteLine("Hello! Welcome to Virtual Pets");

            Console.WriteLine("What is the name of your pet?");
            string name = Console.ReadLine();
            pet.SetName(name);
            //Console.WriteLine(pet.GetName());

            Console.WriteLine("What species is your pet?");
            string species = Console.ReadLine();
            pet.SetSpecies(species);

            bool petChoice = true;
            while (petChoice)
            {
                // Add status display when they enter the loop
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Feed your Pet");
                Console.WriteLine("2. Play with your Pet");
                Console.WriteLine("3. Take your Pet to the doctor");
                Console.WriteLine("4. Check your Pet's status");
                Console.WriteLine("5. Quit");

                ///determine where to add Ticks
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        pet.Feed();
                        Console.WriteLine($"You fed {name}.");
                        break;
                    case "2":
                        pet.Play();
                        Console.WriteLine($"You and {name} played in the meadow together!");
                        break;
                    case "3": ///ad cw to show indication of what seeing the doctor does for your pet
                        pet.SeeDoctor();
                        Console.WriteLine($"You took {name} to the vet for health.");
                        break;
                    case "4": ///add pet name string name and add cw for every status
                        Console.WriteLine($"Hunger:{pet.GetHunger()}, Boredom {pet.GetBoredom()}, Pet Health {pet.GetHealth()}.");
                        break;
                    case "5":
                        petChoice = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry.");
                        break;
                }
                Console.WriteLine("Press Enter to continue.");
                Console.ReadKey();
                Console.Clear();
            }






        }
    }
}
