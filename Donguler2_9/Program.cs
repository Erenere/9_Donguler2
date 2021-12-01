using System;

namespace Donguler2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1den baslayarak consoledan girilen sayiya kadar (sayi dahil) ortalama hesaplayıp consolea yazdiran program
            Console.Write("Bir sayi girin: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            char character = 'a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }
            
            Console.Write("******* Foreach ***********");
            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};  

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}