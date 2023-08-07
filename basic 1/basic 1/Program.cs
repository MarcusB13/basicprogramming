namespace basic
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add(10, 2, 2));
            Console.WriteLine(celciustofahrenheit(-20));
        }

        
        static int add (int firstNumber, int secondNumber, int lastNumber)
        {
            return (firstNumber + secondNumber) * lastNumber;
        }

        static double celciustofahrenheit (int celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32;

            if (fahrenheit < -271.15)
            {
                fahrenheit = -217.15;
            }
            return fahrenheit;
        }
    }
}