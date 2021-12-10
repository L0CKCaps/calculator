using System;

namespace hesapmak
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayı1 gir sayı2 gir işlem seç işlemi uygula

            int sayi1, sayi2,islem;
            Console.WriteLine("Tam sayı girin: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tam sayı girin: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem seçiniz: 1.top\n2.çıkarma\n3.çarpma\n4.bölme");
            islem = Convert.ToInt32(Console.ReadLine());
            switch (islem)
            {
                case 1  :
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case 2:
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case 3:
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case 4:
                    Console.WriteLine(Convert.ToDouble(sayi1) / sayi2);
                    break;
                default:
                    Console.WriteLine("Menüdeki bir işlemi seçiniz...");
                    break;
            }
        }
    }
}
