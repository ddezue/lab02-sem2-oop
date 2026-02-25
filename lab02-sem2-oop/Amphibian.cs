namespace lab02_sem2_oop
{
  public class Amphibian : Animal
  {
    public string skinMoisture;

    public Amphibian(string animalName, int animalAge, string animalHabitat, string animalDietType, string animalSkinMoisture) : base(animalName, animalAge, animalHabitat, animalDietType)
    {
      skinMoisture = animalSkinMoisture;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $", Type: Amphibian, Skin moisture: {skinMoisture}";
    }
  }
}