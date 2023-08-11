/*
    Abstract Factory Pattern Definition: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
    The Abstract Factory Pattern is a creational pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes. 
    
    In this example, we have a GUI Factory that can create different GUI components based upon the operating system.

    About Abstract Classes x Interfaces:
    If you need to provide a base for a hierarchy of classes or provide a common implementation, you should use abstract classes. 
    If you need to define behavior that can be implemented by multiple unrelated classes, you should use interfaces.

    Reference: https://refactoring.guru/design-patterns/abstract-factory
*/

using AbstractFactory.Factory;

Console.WriteLine("********* Creating a Windows GUI Components *********");
Test(OS.Windows);

Console.WriteLine("********* Creating a Linux GUI Components *********");
Test(OS.Linux);

Console.WriteLine("********* Creating a Mac GUI Components *********");
Test(OS.Mac);


void Test(OS os)
{
    var environment = BaseGUIFactory.GetFactory(os);

    var button = environment.CreateButton("Click me!");
    var textBox = environment.CreateTextBox("Hello World");

    //textBox.SetText("Hello World");

    button.Render();
    textBox.Render();
    button.Click();
}
