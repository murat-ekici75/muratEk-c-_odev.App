using System.ComponentModel;

namespace muratEkıcı_odev.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sayack = 0;
                int puank = 100;
                int sayaco = 0;
                int puano = 100;
                int sayacz = 0;
                int puanz = 100;
                Console.WriteLine("**** SAYI TAHMİN OYUNU ****");
                Console.WriteLine();
                Console.Write("Lütfen Seviye Seçiniz : K(Kolay),O(Orta),Z(Zor) = ");
                string sevıye = Console.ReadLine().ToUpper();
                if (sevıye == "K")
                {
                    Random kolays = new Random();
                    int number1 = kolays.Next(1,11);
                    Console.WriteLine("Deneme Hakkınız 3 ! (Aralık --> 1 ile 10)");
                    do
                    {
                        Console.Write("Lütfen Bir Sayı Giriniz: ");
                        int sayi1 = int.Parse(Console.ReadLine());
                        if (number1 == sayi1)
                        {
                            Console.WriteLine(" Doğru Tahmin :) = " + sayi1);
                            Console.WriteLine("Puanınız = " + puank);
                            break;
                        }
                        else
                        {
                            sayack++;
                            puank -= 10;
                            Console.WriteLine(" Yanlış Tahmin !!! ");
                            if (sayack == 3)
                            {
                                Console.WriteLine(" Puanınız = 0 Ve Sayı = " + number1);
                            }
                        }
                    } while (sayack < 3);
                }
                else if (sevıye == "O")
                {
                    Random ortas = new Random();
                    int number2 = ortas.Next(1,21);
                    Console.WriteLine("Deneme Hakkınız 5 ! (Aralık --> 1 ile 20)");
                    do
                    {
                        Console.Write("Lütfen Bir Sayı Giriniz: ");
                        int sayi2 = int.Parse(Console.ReadLine());
                        if (number2 == sayi2)
                        {
                            Console.WriteLine(" Doğru Tahmin :) = " + sayi2);
                            Console.WriteLine("Puanınız = " + puano);
                            break;
                        }
                        else
                        {
                            sayaco++;
                            puano -= 5;
                            Console.WriteLine("Yanlış Tahmin !!!");
                            if (sayaco == 5)
                            {
                                Console.WriteLine("Puanınız = 0 Ve Sayı = " + number2);
                            }
                        }
                    } while (sayaco < 5);
                }
                else
                {
                    Random zors = new Random();
                    int number3 = zors.Next(1,31);
                    Console.WriteLine("Deneme Hakkınız 10 ! (Aralık --> 1 ile 30)");
                    do
                    {
                        Console.Write("Lütfen Bir Sayı Giriniz : ");
                        int sayi3 = int.Parse(Console.ReadLine());
                        if (number3 == sayi3)
                        {
                            Console.WriteLine("Doğru Tahmin :) = " + sayi3);
                            Console.WriteLine("Puanınız = " + puanz);
                            break;
                        }
                        else
                        {
                            sayacz++;
                            puanz -= 3;
                            Console.WriteLine("Yanlış Tahmin !!! ");
                            if (sayacz == 10)
                            {
                                Console.WriteLine("Puanınız = 0 Ve Sayı = " + number3);
                            }
                        }
                    } while (sayacz < 10);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen Sadece Sayı Giriniz !!!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Değer Aralığı Dışına Çıktınız !!!");
            }
            catch (Exception)
            {
                Console.WriteLine("Bilinmeyen Bir Hata Ouştu !!!");
            }
        }
    }
}
