using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nizovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Napišite program koji će deklarirati dva niza tipa int veličine 10 članova, te će zatražiti od korisnika da unosi brojeve. 
            Ako korisnik unese neparni broj spremite ga u prvi niz, a ako unese parni spremite ga u drugi niz. Program treba prestati 
            s radom ako korisnik unese 0 ili kad ukupan broj članova dodijeljenih pojedinom nizu premaši 10. Na kraju ispišite sve članove nizova.*/
            int broj = 0, i =0, j=0;
            int[] a= new int[15], b= new int[15];
            while (i < 10 && j < 10)
            {
                broj = Convert.ToInt32(Console.ReadLine());
                if (broj == 0) { break; }
                if (broj % 2 == 0) { a[i] = broj; i++; }
                if (broj % 2 != 0) { b[j] = broj; j++; }
                
            }
            Console.WriteLine("Parni brojevi");
            for(int k=0; k<=i; k++) { Console.WriteLine(" {0} ", a[k]); }
            Console.WriteLine("Neparni brojevi");
            for (int l = 0; l <= j; l++) { Console.WriteLine(" {0} ", b[l]); }

            Console.ReadKey();

            /*2. Napišite program koji će definirati 2 niza tipa int, te će izračunati broj članova koji se nalaze na istom indeksu i imaju istu vrijednost. 
             Program mora raditi ispravno za proizvoljni broj članova niza.*/

            Console.WriteLine("Koliko članova trebaju imati nizovi?");
            int broj_clanova = Convert.ToInt32(Console.ReadLine());

            int[] c = new int[broj_clanova], d = new int[broj_clanova];
            for(int p=0; p<broj_clanova; p++) { c[p] = Convert.ToInt32(Console.ReadLine()); }
            for (int r = 0; r < broj_clanova; r++) { d[r] = Convert.ToInt32(Console.ReadLine()); }

            int broj_istih=0;
            for (int o=0; o<broj_clanova; o++)
            {
                if (c[o] == d[o])
                {
                    broj_istih++;
                }
            }
            Console.WriteLine("Ima {0} istih članova na istim indeksima", broj_istih);

            Console.ReadKey();
        }
    }
}
