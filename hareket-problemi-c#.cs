using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formuller
{
    class Program
    {
        static void Main(string[] args)
        {
            int yol = 100;
            int hiz = 20;
            int zaman = 5;
            

            yol = hiz * zaman;// hýz ve zaman çarpýlýr yol elde edilir
            Console.WriteLine("Yol:" + yol); // yol ekrana yazdýrýlýr

            hiz = yol / zaman;// yol ve zaman bölünürse hýz elde edilir
            Console.WriteLine("Hýz:" + hiz); // hýz ekrana yazdýrýlýr

            zaman = yol / hiz;// yol ve hýz bölünürse zaman elde edilir
            Console.WriteLine("Yol:" + zaman); // zaman ekrana yazdýrýlýr.

            // Hareket probleminde hareketliler ayný anda ve zýt yönde ve ayný anda ayný yönde durumu

            int vhiz1 = 40; //1ci arabanýn hýzý
            int vhiz2 = 20; //2ci arabanýn hýzý
            int tzaman = 5; // zamaný
            int xyolzit = 100; // zýt yönde olan yol
            int xyolayniyon = 100; // ayný yönde olan yol

            xyolzit = (vhiz1 + vhiz2) * tzaman; // 2 hýzlar toplanýr ve zamanla çarpýlarak zýt yol bulunur
            xyolayniyon = (vhiz1 - vhiz2) * tzaman; // 2 hýzlar çýkartýlýr ve zamanla çarpýlarak ayný yön yol bulunur.
            Console.WriteLine("Hareketliler Ayný anda ve zýt yöndeyken:" + xyolzit);
            Console.WriteLine("Hareketliler ayný anda ve ayný yönde ise:" + xyolayniyon);

            Console.ReadKey(); // program kapanmasýn diye imleç yazdýrýlýr
        }
    }
}
