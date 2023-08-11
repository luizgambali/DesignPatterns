using FactoryPattern.Model;

namespace FactoryPattern.Factory
{
    public class CatFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            return new Animal() { Name = "Cat", Color = "White", Sound = "Meow"} ;
        }
    }
}