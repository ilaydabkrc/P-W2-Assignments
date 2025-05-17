using System;
class Program
{
    static void Main(string[] args)
    {
        // 1. Void method that doesn't return a value
        PrintSongLyrics();

        // 2. Method that returns an integer
        int remainder = GetRandomNumberRemainder();
        Console.WriteLine("2'ye bölümünden kalan: " + remainder);

        // 3. Method with parameters that returns a value
        int product = Multiply(6, 4);
        Console.WriteLine("2 sayının çarpımı: " + product);

        // 4. Method with parameters that doesn't return a value
        GreetUser("İlayda", "Taşçı");
    }

    static void PrintSongLyrics()
    {
        Console.WriteLine("Sevgi anlaşmak değildir nedensiz de sevilir.");
    }
    static int GetRandomNumberRemainder()
    {
        Random random = new Random();   
        int number =  random.Next(0,100);
        return number % 2;
    }
    static int Multiply(int number1 , int number2)
    {
        return number1 * number2;
    }
    static void GreetUser (string firsName , string lastName)
    {
        Console.WriteLine($"Hoşgeldiniz {firsName} {lastName}");
    }





}