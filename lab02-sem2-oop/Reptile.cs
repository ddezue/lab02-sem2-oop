namespace lab02_sem2_oop
{
  public class Reptile : Animal
  {
    public bool isVenomous;

    public Reptile(string animalName, int animalAge, string animalHabitat, string animalDietType, bool animalIsVenomous) : base(animalName, animalAge, animalHabitat, animalDietType)
    {
      isVenomous = animalIsVenomous;
    }

    public override string GetInfo()
    {
      string venomousStat = isVenomous ? "yes" : "no";
      return base.GetInfo() + $", Type: Reptile, Venomous: {venomousStat}";
    }
  }
}