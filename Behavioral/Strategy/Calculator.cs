public class Calculator {
    public BaseCalculator calculator { get; set; }

    public void Calculate(double value1, double value2) {
        Console.WriteLine(calculator.Calculate(value1, value2));
    }
}