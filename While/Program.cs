using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Step 1 ---");
        // 1. Print a motivational sentence 10 times using while
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            counter++;
        }

        Console.WriteLine("\n--- Step 2 ---");
        // 2. Print numbers from 1 to 20 using while
        int number = 1;
        while (number <= 20)
        {
            Console.WriteLine(number);
            number++;
        }

        Console.WriteLine("\n--- Step 3 ---");
        // 3. Print even numbers from 1 to 20 using while
        number = 1;
        while (number <= 20)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
            number++;
        }

        Console.WriteLine("\n--- Step 4 ---");
        // 4. Print the sum of numbers from 50 to 150 using while
        number = 50;
        int total = 0;
        while (number <= 150)
        {
            total += number;
            number++;
        }
        Console.WriteLine("Sum of numbers between 50 and 150: " + total);

        Console.WriteLine("\n--- Step 5 ---");
        // 5. Print the sum of odd and even numbers from 1 to 120 using while
        number = 1;
        int oddSum = 0;
        int evenSum = 0;

        while (number <= 120)
        {
            if (number % 2 == 0)
            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
            number++;
        }

        Console.WriteLine("Sum of odd numbers between 1 and 120: " + oddSum);
        Console.WriteLine("Sum of even numbers between 1 and 120: " + evenSum);
    }
}





