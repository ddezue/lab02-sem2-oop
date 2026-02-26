namespace lab02_sem2_oop
{
  public class Animal
    {
    public string _name;
    private int _age;
    private string _habitat;
    private string _dietType;

    public Animal(string animalName, int animalAge, string animalHabitat, string animalDietType)
    {
      _name = animalName;
      _age = animalAge;
      _habitat = animalHabitat;
      _dietType = animalDietType;
    }

        public virtual string GetInfo()
        {
            return $"Name: {_name}, Age: {_age}, Habitat: {_habitat}, Diet: {_dietType}";
        }
    }
}