using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicWorld
{
  //where all my dinosaurs will be stored and tracked
  public class DinoManagement
  {
    public List<Dinosaur> Dinos { get; set; } = new List<Dinosaur>();
    public void AddANewDinosaur(string name, string diet, int weight, int enclosure)
    {
      var Dinosaur = new Dinosaur
      {
        Name = name,
        Diet = diet,
        DateAcquired = DateTime.Now,
        Weight = weight,
        EnclosureNumber = enclosure
      };
      Dinos.Add(Dinosaur);
    }

    public void RemoveDinosaur(string name)
    {
      var dinoToRemove = Dinos.Where(Dinosaur => Dinosaur.Name == name).ToList();
      if (dinoToRemove.Count() > 1)
      {
        Console.WriteLine($"we have found multiple {name}, which do you want to remove");
        for (int i = 0; i < dinoToRemove.Count; i++)
        {
          var dinoName = dinoToRemove[i];
          Console.WriteLine($"{i + 1}: {dinoName.Name}");
        }

        var index = int.Parse(Console.ReadLine());
        Dinos.Remove(dinoToRemove[index - 1]);
      }
      else
      {
        Dinos.Remove(dinoToRemove.First());
      }

    }
    public void Transfer(string name, string enclosure)
    {
      //find first item
      var dinoPen = Dinos.First(Dinosaur => Dinosaur.Name == name);
      //re-assign the feilds
      dinoPen.EnclosureNumber = int.Parse(enclosure);
    }
    public void ThreeHeaviest()
    {
      var heaviest = Dinos.OrderByDescending(dinoPen => dinoPen.Weight).Take(3);
      foreach (var dinoPen in heaviest)
      {
        Console.WriteLine($"{dinoPen.Name}");
      }
    }
    public void DietSummary()
    {
      var vegDino = Dinos.Where(Dinosaur => Dinosaur.Diet.Contains("herbivore")).ToList();
      //without the .tolist() above you would have to use .Count with () in order for it to work. 
      Console.WriteLine($"there are {vegDino.Count} herbivore");

    }
  }
}














