public class Pizza 
{
    public Crust Crust { get; set; }
    public Sauce Sauce { get; set; }
    public List<Topping> Toppings { get; set; } = new List<Topping>();

    public void ShowInfo()
    {
        Console.WriteLine("Crust: {0}", Crust);
        Console.WriteLine("Sauce: {0}", Sauce);
        Console.WriteLine("Toppings:");
        foreach (var topping in Toppings)
        {
            Console.WriteLine("\t{0}", topping);
        }
    }
}
