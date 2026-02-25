using lab02_sem2_oop;
using System;

namespace AnimalZoo
{
  public class Program
  {
    public static void Main(string[] args)
    {
      const int menuExitOption = 3;
      AnimalManager zooManager = AnimalManager.instance;
      int userChoice = 0;

      while (userChoice != menuExitOption)
      {
        DisplayMenu();
        string userInput = Console.ReadLine();

        if (!int.TryParse(userInput, out userChoice))
        {
          Console.WriteLine("\nPlease enter a number from 1 to 3.");
          continue;
        }

        ProcessMenuChoice(zooManager, userChoice);
      }

      Console.WriteLine("\nProgram closed");
    }

    public static void DisplayMenu()
    {
      Console.WriteLine("\nZOO MENU");
      Console.WriteLine("1. Add new animal");
      Console.WriteLine("2. Show all animals");
      Console.WriteLine("3. Exit");
      Console.Write("Choose action: ");
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
          break;

        default:
          Console.WriteLine("\nIPlease choose 1-3.");
          break;
      }
    }

    public static void AddNewAnimal(AnimalManager zooManager)
    {
      Console.WriteLine("\nADDING NEW ANIMAL");

      int animalType = 0;
      bool validType = false;

      while (!validType)
      {
        Console.WriteLine("Select animal type:");
        Console.WriteLine("1. Mammal");
        Console.WriteLine("2. Bird");
        Console.WriteLine("3. Fish");
        Console.WriteLine("4. Reptile");
        Console.WriteLine("5. Amphibian");
        Console.Write("Your choice: ");

        string typeInput = Console.ReadLine();

        if (int.TryParse(typeInput, out animalType) && animalType >= 1 && animalType <= 5)
        {
          validType = true;
        }
        else
        {
          Console.WriteLine("Please enter 1-5.\n");
        }
      }

      Console.Write("Enter name: ");
      string animalName = Console.ReadLine();

      int animalAge = -1;
      while (animalAge < 0)
      {
        Console.Write("Enter age: ");
        string ageInput = Console.ReadLine();

        if (!int.TryParse(ageInput, out animalAge) || animalAge < 0)
        {
          Console.WriteLine("Invalid age.");
          animalAge = -1;
        }
      }

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

    public static void CreateMammal(
      AnimalManager zooManager,
      string animalName,
      int animalAge,
      string animalHabitat,
      string animalDiet)
    {
      bool hasFur = false;
      bool validInput = false;

      while (!validInput)
      {
        Console.Write("Has fur? (yes/no): ");
        string furInput = Console.ReadLine().ToLower();

        if (furInput == "yes" || furInput == "y")
        {
          hasFur = true;
          validInput = true;
        }
        else if (furInput == "no" || furInput == "n")
        {
          hasFur = false;
          validInput = true;
        }
        else
        {
          Console.WriteLine("Еnter yes or no.");
        }
      }

      Mammal newMammal = new Mammal(animalName, animalAge, animalHabitat, animalDiet, hasFur);
      zooManager.AddAnimal(newMammal);
    }

    public static void CreateBird(
      AnimalManager zooManager,
      string animalName,
      int animalAge,
      string animalHabitat,
      string animalDiet)
    {
      double wingSpan = 0;
      bool validInput = false;

      while (!validInput)
      {
        Console.Write("Enter wingspan: ");
        string wingInput = Console.ReadLine();

        if (double.TryParse(wingInput, out wingSpan) && wingSpan >= 0)
        {
          validInput = true;
        }
        else
        {
          Console.WriteLine("Invalid wingspan value.");
        }
      }

      Bird newBird = new Bird(animalName, animalAge, animalHabitat, animalDiet, wingSpan);
      zooManager.AddAnimal(newBird);
    }

    public static void CreateFish(
      AnimalManager zooManager,
      string animalName,
      int animalAge,
      string animalHabitat,
      string animalDiet)
    {
      Console.Write("Enter water type (fresh/salt): ");
      string waterType = Console.ReadLine();

      Fish newFish = new Fish(animalName, animalAge, animalHabitat, animalDiet, waterType);
      zooManager.AddAnimal(newFish);
    }

    public static void CreateReptile(
      AnimalManager zooManager,
      string animalName,
      int animalAge,
      string animalHabitat,
      string animalDiet)
    {
      bool isVenomous = false;
      bool validInput = false;

      while (!validInput)
      {
        Console.Write("Is venomous? (yes/no): ");
        string venomousInput = Console.ReadLine().ToLower();

        if (venomousInput == "yes" || venomousInput == "y")
        {
          isVenomous = true;
          validInput = true;
        }
        else if (venomousInput == "no" || venomousInput == "n")
        {
          isVenomous = false;
          validInput = true;
        }
        else
        {
          Console.WriteLine("Please enter yes or no.");
        }
      }

      Reptile newReptile = new Reptile(animalName, animalAge, animalHabitat, animalDiet, isVenomous);
      zooManager.AddAnimal(newReptile);
    }

    public static void CreateAmphibian(
      AnimalManager zooManager,
      string animalName,
      int animalAge,
      string animalHabitat,
      string animalDiet)
    {
      Console.Write("Enter skin moisture (low/medium/high): ");
      string skinMoisture = Console.ReadLine();

      Amphibian newAmphibian = new Amphibian(animalName, animalAge, animalHabitat, animalDiet, skinMoisture);
      zooManager.AddAnimal(newAmphibian);
    }
  }
}