using lab02_sem2_oop;
using System;

namespace AnimalZoo
{
  public class Program
  {
    public static void Main(string[] args)
    {
      AnimalManager zooManager = AnimalManager.instance;
      int userChoice = 0;

      while (userChoice != 3)
      {
        DisplayMenu();
        string userInput = Console.ReadLine();
        userChoice = int.Parse(userInput);
        ProcessMenuChoice(zooManager, userChoice);
      }
    }

    public static void DisplayMenu()
    {
      Console.WriteLine("\nZOO MENU");
      Console.WriteLine("1. Add new animal");
      Console.WriteLine("2. Show all animals");
      Console.WriteLine("3. Exit");
      Console.Write("Your choice: ");
    }

    public static void ProcessMenuChoice(AnimalManager zooManager, int userChoice)
    {
      switch (userChoice)
      {
        case 1:
          AddNewAnimal(zooManager);
          break;

        case 2:
          zooManager.ShowAllAnimals();
          break;

        case 3:
          Console.WriteLine("\nBye");
          break;

        default:
          Console.WriteLine("\nIPlease choose 1-3.");
          break;
      }
    }

    public static void AddNewAnimal(AnimalManager zooManager)
    {
      Console.WriteLine("\nADDING NEW ANIMAL");

      Console.WriteLine("Select animal type:");
      Console.WriteLine("1. Mammal");
      Console.WriteLine("2. Bird");
      Console.WriteLine("3. Fish");
      Console.WriteLine("4. Reptile");
      Console.WriteLine("5. Amphibian");
      Console.Write("Your choice: ");

      string typeInput = Console.ReadLine();
      int animalType = int.Parse(typeInput);

      Console.Write("Enter name: ");
      string animalName = Console.ReadLine();

      Console.Write("Enter age: ");
      string ageInput = Console.ReadLine();
      int animalAge = int.Parse(ageInput);

      Console.Write("Enter habitat: ");
      string animalHabitat = Console.ReadLine();

      Console.Write("Enter diet type (carnivore/herbivore/omnivore): ");
      string animalDiet = Console.ReadLine();

      CreateAnimalByType(zooManager, animalType, animalName, animalAge, animalHabitat, animalDiet);
    }

    public static void CreateAnimalByType(
      AnimalManager zooManager,
      int animalType,
      string animalName,
      int animalAge,
      string animalHabitat,
      string animalDiet)
    {
      switch (animalType)
      {
        case 1:
          CreateMammal(zooManager, animalName, animalAge, animalHabitat, animalDiet);
          break;

        case 2:
          CreateBird(zooManager, animalName, animalAge, animalHabitat, animalDiet);
          break;

        case 3:
          CreateFish(zooManager, animalName, animalAge, animalHabitat, animalDiet);
          break;

        case 4:
          CreateReptile(zooManager, animalName, animalAge, animalHabitat, animalDiet);
          break;

        case 5:
          CreateAmphibian(zooManager, animalName, animalAge, animalHabitat, animalDiet);
          break;
      }
    }

    public static void CreateMammal(AnimalManager zooManager, string animalName, int animalAge, string animalHabitat, string animalDiet)
    {
      Console.Write("Has fur? (yes/no): ");
      string furInput = Console.ReadLine().ToLower();
      bool hasFur = (furInput == "yes" || furInput == "y");

      Mammal newMammal = new Mammal(animalName, animalAge, animalHabitat, animalDiet, hasFur);
      zooManager.AddAnimal(newMammal);
    }

    public static void CreateBird(AnimalManager zooManager, string animalName, int animalAge, string animalHabitat, string animalDiet)
    {
      Console.Write("Enter wingspan (m): ");
      string wingInput = Console.ReadLine();
      double wingSpan = double.Parse(wingInput);

      Bird newBird = new Bird(animalName, animalAge, animalHabitat, animalDiet, wingSpan);
      zooManager.AddAnimal(newBird);
    }

    public static void CreateFish(AnimalManager zooManager, string animalName, int animalAge, string animalHabitat, string animalDiet)
    {
      Console.Write("Enter water type (fresh/salt): ");
      string waterType = Console.ReadLine();

      Fish newFish = new Fish(animalName, animalAge, animalHabitat, animalDiet, waterType);
      zooManager.AddAnimal(newFish);
    }

    public static void CreateReptile(AnimalManager zooManager, string animalName, int animalAge, string animalHabitat, string animalDiet)
    {
      Console.Write("Is venomous? (yes/no): ");
      string venomInput = Console.ReadLine().ToLower();
      bool isVenomous = (venomInput == "yes");

      Reptile newReptile = new Reptile(animalName, animalAge, animalHabitat, animalDiet, isVenomous);
      zooManager.AddAnimal(newReptile);
    }

    public static void CreateAmphibian(AnimalManager zooManager, string animalName, int animalAge, string animalHabitat, string animalDiet)
    {
      Console.Write("Enter skin moisture (low/medium/high): ");
      string skinMoisture = Console.ReadLine();

      Amphibian newAmphibian = new Amphibian(animalName, animalAge, animalHabitat, animalDiet, skinMoisture);
      zooManager.AddAnimal(newAmphibian);
    }
  }
}