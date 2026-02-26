using System;
using System.Collections.Generic;

namespace lab02_sem2_oop
{
  public sealed class AnimalManager
  {

    public static AnimalManager instance = new AnimalManager();
    private List<Animal> animalList = new List<Animal>();

    public AnimalManager() { }

    public void AddAnimal(Animal newAnimal)
    {
      if (newAnimal != null)
      {
        animalList.Add(newAnimal);
        Console.WriteLine($"\nAnimal {newAnimal.name} added");
      }
    }

    public void ShowAllAnimals()
    {
      if (animalList.Count == 0)
      {
        Console.WriteLine("\nAnimal list is empty.");
        return;
      }

      int countingFromOne;
      countingFromOne = 1;

      Console.WriteLine("\nALL ANIMALS LIST");
      for (int animalIndex = 0; animalIndex < animalList.Count; ++animalIndex)
      {
        Console.WriteLine($"{animalIndex + countingFromOne}. {animalList[animalIndex].GetInfo()}");
      }
    }

    public void ShowAnimalByIndex(int animalIndex)
    {
      if (animalIndex >= 0 && animalIndex < animalList.Count)
      {
        Console.WriteLine($"\n{animalList[animalIndex].GetInfo()}");
      }
      else
      {
        Console.WriteLine("\nAnimal with this index not found.");
      }
    }

    public void ShowAnimalByName(string animalName)
    {
      bool animalFound;
      animalFound = false;

      for (int animalIndex = 0; animalIndex < animalList.Count; ++animalIndex)
      {
        if (animalList[animalIndex].name.Equals(animalName, StringComparison.OrdinalIgnoreCase))
        {
          Console.WriteLine($"\n{animalList[animalIndex].GetInfo()}");
          animalFound = true;
          break;
        }
      }

      if (!animalFound)
      {
        Console.WriteLine($"\nAnimal with name '{animalName}' not found.");
      }
    }
  }
}