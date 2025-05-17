using System;
// Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları for kullanarak yapınız.

//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
class Program
{
    static void Main()
    {
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }

        for (int number = 1; number <= 20;number++)
        {
            Console.WriteLine(number);
        }
        for(int number = 1; number <= 20; number++)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }
        int total = 0;
        for (int number = 50; number <= 150; number++)
        {
            total += number;
        }
        Console.WriteLine(total);
        {
            int oddSum = 0;
            int evenSum = 0;
            for(int number = 1; number <= 120; number++)
            {
                if(number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }

            }
        }








    }







}
