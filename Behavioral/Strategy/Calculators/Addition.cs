namespace Strategy.Calculators
{
    public class Addition: BaseCalculator 
    {
        public override double Calculate(double value1, double value2)
        {
            return value1 + value2;
        }
    }
}