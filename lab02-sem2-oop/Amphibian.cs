namespace lab02_sem2_oop
{
  public class Amphibian : Animal
  {
    private string _skinMoisture;

    public Amphibian(string animalName, int animalAge, string animalHabitat, string animalDietType, string animalSkinMoisture) : base(animalName, animalAge, animalHabitat, animalDietType)
    {
      _skinMoisture = animalSkinMoisture;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $", Type: Amphibian, Skin moisture: {_skinMoisture}";
    }
  }
}