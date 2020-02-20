using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var dinoPen = new DinoManagement();
      //allows the while 
      var isRunning = true;


      while (isRunning)
      {
        Console.WriteLine("Welcome to Jurassic World");
        Console.WriteLine("What would you like to do");
        Console.WriteLine("(ADD) a dinosaur");
        Console.WriteLine("(REMOVE) a dinosaur");
        Console.WriteLine("(TRANSFER) a dinosaur");
        Console.WriteLine("(VIEW) the three heaviest dinosaurs");
        Console.WriteLine("See the different (DIET) types");
        Console.WriteLine("(QUIT)");
        var input = Console.ReadLine().ToLower();

        if (input == "add")
        {

          Console.WriteLine("what is the Dinosaurs name");
          var name = Console.ReadLine().ToLower();
          Console.WriteLine("what is the Dinosaurs weight");
          int weight = int.Parse(Console.ReadLine());
          Console.WriteLine("what is the diet type of the Dinosaur (CARNIVORE) or (HERBIVORE)");
          var diet = Console.ReadLine().ToLower();
          Console.WriteLine("pick an enclosure number to store your Dinosaur in");
          int enclosure = int.Parse(Console.ReadLine());
          Console.WriteLine("Thank you for your dinosaur");
          dinoPen.AddANewDinosaur(name, diet, weight, enclosure);

        }
        else if (input == "remove")
        {
          Console.WriteLine("what is the Dinosaurs name");
          var dinoName = Console.ReadLine().ToLower();
          dinoPen.RemoveDinosaur(dinoName);
        }
        else if (input == "view")
        {
          foreach (var d in dinoPen.Dinos)
          {
            Console.WriteLine($"{d.Name}");
          }
        }
        else if (input == "diet")
        {
          foreach (var d in dinoPen.Dinos)
          {
            Console.WriteLine($"{d.Name} + {d.Diet}");
          }

        }
        else if (input == "tranfer")
        {
          Console.WriteLine("who do you want to transfer")
          var dinoName = Console.ReadLine().ToLower()
        }


      }
    }

  }
}

