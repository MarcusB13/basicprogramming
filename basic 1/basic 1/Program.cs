﻿using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            int[] ar = { 1, 5, 7, 22 }; 
            Console.WriteLine("TheBiggestNumber");
            Console.WriteLine(ar.Max());

            Console.WriteLine("Two7sNextToEachOther");
            Console.WriteLine(Two7sNextToEachOther(new int[] { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 }));
            Console.WriteLine("Two7sNextToEachOther");
            Console.WriteLine(Two7sNextToEachOther(new int[] { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 }));

            Console.WriteLine("ThreeIncreasingAdjacent");
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));
            Console.WriteLine("ThreeIncreasingAdjacent");
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 7, 3, 5, 8, 9, 3, 1, 4 }));

            Console.WriteLine("SieveOfEratosthenes");
            SieveOfEratosthenes(30).ForEach(x => Console.WriteLine(x.ToString() + " "));

            Console.WriteLine("ExtractString");
            Console.WriteLine(ExtractString("##dsa##"));

            Console.WriteLine("FullSequenceOfLetters");
            Console.WriteLine(FullSequenceOfLetters("ds"));
            Console.WriteLine("FullSequenceOfLetters");
            Console.WriteLine(FullSequenceOfLetters("or"));

            Console.WriteLine("SumAndAverage");
            Console.WriteLine(SumAndAverage(11, 66));

            DrawTriangle(10);

            Console.WriteLine("ToThePowerOf");
            Console.WriteLine(ToThePowerOf(-2, 3));
            Console.WriteLine("ToThePowerOf");
            Console.WriteLine(ToThePowerOf(5, 5));

            CalculatorGame(2);
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

        static int Two7sNextToEachOther(int[] Inputs)
        {
            int SevensNextToEachOther = 0;

            for (int i = 0; i<Inputs.Length; i++)
            {
                if (Inputs[i] == 7 && Inputs[i-1] == 7)
                {
                    SevensNextToEachOther += 1;
                }
            }
            return SevensNextToEachOther;
        }

        static bool ThreeIncreasingAdjacent(int[] Inputs)
        {
            for(int i = 0; i<Inputs.Length; i++)
            {
                if (Inputs.Length < i + 3) { break; }
                int firstInput = Inputs[i];
                int secondInput = Inputs[i + 1];
                int thirdInput = Inputs[i + 2];

                if (firstInput + 1 != secondInput){ continue; }

                if (secondInput + 1 != thirdInput) { continue; }
                return true;
            }
            return false;
        }

        static bool IsPrimeNumber(int Number)
        {
            for (int i = 2; i < 10; i++)
            {
                if (i == Number) { continue; }
                if (Number % i == 0 )
                {
                    return false;
                }
            }
            return true;
        }

        static List<int> SieveOfEratosthenes(int n)
        {
            List<int> PrimeNumbers = new List<int> { };
            for (int i = 2; i<n; i++)
            {
                if (IsPrimeNumber(i))
                {
                    PrimeNumbers.Add(i);
                }
            }
            return PrimeNumbers;
        }

        static string ExtractString(string Input)
        {
            string[] SplittetInput = Input.Split("##");
            if (SplittetInput.Length < 3) { return ""; }
            return SplittetInput[1];
        }

        static string FullSequenceOfLetters(string Input)
        {
            char letterA = Input.ToCharArray()[0];
            char letterB = Input.ToCharArray()[1];

            string letters = "";
            for (char letter = letterA; letter <= letterB; letter++)
            {
                letters += letter;
            }

            return letters;
        }

        static string SumAndAverage(int Input1, int Input2)
        {
            double runs = Input2 - Input1 + 1;
            double sum = 0;
            for (int i = Input1; i <= Input2; i++)
            {
                sum += i;
            }
            double average = sum / runs;
            return $"Sum: {sum}, Average: {average}";
        }

        static void DrawTriangle(int Lines)
        {
            int numberOfLines = Lines;
            int maxLengt = numberOfLines * 2 - 1;
            for (int i = 1; i < numberOfLines + 1; i++)
            {
                int numberOfStars = i * 2 - 1;
                int numberOfSpacesBefore = (maxLengt - numberOfStars) / 2;
                string line = "";
                for (int n = 1; n < numberOfStars + numberOfSpacesBefore + 1; n++)
                {
                    if (n > numberOfSpacesBefore)
                    {
                        line += "*";
                    }
                    line += " ";
                }
                Console.WriteLine(line);
            }
        }

        static double ToThePowerOf(double Value, double Power)
        {
            double ThePowerOf = Math.Pow(Value, Power);
            return ThePowerOf;
        }

        // What difficulty do we use
        static string ChooseDifficulty()
        {
            string difficulty = "";

            Console.WriteLine("Please choose a difficulty (1-5):");
            difficulty = Console.ReadLine();
            while (difficulty != "1" && difficulty != "2" && difficulty != "3" && difficulty != "4" && difficulty != "5")
            {
                Console.WriteLine($"{difficulty} is not a vaild difficulty!");
                difficulty = Console.ReadLine();
            }
            return difficulty;
        }

        // Asking the questions. And waiting for the answer
        static bool CalculatorStep(int startNumber, int endNumber, int n)
        {
            bool Correct = false;
            Random rnd = new Random();
            List<string> opperations = new List<string> { "+", "*", "-", "/" };

            int firstNumber = rnd.Next(startNumber, endNumber + 1);
            int secondNumber = rnd.Next(startNumber, endNumber + 1);

            while (firstNumber < secondNumber)
            {
                firstNumber = rnd.Next(startNumber, endNumber + 1);
                secondNumber = rnd.Next(startNumber, endNumber + 1);
            }

            string opperation = opperations[rnd.Next(0, 4)];
            double correctAnswer = 0;

            switch (opperation)
            {
                case "*":
                    correctAnswer = firstNumber * secondNumber;
                    break;

                case "/":
                    correctAnswer = firstNumber / secondNumber;
                    break;

                case "+":
                    correctAnswer = firstNumber + secondNumber;
                    break;

                case "-":
                    correctAnswer = firstNumber - secondNumber;
                    break;
            }

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"({n}) Calculate: {firstNumber} {opperation} {secondNumber}");
                string answer = Console.ReadLine();
                if (answer == correctAnswer.ToString())
                {
                    Correct = true;
                    break;
                }
                Console.WriteLine($"Wrong!");
            }
            if (!Correct)
            {
                Console.WriteLine($"Correct Answer = {correctAnswer}");
            }
            return Correct;
        }

        // Main Function to start game
        static void CalculatorGame(int lengthOfGame)
        {
            string difficulty = ChooseDifficulty();
            int points = 0;
            int numberOfCorrects = 0;

            for (int n = 1; n <= lengthOfGame; n++)
            {
                int lowestNumber = 1;
                int highestNumber = 10;

                if (difficulty == "2")
                {
                    highestNumber = 100;
                }
                else if (difficulty == "3")
                {
                    highestNumber = 1000;
                }
                else if (difficulty == "3")
                {
                    highestNumber = 1000;
                }
                else if (difficulty == "4")
                {
                    highestNumber = 9999;
                }
                else if (difficulty == "5")
                {
                    lowestNumber = -100;
                    highestNumber = 100;
                }


                bool Correct = CalculatorStep(lowestNumber, highestNumber, n);
                if (!Correct)
                {
                    Console.WriteLine("Too many Tries!");
                    continue;
                }
                points += Int32.Parse(difficulty);
                numberOfCorrects += 1;
                Console.WriteLine("Correct!");

            }

            Console.WriteLine($"You got {points} point!\nAnd answered {numberOfCorrects} Correct");
            Console.WriteLine("Would you like to play again? (y/n)");
            string playAgain = Console.ReadLine();

            if (playAgain.ToLower() == "y" || playAgain.ToLower() == "yes")
            {
                CalculatorGame(2);
            }
        }
    }
}
