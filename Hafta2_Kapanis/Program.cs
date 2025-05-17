using System;
class Program
{
    static void Main(string[] args)
    {
        //1
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın ? ");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın ? ");

        //2
        String name = "İlayda";
        int number = 7;

        Console.WriteLine("İsim: " + name);
        Console.WriteLine("Seçtiğim rakam: " + number);


        //3 
        Random rnd = new Random();
        int randomNumber = rnd.Next(number);

        Console.WriteLine("Rastgele sayı: " + randomNumber);

        //4 
        int rndMod = rnd.Next(1, 101) % 3;
        Console.WriteLine("3'e bölümünden kalan: " + rndMod);

        //5
        Console.WriteLine("Yaşınızı giriniz: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-"); 
        }

        //6
        for (int i = 1 ; i <= 10 ; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
        }

        //7
        Console.WriteLine("1. ismi giriniz: ");
        string name1 = Console.ReadLine();
        Console.WriteLine("2. ismi giriniz: ");
        string name2 = Console.ReadLine();
        string temp = name1;
        name1 = name2;
        name2 = temp;
        Console.WriteLine("Yeni 1. isim: " + name1);
        Console.WriteLine("Yeni 2. isim: " + name2);

        //8
        BendegerDondurmem();

        //9
        Console.WriteLine("Toplam: " + Topla(7,11));

        //10
        Console.WriteLine("True ya da False giriniz. ");
        bool tf = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine(DurumMesaji(tf));

        //11
        Console.Write("1. kişinin yaşını giriniz: ");
        int yas1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. kişinin yaşını giriniz: ");
        int yas2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("3. kişinin yaşını giriniz: ");
        int yas3 = Convert.ToInt32(Console.ReadLine());

        int enYasli = EnYasliyiBul(yas1, yas2, yas3);

        Console.WriteLine("En yaşlı kişinin yaşı: " + enYasli);

        //12
        EnBuyukBul();

        //13
        string isimA = "İlayda";
        string isimB = "Ceku";
        IsimDegistir(ref isimA, ref isimB);
        Console.WriteLine("İlk isim: " +isimA + "İkinci isim: " +isimB );

        //14
        Console.Write("Bir sayı giriniz: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        if (IsOdd(userInput))
        {
            Console.WriteLine("Bu sayı TEKTİR.");
        }
        else
        {
            Console.WriteLine("Bu sayı ÇİFTTİR.");
        }


    

        //15
        Console.WriteLine("Hız giriniz: ");
        double hiz = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Zaman giriniz. ");
        double zaman = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Gidilen yol: " + YolHesapla(hiz,zaman));

        //16
        Console.WriteLine("Yarı çapı giriniz: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dairenin alanı: " + DaireAlan(r));

        //17
        string cumle = "Zaman bir GeRi SayIm";
        Console.WriteLine("BÜYÜK: " + cumle.ToUpper());
        Console.WriteLine("küçük: " + cumle.ToLower());

        //18
        string mesaj = "    Selamlar   ";
        mesaj = mesaj.Trim();
        Console.WriteLine("'" + mesaj + "'");



        //8
        static void BendegerDondurmem()
        {
            Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok , beni değişkene atamaya çalışma.");
        }

        //9
        static int Topla(int a , int b)
        {
            return a + b;
        }

        //10
        static string DurumMesaji(bool durum)
        {
            return durum ? "True girdiniz" : "False girdiniz ";
        }

        //11
        static int EnYasliyiBul(int yas1, int yas2, int yas3)
        {
            int enBuyuk = yas1;

            if (yas2 > enBuyuk)
                enBuyuk = yas2;

            if (yas3 > enBuyuk)
                enBuyuk = yas3;

            return enBuyuk;
        }



        //12
        static void EnBuyukBul()
        {
            int enBuyuk = int.MinValue;

            while (true)
            {
                Console.WriteLine("Sayı giriniz (çıkmak için q): ");
                string giris = Console.ReadLine();
                if (giris.ToLower() == "q")
                
                    break;
                
                int sayi = Convert.ToInt32(giris);
                if (sayi > enBuyuk)
                    enBuyuk = sayi;
             }
            Console.WriteLine("EN büyük sayı: " + enBuyuk );
        }

        //13
        static void IsimDegistir(ref string x, ref string y)
        {
            string temp = x;
            x= y;
            y= temp;
        }

        //14
        static bool IsOdd(int number)
        {
            return number % 2 != 0; // Tekse true, değilse false
        }

        //15
        static double YolHesapla(double hiz, double zaman)
        {
            return hiz * zaman;
        }

        //16
        static double DaireAlan(double r)
        {
            return Math.PI * r * r;
        }








    }










}
