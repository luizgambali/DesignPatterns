public class Bacon: PizzaBuilder
{
    public Bacon(){
        CreatePizza();
    }
    
    public override void Prepare()
    {
        CreatePizza();
        pizza.Crust = Crust.Thin;
        pizza.Sauce = Sauce.Tomato;
        pizza.Toppings.Add(Topping.CHEESE);
        pizza.Toppings.Add(Topping.BACON);
    }
}