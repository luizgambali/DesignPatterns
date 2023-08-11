public class Pepperoni: PizzaBuilder
{
    public Pepperoni(){
        CreatePizza();
    }
    
    public override void Prepare()
    {
        pizza.Crust = Crust.Thin;
        pizza.Sauce = Sauce.Tomato;
        pizza.Toppings.Add(Topping.CHEESE);
        pizza.Toppings.Add(Topping.PEPPERONI);
    }
}