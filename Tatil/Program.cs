using System;
class TravelPlanner
{
    static void Main(string[] args)
    {
        bool cotinuePlanning = true;

        while (cotinuePlanning)
        {
            string location = "";
            int basePrice = 0;



            while (true)
            {
                Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu giriniz.(Bodrum,Marmaris,Çeşme): ");
                location = Console.ReadLine().Trim().ToLower();
                if (location == "bodrum")
                {
                    basePrice = 4000;
                    location = "Bodrum";
                    break;
                }
                else if (location == "marmaris")
                {
                    basePrice = 3000;
                    location = "Marmaris";
                    break;
                }
                else if (location == "çeşme" || location == "cesme")
                {
                    basePrice = 5000;
                    location = "Çeşme";
                    break;

                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız. ");
                }
            }
                Console.WriteLine("Kaç kişi için tatil planı yapıyorsunuz ? ");
                int personCount;
                while (!int.TryParse(Console.ReadLine(), out personCount) || personCount < 0)
                {
                    Console.WriteLine("Geçerli pozitif bir sayı giriniz: ");
                }
                Console.WriteLine($"\n{location}lokasyonunu seçtiniz.");

                int travelCostPerPerson = 0;
            while (true)
            {
                Console.WriteLine("Tatile nasıl gitmek istiyorsunuz?");
                Console.WriteLine("1 - Kara yolu (Kişi başı gidiş-dönüş 1500 TL)");
                Console.WriteLine("2 - Hava yolu (Kişi başı gidiş-dönüş 4000 TL)");
                Console.Write("Lütfen 1 ya da 2 seçiniz: ");
                string travelChoice = Console.ReadLine().Trim();

                if (travelChoice == "1")
                {
                    travelCostPerPerson = 1500;
                    break;
                }
                else if (travelChoice == "2")
                {
                    travelCostPerPerson = 4000;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız. Lütfen sadece 1 ya da 2 giriniz.\n");
                }
            }
                    int totalCost = (basePrice + travelCostPerPerson);
                    Console.WriteLine($"\nToplam fiyat ({location} için {personCount} kişi): {totalCost} TL");
                
                Console.WriteLine("Başka bir tatil planı yapmak ister misiniz? (E/H)");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer != "e")
                {
                    cotinuePlanning = false;
                    Console.WriteLine("İyi günler dileriz. ");
                    break;

                }
                Console.WriteLine();
            }


        }
    }






