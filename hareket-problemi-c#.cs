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
            

            yol = hiz * zaman;// h�z ve zaman �arp�l�r yol elde edilir
            Console.WriteLine("Yol:" + yol); // yol ekrana yazd�r�l�r

            hiz = yol / zaman;// yol ve zaman b�l�n�rse h�z elde edilir
            Console.WriteLine("H�z:" + hiz); // h�z ekrana yazd�r�l�r

            zaman = yol / hiz;// yol ve h�z b�l�n�rse zaman elde edilir
            Console.WriteLine("Yol:" + zaman); // zaman ekrana yazd�r�l�r.

            // Hareket probleminde hareketliler ayn� anda ve z�t y�nde ve ayn� anda ayn� y�nde durumu

            int vhiz1 = 40; //1ci araban�n h�z�
            int vhiz2 = 20; //2ci araban�n h�z�
            int tzaman = 5; // zaman�
            int xyolzit = 100; // z�t y�nde olan yol
            int xyolayniyon = 100; // ayn� y�nde olan yol

            xyolzit = (vhiz1 + vhiz2) * tzaman; // 2 h�zlar toplan�r ve zamanla �arp�larak z�t yol bulunur
            xyolayniyon = (vhiz1 - vhiz2) * tzaman; // 2 h�zlar ��kart�l�r ve zamanla �arp�larak ayn� y�n yol bulunur.
            Console.WriteLine("Hareketliler Ayn� anda ve z�t y�ndeyken:" + xyolzit);
            Console.WriteLine("Hareketliler ayn� anda ve ayn� y�nde ise:" + xyolayniyon);

            Console.ReadKey(); // program kapanmas�n diye imle� yazd�r�l�r
        }
    }
}
