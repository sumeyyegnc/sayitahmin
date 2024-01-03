namespace sayitahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmin Oyunu!");

                Console.WriteLine("Kolay, Orta veya Zor leveli seçin:");
                Console.WriteLine("Kolay için 1, Orta için 2, Zor için 3 girin:");

                int max = 0;
                int level = int.Parse(Console.ReadLine());

                if (level == 1)
                {
                    max = 5;
                }
                else if (level == 2)
                {
                    max = 3;
                }
                else if (level == 3)
                {
                    max = 1;
                }

                Random random = new Random();
                int randomNumber = random.Next(1, 11); // 1 ile 10 arasında rastgele bir sayı seç

                Console.WriteLine($"Tahmin etmek için 1 ile 10 arasında bir sayı girin. {max} hakkınız var:");

                for (int i = 0; i < 10; i++)
                {
                    int tahmin = int.Parse(Console.ReadLine());


                    if (tahmin == randomNumber)
                    {
                        Console.WriteLine("Tebrikler!");

                        if (level == 1)
                        {
                            Console.WriteLine("Bir üst seviyeye geçmek ister misiniz? (Evet/Hayır)");
                            string response = Console.ReadLine().ToLower();
                            if (response == "evet")
                            {
                                break;
                            }

                        }
                        else if (level == 2)
                        {
                            Console.WriteLine("Bir üst seviyeye geçmek ister misiniz? (Evet/Hayır)");
                            string response = Console.ReadLine().ToLower();
                            if (response == "evet")
                            {
                                max = 3;
                                level = 3;
                                randomNumber = random.Next(1, 11);
                                Console.WriteLine($"Tahmin etmek için 1 ile 10 arasında bir sayı girin. {max} hakkınız var:");
                            }
                            else
                            {
                                Console.WriteLine("Oyunumuza vakit ayırdığınız için teşekkürler.");
                                return;
                            }
                        }
                        else if (level == 3)
                        {
                            Console.WriteLine("Tekrar oynamak ister misiniz? (Evet/Hayır)");
                            string response = Console.ReadLine().ToLower();
                            if (response == "evet")
                            {
                                max = 3;
                                i = -1;
                                randomNumber = random.Next(1, 11);
                                Console.WriteLine($"Tahmin etmek için 1 ile 10 arasında bir sayı girin. {max} hakkınız var:");
                            }

                        }
                    }
                }

                Console.WriteLine($"Tahmin hakkınız bitti. Doğru sayı: {randomNumber}. Yeniden başlamak ister misin? (Evet/Hayır)");
                string again = Console.ReadLine().ToLower();
                if (again != "evet")
                {
                    Console.WriteLine("Teşekkürler.");
                    
                }
           
        }
    }
}