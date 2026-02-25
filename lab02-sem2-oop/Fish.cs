namespace lab02_sem2_oop

{
  public class Fish : Animal
  {
    private string waterType;

    public Fish(string animalName, int animalAge, string animalHabitat, string animalDietType, string animalWaterType)
      : base(animalName, animalAge, animalHabitat, animalDietType)
    {
      waterType = animalWaterType;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $", Type: Fish, Water type: {waterType}";
    }
  }
}