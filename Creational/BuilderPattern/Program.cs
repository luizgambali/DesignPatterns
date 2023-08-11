/*
    The Builder pattern separates the construction of a complex object from its representation so that the same construction process can create different representations.
    
    In this example, we have a PizzaCreator class that receives a PizzaBuilder in its constructor. The PizzaCreator class has a method called MakePizza that returns a Pizza object. 
    The Pizza class has a method called ShowInfo that shows the pizza information.

    Reference: adapted from https://macoratti.net/21/08/c_builder1.htm
*/

var pizzaCreator = new PizzaCreator(new Pepperoni());
var pizza = pizzaCreator.MakePizza();
pizza.ShowInfo();

var pizzaCreator2 = new PizzaCreator(new Bacon());
var pizza2 = pizzaCreator2.MakePizza();
pizza2.ShowInfo();

