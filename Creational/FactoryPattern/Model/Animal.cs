namespace FactoryPattern.Model
{
    public class Animal
    {
        public string Name { get; set; } = "";
        public string Color { get; set; } = "";
        public string Sound { get; set; } = "";

        public void Eat()
        {
            System.Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            System.Console.WriteLine($"{Name} is sleeping.");
        }

        public void MakeSound()
        {
            System.Console.WriteLine($"{Name} says {Sound}.");
        }
        
    }
}