namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Data Types

            int age = 24;
            long population = 1000000L;
            float price = 10.5f;
            double salary = 5000.75;
            decimal balance = 1500.50m;
            bool isStudent = true;
            char grade = 'A';
            string name = "Sama";


            // 2. Output

            Console.WriteLine("Hello World");

            Console.Write("Hello ");
            Console.Write("Sama");

            Console.WriteLine();


            // 3. Input - ReadLine

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName);


            // 4. int.Parse

            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine(userAge);


            // 5. Convert.ToInt32

            string number = "50";
            int convertedNumber = Convert.ToInt32(number);

            Console.WriteLine(convertedNumber);


            // 6. Arithmetic Operators

            int a = 10;
            int b = 5;

            Console.WriteLine(a + b); // Addition
            Console.WriteLine(a - b); // Subtraction
            Console.WriteLine(a * b); // Multiplication
            Console.WriteLine(a / b); // Division
            Console.WriteLine(a % b); // Remainder


            // 7. Division with Double

            int num1 = 10;
            int num2 = 3;

            double result = (double)num1 / num2;

            Console.WriteLine(result);


            // 8. Even or Odd

            int evenOddNumber = 10;

            if (evenOddNumber % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


            // 9. Comparison Operators

            int x = 10;
            int y = 5;

            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);


            // 10. Boolean

            bool isGraduated = false;

            Console.WriteLine(isStudent);
            Console.WriteLine(isGraduated);


            // 11. Logical Operators

            bool first = true;
            bool second = false;

            Console.WriteLine(first && second); // AND
            Console.WriteLine(first || second); // OR
            Console.WriteLine(!first);          // NOT


            // 12. Swap Using Temporary Variable

            int swapA = 10;
            int swapB = 20;

            int temp = swapA;
            swapA = swapB;
            swapB = temp;

            Console.WriteLine(swapA);
            Console.WriteLine(swapB);


            // 13. Swap Without Temporary Variable

            int swapX = 10;
            int swapY = 20;

            swapX = swapX + swapY;
            swapY = swapX - swapY;
            swapX = swapX - swapY;

            Console.WriteLine(swapX);
            Console.WriteLine(swapY);


            // 14. Swap Using Tuple

            int tupleA = 10;
            int tupleB = 20;

            (tupleA, tupleB) = (tupleB, tupleA);

            Console.WriteLine(tupleA);
            Console.WriteLine(tupleB);


            // 15. Increment and Decrement

            int counter = 5;

            counter++;
            Console.WriteLine(counter);

            counter--;
            Console.WriteLine(counter);


            // 16. Pre-Increment and Post-Increment

            int value = 5;

            Console.WriteLine(value++);
            Console.WriteLine(++value);


            // 17. If - Else

            int studentAge = 20;

            if (studentAge >= 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Not Adult");
            }


            // 18. Positive - Negative - Zero

            int checkNumber = -5;

            if (checkNumber > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (checkNumber < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }


            // 19. Find Maximum Between Two Numbers

            int maxA = 10;
            int maxB = 20;

            if (maxA > maxB)
            {
                Console.WriteLine(maxA);
            }
            else
            {
                Console.WriteLine(maxB);
            }


            // 20. Division with Zero Check

            int divideA = 10;
            int divideB = 0;

            if (divideB != 0)
            {
                Console.WriteLine(divideA / divideB);
                Console.WriteLine(divideA % divideB);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }


            // 21. Taking Two Numbers from User

            Console.Write("Enter First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition = " + (firstNumber + secondNumber));

            Console.WriteLine("Subtraction = " + (firstNumber - secondNumber));

            Console.WriteLine("Multiplication = " + (firstNumber * secondNumber));

            if (secondNumber != 0)
            {
                Console.WriteLine("Division = " + ((double)firstNumber / secondNumber));

                Console.WriteLine("Remainder = " + (firstNumber % secondNumber));
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}
