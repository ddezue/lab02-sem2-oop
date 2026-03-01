namespace lab02_sem2_oop
{
  public class Bird : Animal
  {
    private int _wingSpan;

    public Bird(string animalName, int animalAge, string animalHabitat, string animalDietType, int animalWingSpan) : base(animalName, animalAge, animalHabitat, animalDietType)
    {
      _wingSpan = animalWingSpan;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $", Type: Bird, Wingspan: {_wingSpan} m";
    }
  }
}