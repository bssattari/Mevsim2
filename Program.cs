using System;

namespace Mevsim2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            long telefon = 5321645027;
            DateTime tarih;
            int ay;
            int gun;
            string haftaninGunu;

            tarih = DateTime.Now;
            ay = tarih.Month;
            gun = tarih.Day;
            haftaninGunu = tarih.DayOfWeek.ToString();

            Console.WriteLine("Bugünün tarihi  : {0:dd/MM/yyyy}", tarih);
            Console.WriteLine("Saat  : {0:HH:mm:ss}", tarih);
            Console.WriteLine(String.Format("{0:(###) ### ## ##}", telefon));
            */
            int ay;

            //ay = DateTime.Now.Month;
            Console.Write("Ay Giriniz:");
            ay = Convert.ToInt16(Console.ReadLine());

            switch (ay)
            {
                case 12:
                    Console.WriteLine("Mevsim Kış");
                    break;
                case 1:
                    Console.WriteLine("Mevsim Kış");
                    break;
                case 2:
                    Console.WriteLine("Mevsim Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Mevsim İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Mevsim Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Mevsim Sonbahar");
                    break;
                    
                default:
                    Console.WriteLine("1-12 arasında bir değer girilmelidir!");
                    break;
            }
        }
    }
}
