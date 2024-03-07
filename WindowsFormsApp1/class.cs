using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class class1
    {
        public static string Provera(string ulazniString)
        {
            int m = 0;
            string ispravan = "";
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
            if (m > 3999)
            {
                MessageBox.Show("preveliki broj");
                
            }
            //ispis.Text = "";
            int[] niz = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string [] nizbr = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < 13; i++)
            {
                if ((m - niz[i]) >= 0)
                {
                    m = m - niz[i];
                    ispravan = ispravan + nizbr[i];
                    i--;
                }

            }

            return ispravan;
        }
    }
}
