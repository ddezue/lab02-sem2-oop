namespace Mammal
{
  public class Mammal : Animal
  {
    public bool hasFur;

    public Mammal(string animalName, int animalAge, string animalHabitat, string animalDietType, bool animalHasFur)
      : base(animalName, animalAge, animalHabitat, animalDietType)
    {
      hasFur = animalHasFur;
    }

    public override string GetInfo()
    {
      string furStat = hasFur ? "yes" : "no";
      return base.GetInfo() + $", Type: Mammal, Fur: {furStat}";
    }
  }
}