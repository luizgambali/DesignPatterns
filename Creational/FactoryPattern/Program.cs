/*
    The Factory Pattern is a creational pattern that defines an interface for creating an object, but let subclasses decide which class to instantiate.
    In this example, we have an AnimalFactory that can create different animals based upon the type of animal.

    We can use interfaces or abstract classes to define the AnimalFactory, and then we create a concrete class for each type of animal.

    About Abstract Classes x Interfaces:
    If you need to provide a base for a hierarchy of classes or provide a common implementation, you should use abstract classes. 
    If you need to define behavior that can be implemented by multiple unrelated classes, you should use interfaces.

    Reference: https://www.dofactory.com/net/factory-method-design-pattern
*/
using FactoryPattern.Model;
using FactoryPattern.Factory;

AnimalFactory catFactory = new CatFactory();
AnimalFactory parrotFactory = new ParrotFactory();
AnimalFactory dogFactory = new DogFactory();

Animal cat = catFactory.CreateAnimal();
Animal parrot = parrotFactory.CreateAnimal();
Animal dog = dogFactory.CreateAnimal();

cat.Eat();
cat.Sleep();
cat.MakeSound();

parrot.Eat();
parrot.Sleep();
parrot.MakeSound();

dog.Eat();
dog.Sleep();
dog.MakeSound();