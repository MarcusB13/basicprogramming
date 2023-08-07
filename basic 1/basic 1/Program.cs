namespace basic
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("add");
            Console.WriteLine(add(10, 2, 2));
            Console.WriteLine("celciustofahrenheit");
            Console.WriteLine(celciustofahrenheit(100));
            Console.WriteLine("ElementaryOperations");
            Console.WriteLine(ElementaryOperations(3, 8));
            Console.WriteLine("IsResultTheSame");
            Console.WriteLine(IsResultTheSame(2/1, 4/4));
            Console.WriteLine("ModuloOperations");
            Console.WriteLine(ModuloOperations(8, 5, 2));
            Console.WriteLine("CubeOf");
            Console.WriteLine(CubeOf(-5.5));
            Console.WriteLine("SwapTwoNumbers");
            Console.WriteLine(SwapTwoNumbers(5, 10));
            Console.WriteLine("AbsoluteValue");
            Console.WriteLine(AbsoluteValue(-10));
            Console.WriteLine("DivisibleBy2Or3");
            Console.WriteLine(DivisibleBy2Or3(2, 90));
            Console.WriteLine("DivisibleBy2Or3");
            Console.WriteLine(DivisibleBy2Or3(7, 13));
            Console.WriteLine("IfConsistsOfUppercaseLetters");
            Console.WriteLine(IfConsistsOfUppercaseLetters("MARCUS"));
            Console.WriteLine("IsGratherThanThirdOne");
            Console.WriteLine(IsGratherThanThirdOne(new double[] {1,2,3}));
            Console.WriteLine("IsNumberEven");
            Console.WriteLine(IsNumberEven(3));
            Console.WriteLine("IfSortedAscending");
            Console.WriteLine(IfSortedAscending(new double[] {2,4,3,7}));

            Console.WriteLine("PositiveNegativeOrZero");
            Console.WriteLine(PositiveNegativeOrZero(10));
            Console.WriteLine("PositiveNegativeOrZero");
            Console.WriteLine(PositiveNegativeOrZero(0));
            Console.WriteLine("PositiveNegativeOrZero");
            Console.WriteLine(PositiveNegativeOrZero(-10));

            Console.WriteLine("isLeapYear");
            Console.WriteLine(isLeapYear(2016));
            Console.WriteLine("isLeapYear");
            Console.WriteLine(isLeapYear(2018));

            WriteNumbersTable(1);



        }

        // Opgave 1
        static int add (int firstNumber, int secondNumber, int lastNumber)
        {
            return (firstNumber + secondNumber) * lastNumber;
        }

        static string celciustofahrenheit (int celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32;

            if (fahrenheit < -271.15)
            {
                return "Temperature below absolute zero!";
            }

            return $"T = {fahrenheit}F";
        }

        static string ElementaryOperations (double firstNumber, double secondNumber)
        {
            double addition = firstNumber + secondNumber;
            double substraction = firstNumber - secondNumber;
            double multiplication = firstNumber * secondNumber;
            double devision = 0;
            if (firstNumber != 0 && secondNumber != 0)
            {
               devision = firstNumber / secondNumber;
            }

            return $"{addition}, {substraction}, {multiplication}, {devision}";
        }

        static bool IsResultTheSame(double firstOperations, double secondOperations)
        {
            bool isTheSame = firstOperations == secondOperations;
            return isTheSame;
        }

        static double ModuloOperations (double firstNumber, double secondNumber, double ThirdNumber)
        {
            double modulodividedby = (firstNumber % secondNumber) % ThirdNumber;
            return modulodividedby;
        }

        static double CubeOf(double Number)
        {
            double cubeOf = Math.Pow(Number, 3);
            return cubeOf;
        }

        static string SwapTwoNumbers(double a, double b)
        {
            return $"Before: a = {a}, b = {b}; After: a = {b}, b = {a}";
        }


        // Opgave 2
        static double AbsoluteValue(double value)
        {
            return value * -1;
        }

        static double DivisibleBy2Or3(double firstNumber, double secondNumber)
        {
            if (firstNumber % 2 == 0 && firstNumber % 3 == 0 && secondNumber % 2 == 0 && secondNumber % 3 == 0)
            {
                return firstNumber * secondNumber;
            }

            return firstNumber + secondNumber;
        }

        static bool IfConsistsOfUppercaseLetters(string Input)
        {
            string uppercaseInput = Input.ToUpper();
            return uppercaseInput == Input;
        }

        static bool IsGratherThanThirdOne(double[] Input)
        {
            double multiplication = Input[0] * Input[1];
            double sum = Input[0] + Input[1];
            return sum > Input[2] || multiplication > Input[2];
        }

        static bool IsNumberEven(double Input)
        {
            return Input % 2 == 0;
        }

        static bool IfSortedAscending(double[] Inputs)
        {
            for(int i = 0; i<Inputs.Length; i++)
            {
                if (i == 0) { continue; } // First Value
                if (Inputs[i - 1] <= Inputs[i]) // Forrige mindre end nuværende
                {
                    continue;
                }
                return false;
            }
            return true;
        }

        static string PositiveNegativeOrZero(double Input)
        {
            string StringToReturn = "Zero";
            if (Input > 0) { StringToReturn = "positive"; }
            if (Input < 0) { StringToReturn = "Negetive"; }


            return StringToReturn;
        }

        static bool isLeapYear(int year)
        {
            return year % 4 == 0;
        }

        // Opgave 3

        static void WriteNumbersTable(int tabel)
        {
            string line = "";
            for (int i = 1; i<11; i++)
            {
                int number = i * tabel;
                string TabelNumber = number.ToString() + " ";

                if (number < 10) { TabelNumber += " "; }
                line += TabelNumber;
            }
            Console.WriteLine(line);
            if(tabel != 10)
            {
                WriteNumbersTable(tabel + 1);
            }
        }
    }
}