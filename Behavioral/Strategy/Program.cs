/*
    Strategy pattern allows you to switch the algorithm or strategy based upon the situation.
    In this example, we have a calculator that can perform different operations based upon the strategy.

    The calculator has a property called calculator of type BaseCalculator. This property is used to set the strategy.

    About Abstract Classes x Interfaces:
    If you need to provide a base for a hierarchy of classes or provide a common implementation, you should use abstract classes. 
    If you need to define behavior that can be implemented by multiple unrelated classes, you should use interfaces.
    
    Reference: adapted from https://www.macoratti.net/19/01/c_strateg1.htm
*/
using Strategy.Calculators;

var value1 = 10;
var value2 = 5;

Calculator calculator = new Calculator();

Console.Write("Addition: ");
calculator.calculator = new Addition();
calculator.Calculate(value1, value2);

Console.Write("Subtraction: ");
calculator.calculator = new Subtraction();
calculator.Calculate(value1, value2);

Console.Write("Multiplication: ");
calculator.calculator = new Multiplication();
calculator.Calculate(value1, value2);

Console.Write("Division: ");
calculator.calculator = new Division();
calculator.Calculate(value1, value2);


