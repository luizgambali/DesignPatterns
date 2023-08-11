public abstract class PizzaBuilder
{
    protected Pizza pizza;

    public void CreatePizza(){
        pizza = new Pizza();
    }

    public Pizza GetPizza(){
        return pizza;
    }

    public abstract void Prepare();
}