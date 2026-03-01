using lab02_sem2_oop;
using System;

namespace AnimalZoo
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int userChoice;
      string userInput;

      AnimalManager zooManager = AnimalManager.Instance;
      userChoice = 0;

      while (userChoice != 3)
      {
        DisplayMenu();
        userInput = Console.ReadLine();
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
      string typeInput, animalName, ageInput, animalHabitat, animalDiet;
      int animalType, animalAge;


      Console.WriteLine("\nADDING NEW ANIMAL");
      Console.WriteLine("Select animal type:");
      Console.WriteLine("1. Mammal");
      Console.WriteLine("2. Bird");
      Console.WriteLine("3. Fish");
      Console.WriteLine("4. Reptile");
      Console.WriteLine("5. Amphibian");
      Console.Write("Your choice: ");

      typeInput = Console.ReadLine();
      animalType = int.Parse(typeInput);

      Console.Write("Enter name: ");
      animalName = Console.ReadLine();

      Console.Write("Enter age: ");
      ageInput = Console.ReadLine();
      animalAge = int.Parse(ageInput);

      Console.Write("Enter habitat: ");
      animalHabitat = Console.ReadLine();

      Console.Write("Enter diet type (carnivore/herbivore/omnivore): ");
      animalDiet = Console.ReadLine();

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
      string furInput;
      bool hasFur;

      Console.Write("Has fur? (yes/no): ");
      furInput = Console.ReadLine().ToLower();
      hasFur = (furInput == "yes" || furInput == "y");

      Mammal newMammal = new Mammal(animalName, animalAge, animalHabitat, animalDiet, hasFur);
      zooManager.AddAnimal(newMammal);
    }

    public static void CreateBird(AnimalManager zooManager, string animalName, int animalAge, string animalHabitat, string animalDiet)
    {
      int wingSpan;
      string wingInput;

      Console.Write("Enter wingspan (m): ");
      wingInput = Console.ReadLine();
      wingSpan = int.Parse(wingInput);

      Bird newBird = new Bird(animalName, animalAge, animalHabitat, animalDiet, wingSpan);
      zooManager.AddAnimal(newBird);
    }

    public static void CreateFish(AnimalManager zooManager, string animalName, int animalAge, string animalHabitat, string animalDiet)
    {
      string waterType;

      Console.Write("Enter water type (fresh/salt): ");
      waterType = Console.ReadLine();

      Fish newFish = new Fish(animalName, animalAge, animalHabitat, animalDiet, waterType);
      zooManager.AddAnimal(newFish);
    }

    public static void CreateReptile(AnimalManager zooManager, string animalName, int animalAge, string animalHabitat, string animalDiet)
    {
      string venomInput;
      bool isVenomous;

      Console.Write("Is venomous? (yes/no): ");
      venomInput = Console.ReadLine().ToLower();
      isVenomous = (venomInput == "yes");

      Reptile newReptile = new Reptile(animalName, animalAge, animalHabitat, animalDiet, isVenomous);
      zooManager.AddAnimal(newReptile);
    }

    public static void CreateAmphibian(AnimalManager zooManager, string animalName, int animalAge, string animalHabitat, string animalDiet)
    {
      string skinMoisture;

      Console.Write("Enter skin moisture (low/medium/high): ");
      skinMoisture = Console.ReadLine();

      Amphibian newAmphibian = new Amphibian(animalName, animalAge, animalHabitat, animalDiet, skinMoisture);
      zooManager.AddAnimal(newAmphibian);
    }
  }
}