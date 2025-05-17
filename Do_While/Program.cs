using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a limit: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int counter = 0;

        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            counter++;
        }
        while (counter <= limit);

        // do-while loop:
        // The loop body executes first, and the condition is checked after.
        // This ensures that the loop runs at least once, even if the condition is false initially.
    }
}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Please enter a limit: ");
//        int limit = Convert.ToInt32(Console.ReadLine());

//        int counter = 0;

//        while (counter <= limit)
//        {
//            Console.WriteLine("Ben bir Patika'lıyım");
//            counter++;
//        }

//        // while loop:
//        // The condition is checked before the loop body runs.
//        // If the condition is false at the beginning, the loop will not execute even once.
//    }
//}









