namespace lab02_sem2_oop
{
  public class Mammal : Animal
  {
    private bool hasFur;

    public Mammal(string animalName, int animalAge, string animalHabitat, string animalDietType, bool animalHasFur) : base(animalName, animalAge, animalHabitat, animalDietType)
    {
      hasFur = animalHasFur;
    }

    public override string GetInfo()
    {
      string furStat;
      furStat = hasFur ? "yes" : "no";
      return base.GetInfo() + $", Type: Mammal, Fur: {furStat}";
    }
  }
}