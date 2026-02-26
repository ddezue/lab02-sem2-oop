namespace lab02_sem2_oop
{
  public class Reptile : Animal
  {
    private bool _isVenomous;

    public Reptile(string animalName, int animalAge, string animalHabitat, string animalDietType, bool animalIsVenomous) : base(animalName, animalAge, animalHabitat, animalDietType)
    {
      _isVenomous = animalIsVenomous;
    }

    public override string GetInfo()
    {
      string venomousStat;
      venomousStat = _isVenomous ? "yes" : "no";
      return base.GetInfo() + $", Type: Reptile, Venomous: {venomousStat}";
    }
  }
}