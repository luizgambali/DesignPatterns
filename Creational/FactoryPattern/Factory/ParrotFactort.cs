using FactoryPattern.Model;

namespace FactoryPattern.Factory
{
    public class ParrotFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            return new Animal() { Name = "Parrot", Color = "Green", Sound = "Squawk"} ;
        }
    }
}