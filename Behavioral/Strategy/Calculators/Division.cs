namespace Strategy.Calculators
{
    public class Division: BaseCalculator 
    {
        public override double Calculate(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new DivideByZeroException();
            }
            
            return value1 / value2;
        }
    }
}