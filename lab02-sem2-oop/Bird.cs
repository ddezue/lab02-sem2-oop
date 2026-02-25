namespace lab02_sem2_oop
{
  public class Bird : Animal
  {
    public double wingSpan;

    public Bird(string animalName, int animalAge, string animalHabitat, string animalDietType, double animalWingSpan) : base(animalName, animalAge, animalHabitat, animalDietType)
    {
      wingSpan = animalWingSpan;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $", Type: Bird, Wingspan: {wingSpan} m";
    }
  }
}