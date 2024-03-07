using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    internal class Alati
    {
        public static int RuA(string ulazniString)
        {
            int m = 0;
            int brojKaraktera2 = ulazniString.Length;
            int[] rezultatniNiz2 = new int[100];
            for (int i = 0; i < brojKaraktera2; i++)
            {
                if (ulazniString[i] == 'I')
                {
                    rezultatniNiz2[i] = 1;
                }
                if (ulazniString[i] == 'V')
                {
                    rezultatniNiz2[i] = 5;
                }
                if (ulazniString[i] == 'X')
                {
                    rezultatniNiz2[i] = 10;
                }
                if (ulazniString[i] == 'L')
                {
                    rezultatniNiz2[i] = 50;
                }
                if (ulazniString[i] == 'C')
                {
                    rezultatniNiz2[i] = 100;
                }
                if (ulazniString[i] == 'D')
                {
                    rezultatniNiz2[i] = 500;
                }
                if (ulazniString[i] == 'M')
                {
                    rezultatniNiz2[i] = 1000;
                }

            }
            for (int j = 0; j < brojKaraktera2; j++)
            {
                if (rezultatniNiz2[j] < rezultatniNiz2[j + 1])
                {
                    rezultatniNiz2[j + 1] = rezultatniNiz2[j + 1] - rezultatniNiz2[j];
                    j++;
                }
                m = m + rezultatniNiz2[j];
            }
            return m;

        }
        public static string Nule(string ulazniString)
        {
            int i;
            //int flag;
            string ispis2 = "";
            if (ulazniString[0] == '-')
            {
                ispis2 = ispis2 + '-';
                //flag = 1;
            }
            for (i = 1; i < ulazniString.Length; i++)
            {
                if (((ispis2 == "") || (ispis2 == "-")) && (ulazniString[i] == '0'))
                {

                    continue;

                }
                else ispis2 = ispis2 + ulazniString[i];
            }

            return ispis2;
        }

        public static string SkloniMinus(string ulazniString1)
        {
            string pomocni = "";

            for (int i = 0; i < ulazniString1.Length; i++)
            {
                if (ulazniString1[i] == '-')
                {
                    continue;
                }
                else
                {
                    pomocni = pomocni + ulazniString1[i];
                }
            }

            return pomocni;
        }
        public static int Uporedi(string broj1, string broj2)
        {
            int p = 0;
            int p2 = 0;
            broj1 = Alati.SkloniNule(broj1);
            broj2 = Alati.SkloniNule(broj2);
            if (broj1.Contains(".") && !broj2.Contains("."))
            {
                broj2 = broj2 + ".0";
            }
            else
            {
                if (!broj1.Contains(".") && broj2.Contains("."))
                {
                    broj1 = broj1 + ".0";
                }
            }
            if (broj1.Contains(".") || broj2.Contains("."))
            {
                string[] deloviBroja1 = broj1.Split('.');
                string[] deloviBroja2 = broj2.Split('.');

                string celobrojniDeo1 = deloviBroja1[0];
                string celobrojniDeo2 = deloviBroja2[0];

                string decimalniDeo1 = deloviBroja1.Length > 1 ? deloviBroja1[1] : "";
                string decimalniDeo2 = deloviBroja2.Length > 1 ? deloviBroja2[1] : "";

                int rezultatCelobrojnogUporedjivanja = CompareHelper(celobrojniDeo1, celobrojniDeo2);
                if (rezultatCelobrojnogUporedjivanja != 0)
                    p = rezultatCelobrojnogUporedjivanja;
                if (p < 0)
                {
                    return 2;
                }    
                else return 1;
                int rezultatDecimalnogUporedjivanja = CompareHelper(decimalniDeo1, decimalniDeo2);
                if (rezultatDecimalnogUporedjivanja != 0)
                    p2 = rezultatDecimalnogUporedjivanja;
                if (p2 < 0)
                {
                    return 2;
                }
                else return 1;
            }
            else
            {

                // Pokušavamo konvertovati stringove u celobrojne vrednosti
                /*
                if (!int.TryParse(broj1, out intBroj1) || !int.TryParse(broj2, out intBroj2))
                {
                    // Ako nije moguće izvršiti konverziju, javljamo grešku
                    Console.WriteLine("Greška: Neispravan format brojeva.");
                    return -1;
                }*/
                int rezultatCelobrojnogUporedjivanja = CompareHelper(broj1, broj2);
                if (rezultatCelobrojnogUporedjivanja != 0)
                    p = rezultatCelobrojnogUporedjivanja;
                if (p < 0)
                {
                    return 2;
                }
                else return 1;

                // Ako su oba broja celobrojna, koristimo CompareNumbers funkciju za poređenje
                /*
                if (intBroj1 > intBroj2)
                    return 1;
                else if (intBroj1 < intBroj2)
                    return 2;
                else
                    return 0;
                */
            }
            


        }

        public static int CompareHelper(string broj1, string broj2)
        {

            broj1 = Alati.SkloniNule(broj1);
            broj2 = Alati.SkloniNule(broj2);
            if (broj1.Length != broj2.Length)
                return broj1.Length.CompareTo(broj2.Length);
            for (int i = 0; i < broj1.Length; i++)
            {
                int compareResult = broj1[i].CompareTo(broj2[i]);
                if (compareResult != 0)
                    return compareResult;
            }
            return 0;
            
        }

        public static string SkloniNule(string broj)
        {
            int i = 0;
            while (i < broj.Length && broj[i] == '0')
            {  i++; }
            if (broj == "")
            {
                return broj;
            }
            else return broj.Substring(i);
        }
    }
}