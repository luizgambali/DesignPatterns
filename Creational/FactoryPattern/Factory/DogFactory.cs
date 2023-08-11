using FactoryPattern.Model;

namespace FactoryPattern.Factory
{
    public class DogFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            return new Animal() { Name = "Dog", Color = "Black", Sound = "Woof" };
        }
    }
}