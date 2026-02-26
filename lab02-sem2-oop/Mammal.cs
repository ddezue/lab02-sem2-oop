namespace lab02_sem2_oop
{
  public class Mammal : Animal
  {
    private bool _hasFur;

    public Mammal(string animalName, int animalAge, string animalHabitat, string animalDietType, bool animalHasFur) : base(animalName, animalAge, animalHabitat, animalDietType)
    {
      _hasFur = animalHasFur;
    }

    public override string GetInfo()
    {
      string furStat;
      furStat = _hasFur ? "yes" : "no";
      return base.GetInfo() + $", Type: Mammal, Fur: {furStat}";
    }
  }
}