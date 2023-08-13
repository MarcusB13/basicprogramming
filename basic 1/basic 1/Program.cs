using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using basic_1;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static basic_1.Dice; // Import Dice Class from Dice.cs
using static basic_1.GameRequests; // Import Dice Class from Dice.cs

namespace basic
{

    public class Program
    {
        public static void Main(string[] args)
        {
            GameRequests game = new GameRequests("http://127.0.0.1");
            game.StartGame(4);
            string[] data = game.StartGame(4);
            for (int i = 0; i<data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            return;
            // Add
            Console.WriteLine("add");
            Console.WriteLine(add(10, 2, 2));

            // AddTwoNumbers
            Console.WriteLine("AddTwoNumbers");
            try{ Console.WriteLine(AddTwoNumbers(200000, 150000)); } // Try to add two numbers
            catch (Exception ex) { Console.WriteLine(ex); } // If numbers does not fit Int32, then an error is thrown

            
            // Calcius to Fahrenheit
            Console.WriteLine("celciustofahrenheit");
            Console.WriteLine(celciustofahrenheit(100));

            // Operataions
            Console.WriteLine("ElementaryOperations");
            Console.WriteLine(ElementaryOperations(3, 8));

            // Is result the same
            Console.WriteLine("IsResultTheSame");
            Console.WriteLine(IsResultTheSame((double) 2 /1, (double) 4 /4));
            Console.WriteLine("IsResultTheSame");
            Console.WriteLine(IsResultTheSame((double) 1/6, (double) 2 /6));

            // Modulo Operations
            Console.WriteLine("ModuloOperations");
            Console.WriteLine(ModuloOperations(8, 5, 2));

            // Cube of
            Console.WriteLine("CubeOf");
            Console.WriteLine(CubeOf(-5.5));

            // Swab inputs
            Console.WriteLine("SwapTwoNumbers");
            Console.WriteLine(SwapTwoNumbers(5, 10));

            // Abseloute value
            Console.WriteLine("AbsoluteValue");
            Console.WriteLine(AbsoluteValue(-10));

            // Is divisible by
            Console.WriteLine("DivisibleBy2Or3");
            Console.WriteLine(DivisibleBy2Or3(2, 90));
            Console.WriteLine("DivisibleBy2Or3");
            Console.WriteLine(DivisibleBy2Or3(7, 13));

            // Only uppercase letters
            Console.WriteLine("IfConsistsOfUppercaseLetters");
            Console.WriteLine(IfConsistsOfUppercaseLetters("MARCUS"));

            // Is greather than third one
            Console.WriteLine("IsGratherThanThirdOne");
            Console.WriteLine(IsGratherThanThirdOne(new double[] {1,2,3}));

            // Is even number
            Console.WriteLine("IsNumberEven");
            Console.WriteLine(IsNumberEven(3));

            // Is sorted Ascending
            Console.WriteLine("IfSortedAscending");
            Console.WriteLine(IfSortedAscending(new double[] {2,4,3,7}));

            // Positive Negetive or Zero
            Console.WriteLine("PositiveNegativeOrZero");
            Console.WriteLine(PositiveNegativeOrZero(10));
            Console.WriteLine("PositiveNegativeOrZero");
            Console.WriteLine(PositiveNegativeOrZero(0));
            Console.WriteLine("PositiveNegativeOrZero");
            Console.WriteLine(PositiveNegativeOrZero(-10));

            // Is leap year
            Console.WriteLine("isLeapYear");
            Console.WriteLine(isLeapYear(2016));
            Console.WriteLine("isLeapYear");
            Console.WriteLine(isLeapYear(2018));

            // Numbers table
            WriteNumbersTable(1);

            // Find biggest number
            int[] ar = { 1, 5, 7, 22 }; 
            Console.WriteLine("TheBiggestNumber");
            Console.WriteLine(ar.Max());

            // How many times is two 7's next to eachother
            Console.WriteLine("Two7sNextToEachOther");
            Console.WriteLine(Two7sNextToEachOther(new int[] { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 }));
            Console.WriteLine("Two7sNextToEachOther");
            Console.WriteLine(Two7sNextToEachOther(new int[] { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 }));

            // How many times does the number increase by 1 three times in a row
            Console.WriteLine("ThreeIncreasingAdjacent");
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));
            Console.WriteLine("ThreeIncreasingAdjacent");
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 7, 3, 5, 8, 9, 3, 1, 4 }));

            // Find all prime numbers from 2 -> n
            Console.WriteLine("SieveOfEratosthenes");
            SieveOfEratosthenes(30).ForEach(x => Console.WriteLine(x.ToString() + " "));

            // Extract string between ## and ##
            Console.WriteLine("ExtractString");
            Console.WriteLine(ExtractString("##dsa##"));

            // Get all letters in the alfabet between the two letters
            Console.WriteLine("FullSequenceOfLetters");
            Console.WriteLine(FullSequenceOfLetters("ds"));
            Console.WriteLine("FullSequenceOfLetters");
            Console.WriteLine(FullSequenceOfLetters("or"));

            // Get the sum and average from n -> n
            Console.WriteLine("SumAndAverage");
            Console.WriteLine(SumAndAverage(11, 66));

            // Draw a triangle of *'s
            DrawTriangle(10);

            // To the power of
            Console.WriteLine("ToThePowerOf");
            Console.WriteLine(ToThePowerOf(-2, 3));
            Console.WriteLine("ToThePowerOf");
            Console.WriteLine(ToThePowerOf(5, 5));

            // Add a separator
            Console.WriteLine("AddSeparator");
            Console.WriteLine(AddSeparator("ABCD", "^"));
            Console.WriteLine("AddSeparator");
            Console.WriteLine(AddSeparator("chocolate", "-"));

            // Is the string the same as backwards
            Console.WriteLine("IsPalindrome");
            Console.WriteLine(IsPalindrome("eye"));
            Console.WriteLine("IsPalindrome");
            Console.WriteLine(IsPalindrome("home"));

            // What is the length of the strength
            Console.WriteLine("LengthOfAString");
            Console.WriteLine(LengthOfAString("computer"));

            // Reverse a string
            Console.WriteLine("StringInReverseOrder");
            Console.WriteLine(StringInReverseOrder("qwerty"));

            // How many words in sentence
            Console.WriteLine("NumberOfWords");
            Console.WriteLine(NumberOfWords("This is sample sentence"));

            // Revert words
            Console.WriteLine("RevertWordsOrder");
            Console.WriteLine(RevertWordsOrder("Doe John."));

            // How many times is the substring in the sentence
            Console.WriteLine("HowManyOccurrences");
            Console.WriteLine(HowManyOccurrences("do it now", "do"));

            // Sort the chars in descending order
            Console.WriteLine("SortCharactersDescending");
            Console.WriteLine(SortCharactersDescending("onomatopoeia"));

            // Compress a string
            Console.WriteLine("CompressString");
            Console.WriteLine(CompressString("kkkktttrrrrrrrrrr"));
            Console.WriteLine("CompressString");
            Console.WriteLine(CompressString("p555ppp7www"));

            // Find the number that is only one of
            Console.WriteLine("FindTheOddOne");
            int[] array = { 1, 2, 3, 4, 2, 4, 3, 1, 5, 6, 6};
            Console.WriteLine(FindTheOddOne(array));

            // Throw x number o dices, and see how many throws till you throw straight 6's
            Console.WriteLine("HowManyThrowsToGetSix");
            Console.WriteLine("How many cubes would you like to use?:");
            string numberOfCubesString = Console.ReadLine();
            int numberOfCubes = Int32.Parse(numberOfCubesString);
            Console.WriteLine(HowManyThrowsToGetSix(numberOfCubes));
            
            // Calculator Game
            CalculatorGame(2, 0, 0);
        }

        // Opgave 1
        public static int add (int firstNumber, int secondNumber, int lastNumber)
        {
            return (firstNumber + secondNumber) * lastNumber;
        }

        public static int AddTwoNumbers(int a, int b)
        {
            bool error = false;
            string errorMessage = "";

            int addition = a + b;
            bool aIsPositive = a > 0;
            bool bIsPositive = b > 0;


            if (a == int.MaxValue || b == int.MaxValue)
            {
                error = true;
            }
            if (bIsPositive && aIsPositive)
            {
                if (addition < 0)
                {
                    error = true;
                    errorMessage = "Value is higher than int max value";
                }
            } else
            {
                if (addition > 0)
                {
                    errorMessage = "Value is lower than int max value";
                    error = true;
                }
            }


            if (error)
            {
                throw new Exception(errorMessage);
            }
            return addition;
        }

        public static string celciustofahrenheit (int celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32;

            // If the number is below Absolute 0 return this string
            if (fahrenheit < -271.15) { return "Temperature below absolute zero!"; }

            return $"T = {fahrenheit}F";
        }

        public static string ElementaryOperations (double firstNumber, double secondNumber)
        {
            double addition = firstNumber + secondNumber;
            double substraction = firstNumber - secondNumber;
            double multiplication = firstNumber * secondNumber;
            double devision = 0;

            if (firstNumber != 0 && secondNumber != 0) { devision = firstNumber / secondNumber; }
            return $"{addition}, {substraction}, {multiplication}, {devision}";
        }

        public static bool IsResultTheSame(double firstOperations, double secondOperations)
        {
            bool isTheSame = firstOperations == secondOperations;
            Console.WriteLine($"Is result the same = {isTheSame}");
            Console.WriteLine($"First = {firstOperations}");
            Console.WriteLine($"Second = {secondOperations}");
            return isTheSame;
        }

        public static double ModuloOperations (double firstNumber, double secondNumber, double ThirdNumber)
        {
            double modulodividedby = (firstNumber % secondNumber) % ThirdNumber;
            return modulodividedby;
        }

        public static double CubeOf(double Number)
        {
            return Math.Pow(Number, 3);
        }

        public static string SwapTwoNumbers(double a, double b)
        {
            string before = $"Before: a = {a}, b = {b}";
            string after = $" After: a = {b}, b = {a}";

            return $"{before}; {after}";
        }


        // Opgave 2
        public static double AbsoluteValue(double value)
        {
            return value * -1;
        }

        public static double DivisibleBy2Or3(double firstNumber, double secondNumber)
        {
            if (firstNumber % 2 == 0 && firstNumber % 3 == 0
                && secondNumber % 2 == 0 && secondNumber % 3 == 0)
            {
                return firstNumber * secondNumber;
            }

            return firstNumber + secondNumber;
        }

        public static bool IfConsistsOfUppercaseLetters(string Input)
        {
            string uppercaseInput = Input.ToUpper();
            return uppercaseInput == Input;
        }

        public static bool IsGratherThanThirdOne(double[] Input)
        {
            double multiplication = Input[0] * Input[1];
            double sum = Input[0] + Input[1];
            return sum > Input[2] || multiplication > Input[2];
        }

        public static bool IsNumberEven(double Input)
        {
            return Input % 2 == 0;
        }

        public static bool IfSortedAscending(double[] Inputs)
        {
            for(int i = 0; i<Inputs.Length; i++)
            {
                // First Value
                if (i == 0) { continue; }

                // Last value smaller than this value
                if (Inputs[i - 1] <= Inputs[i])
                {
                    continue;
                }
                return false;
            }
            return true;
        }

        public static string PositiveNegativeOrZero(double Input)
        {
            string StringToReturn = "Zero";
            if (Input > 0) { StringToReturn = "positive"; }
            if (Input < 0) { StringToReturn = "Negetive"; }


            return StringToReturn;
        }

        public static bool isLeapYear(int year)
        {
            return year % 4 == 0;
        }

        // Opgave 3

        public static void WriteNumbersTable(int tabel)
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

        public static int Two7sNextToEachOther(int[] Inputs)
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

        public static bool ThreeIncreasingAdjacent(int[] Inputs)
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

        public static bool IsPrimeNumber(int Number)
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

        public static List<int> SieveOfEratosthenes(int n)
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

        public static string ExtractString(string Input)
        {
            string[] SplittetInput = Input.Split("##");
            if (SplittetInput.Length < 3) { return ""; }
            return SplittetInput[1];
        }

        public static string FullSequenceOfLetters(string Input)
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

        public static string SumAndAverage(int Input1, int Input2)
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

        public static void DrawTriangle(int Lines)
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

        public static double ToThePowerOf(double Value, double Power)
        {
            double ThePowerOf = Math.Pow(Value, Power);
            return ThePowerOf;
        }



        // What difficulty do we use
        public static string ChooseDifficulty()
        {
            string difficulty = "";

            Console.WriteLine("Please choose a difficulty (1-5):");
            Console.WriteLine("1 (1 - 10)");
            Console.WriteLine("2 (1 - 100)");
            Console.WriteLine("3 (1 - 1000)");
            Console.WriteLine("4 (1 - 9999)");
            Console.WriteLine("5 ( (-)100 - 100 )");
            Console.WriteLine("6 (3 the tabel)");
            Console.WriteLine("7 (5 the tabel)");

            difficulty = Console.ReadLine();
            while (difficulty != "1" && difficulty != "2" && difficulty != "3"
                && difficulty != "4" && difficulty != "5" && difficulty != "6"
                && difficulty != "7")
            {
                Console.WriteLine($"{difficulty} is not a vaild difficulty!");
                difficulty = Console.ReadLine();
            }
            return difficulty;
        }

        // Asking the questions. And waiting for the answer
        public static bool CalculatorStep(int startNumber, int endNumber, int n)
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
                Console.WriteLine($"({n}) Calculate (Whole numbers only): {firstNumber} {opperation} {secondNumber}");
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

        // The tabel Learner
        public static bool TheTabelStep(int Tabel)
        {
            Console.WriteLine("Start the tabel");
            for (int i = 1; i<=10; i++)
            {
                string number = (i * Tabel).ToString();
                string answer = Console.ReadLine();

                int Tries = 0;
                while (answer != number)
                {
                    if (Tries >= 3) { return false;  }
                    Tries += 1;
                    Console.WriteLine($"Wrong Try Again. {Tries}");
                    answer = Console.ReadLine();
                }
                continue;
            }
            return true;
        }

        // Main Function to start game
        public static void CalculatorGame(int lengthOfGame, int startPoints, int startCorrect)
        {
            string difficulty = ChooseDifficulty();
            int points = startPoints;
            int numberOfCorrects = startCorrect;
            bool Correct = false;

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
                else if (difficulty == "6")
                {
                    Correct = TheTabelStep(3);
                    if (Correct)
                    {
                        points += 3;
                        numberOfCorrects += 1;
                        Console.WriteLine("Congratulations. You did it.");
                        break;
                    }
                    Console.WriteLine("Too many Tries!");
                    break;

                }
                else if (difficulty == "7")
                {
                    Correct = TheTabelStep(5);
                    if (Correct)
                    {
                        points += 5;
                        numberOfCorrects += 1;
                        Console.WriteLine("Congratulations. You did it.");
                        break;
                    }
                    Console.WriteLine("Too many Tries!");
                    break;
                }


                Correct = CalculatorStep(lowestNumber, highestNumber, n);
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
            Console.WriteLine("Would you like to continue playing? (y/n)");
            string playAgain = Console.ReadLine();

            if (playAgain.ToLower() == "y" || playAgain.ToLower() == "yes")
            {
                CalculatorGame(2, points, numberOfCorrects);
            }
        }


        // Opgave 3
        public static string AddSeparator(string Input, string seperator)
        {
            char[] Inputs = Input.ToCharArray();
            return string.Join(seperator, Inputs);
        }

        public static bool IsPalindrome(string Input)
        {
            return string.Join("", Input.ToCharArray().Reverse()) == Input;
        }

        public static int LengthOfAString(string Input)
        {
            int length = 0;
            foreach(char lettet in Input)
            {
                length++;
            }
            return length;
        }

        public static string StringInReverseOrder(string Input)
        {
            return string.Join("", Input.ToCharArray().Reverse());
        }

        public static int NumberOfWords(string Input)
        {
            string[] words = Input.Split(" ");
            return words.Length;
        }

        public static string RevertWordsOrder(string Input)
        {
            string[] words = Input.Split(" ");
            return string.Join(" ", words.Reverse());
        }

        public static int HowManyOccurrences(string Input, string substring)
        {
            int occurrences = Input.Split(substring).Length - 1;
            return occurrences;
        }

        public static string SortCharactersDescending(string Input)
        {
            char[] characters = Input.ToCharArray();
            Array.Sort(characters);
            return string.Join("", characters.Reverse());
        }

        public static string CompressString(string input)
        {
            int currentCount = 0;
            char currentChar = ' ';
            string compressedInput = "";

            for (int i = 0; i<input.Length; i++)
            {
                char letter = input[i];
                if (currentChar == ' ') { currentChar = letter; }
                if(currentChar == letter)
                {
                    currentCount++;
                    if (i != input.Length - 1) { continue; }
                }
                compressedInput += $"{currentChar}{currentCount}";
                currentChar = letter;
                currentCount = 1;
            }
            return compressedInput;
        }

        public static int? FindTheOddOne(int[] Input)
        {
            int? oddOne = null;
            int? previous = null;
            Array.Sort(Input);

            for (int i = 0; i < Input.Length; i++)
            {
                int current = Input[i];
                int next = Input[i + 1];
                if (current == next || current == previous)
                {
                    previous = current;
                    continue;
                }

                oddOne = current;
                break;
            }
            return oddOne;
        }

        public static bool CheckAllDices(List<Dice> cubes)
        {
            bool allCubesIsSix = true;
            foreach (Dice cube in cubes)
            {
                if (cube.Current != 6)
                {
                    allCubesIsSix = false;
                    break;
                }
            }
            return allCubesIsSix;
        }

        public static int HowManyThrowsToGetSix(int numberOfCubes)
        {
            List<Dice> cubes = new List<Dice> { };

            for (int i = 0; i < numberOfCubes; i++)
            {
                cubes.Add(new Dice(6));
            }

            int rolls = 0;
            while (CheckAllDices(cubes) != true)
            {
                rolls++;
                for (int i = 0; i < numberOfCubes; i++)
                {
                    cubes[i].Roll();
                    Console.Write($"{cubes[i].Current} ");
                }
                Console.WriteLine();
            }
            return rolls;
        }
    }
}
