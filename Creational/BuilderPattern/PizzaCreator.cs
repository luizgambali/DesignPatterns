public class PizzaCreator {

    private PizzaBuilder pizzaBuilder;

    public PizzaCreator(PizzaBuilder builder) {
        pizzaBuilder = builder;
    }

    public Pizza MakePizza() {
        pizzaBuilder.Prepare();
        return pizzaBuilder.GetPizza();
    }
}