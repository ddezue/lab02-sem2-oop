namespace lab02_sem2_oop
{
  public class Animal
    {
    public string name;
    private int age;
    private string habitat;
    private string dietType;

    public Animal(string animalName, int animalAge, string animalHabitat, string animalDietType)
    {
      name = animalName;
      age = animalAge;
      habitat = animalHabitat;
      dietType = animalDietType;
    }

        public virtual string GetInfo()
        {
            return $"Name: {name}, Age: {age}, Habitat: {habitat}, Diet: {dietType}";
        }
    }
}