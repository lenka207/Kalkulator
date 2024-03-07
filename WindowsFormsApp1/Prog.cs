using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Prog
    {
        public static string InvertAndFormat(double broj)
        {
            // Obrtanje broja i konverzija u string
            string obrnutiBroj = ReverseNumber(broj);

            // Pronalaženje indeksa decimalne tačke
            int decimalIndex = obrnutiBroj.IndexOf('.');

            // Ako nema decimalne tačke, dodajemo je na kraj
            if (decimalIndex == -1)
            {
                obrnutiBroj += ".";
                decimalIndex = obrnutiBroj.Length - 1;
            }

            // Dodavanje nula na kraju da bi se izjednačili brojevi
            while (obrnutiBroj.Length - decimalIndex - 1 < 3)
            {
                obrnutiBroj += "0";
            }

            return obrnutiBroj;
        }
        public static string ReverseNumber(double broj)
        {
            // Konverzija broja u string, obrtanje stringa i vraćanje rezultata
            return new string(broj.ToString().ToCharArray().Reverse().ToArray());
        }
       
        
    }
}
