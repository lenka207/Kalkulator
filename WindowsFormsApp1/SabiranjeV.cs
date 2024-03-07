using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    internal class Operacije
    {
        public static string Saberi(string ulazniString1, string ulazniString2)
        {
            int i, j, veci, br;

            string ispis1 = " ";
            int[] rez = new int[260];
            //string ulazniString1 = unos.Text;
            int brKaraktera = ulazniString1.Length;
            int[] pariz = new int[260];
            int[] drniz = new int[260];
            for (i = 0; i < 260; i++)
            {
                rez[i] = -1;
            }
            for (i = 0; i < 260; i++)
            {
                pariz[i] = 0;
            }
            for (i = 0; i < 260; i++)
            {
                drniz[i] = 0;
            }
            for (i = brKaraktera; i >= 0; i--)
            {
                if (i - 1 < 0)
                {
                    break;
                }
                else
                {
                    if (ulazniString1[i - 1] == '-')
                    {
                        break;
                    }
                }



                pariz[brKaraktera - i] = int.Parse(ulazniString1[i - 1].ToString());
                ispis1 = ispis1 + int.Parse(pariz[brKaraktera - i].ToString());

            }
            //MessageBox.Show(pariz.ToString());
            string ispis2 = " ";
            string ispis3 = " ";
            int brKaraktera2 = ulazniString2.Length;



            for (i = brKaraktera2; i > 0; i--)
            {
                if (ulazniString2[i - 1] == '-')
                {
                    break;
                }
                else
                {
                    drniz[brKaraktera2 - i] = int.Parse(ulazniString2[i - 1].ToString());
                    ispis2 = ispis2 + int.Parse(drniz[brKaraktera2 - i].ToString());
                }
            }

            if (brKaraktera >= brKaraktera2)
            {
                for (i = 0; i < brKaraktera + 1; i++)
                {
                    veci = pariz[i] + drniz[i];
                    if (veci >= 10)
                    {
                        rez[i] = (pariz[i] + drniz[i]) - 10;
                        pariz[i + 1] = pariz[i + 1] + 1;
                    }
                    else rez[i] = pariz[i] + drniz[i];
                }
            }
            else
            {
                for (i = 0; i < brKaraktera2 + 1; i++)
                {
                    veci = pariz[i] + drniz[i];
                    if (veci >= 10)
                    {
                        rez[i] = (pariz[i] + drniz[i]) - 10;
                        pariz[i + 1] = pariz[i + 1] + 1;
                    }
                    else rez[i] = pariz[i] + drniz[i];
                }
            }

            br = 0;
            for (j = 0; j < 260; j++)
            {
                if (rez[j] != -1)
                {
                    br++;
                }
            }

            for (i = br - 1; i >= 0; i--)
            {
                ispis3 = ispis3 + int.Parse(rez[i].ToString());
            }
            string p;
            p = Alati.SkloniNule(ispis3);
            //ispis.Text = ispis3.ToString();
            return p;
        }

        public static string Sabiranjedec(string ulazniString1, string ulazniString2, int pok, int pok2)
        {
            int i, j, id, veci;
            string ispis1 = "";
            int[] rez = new int[260];
            //string ulazniString1 = unos.Text;
            int brKaraktera = ulazniString1.Length;
            int[] pariz = new int[260];
            string ispis2 = "";
            string ispis3 = "";
            //string ulazniString2 = unos2.Text;
            int brKaraktera2 = ulazniString2.Length;
            int[] drniz = new int[260];
            int[] drniz1 = new int[260];
            //int pok = 0;
            //int pok2 = 0;
            int br = 0;

            int pobednik = 0;
            for (i = 0; i < 260; i++)
            {
                rez[i] = -1;
            }
            int promeni = 0;
            string ceobr = "";
            //ovde je bio
            for (i = 0; i < brKaraktera; i++)
            {
                if (ulazniString1[i] == '.')
                {
                    promeni = 1;
                    continue;
                }
                else
                {

                    if (promeni == 1)
                    {
                        ispis1 = ispis1 + ulazniString1[i];

                    }
                    else
                    {
                        ceobr = ceobr + ulazniString1[i];

                    }
                }
            }
            int promeni1 = 0;
            string ceobr2 = "";
            for (i = 0; i < brKaraktera2; i++)
            {
                if (ulazniString2[i] == '.')
                {
                    promeni1 = 1;
                    continue;
                }
                else
                {

                    if (promeni1 == 1)
                    {
                        ispis2 = ispis2 + ulazniString2[i];

                    }
                    else
                    {
                        ceobr2 = ceobr2 + ulazniString2[i];

                    }
                }
            }
            if (pok >= pok2)
            {
                for (i = ispis2.Length + 1; i <= ispis1.Length; i++)
                {
                    ispis2 = ispis2 + '0';

                }
                pobednik = pok;
            }
            else
            {
                for (i = ispis1.Length + 1; i <= ispis2.Length; i++)
                {
                    ispis1 = ispis1 + '0';

                }

                pobednik = pok2;
            }

            if (ispis1.Length > ispis2.Length)
            {
                id = ispis1.Length;
            }
            else id = ispis2.Length;

            //ovde je bio


            int pomm = ispis1.Length;
            for (i = 0; i < pomm; i++)
            {
                if (int.TryParse(ispis1[i].ToString(), out int brojjj))
                {
                    pariz[i] = brojjj;

                }

            }

            int pommm = ispis2.Length;
            for (i = 0; i < pommm; i++)
            {
                if (int.TryParse(ispis2[i].ToString(), out int broj1))
                {
                    drniz[i] = broj1;
                }
            }

            for (i = pomm - 1; i >= 0; i--)
            {

                veci = pariz[i] + drniz[i];
                if (veci >= 10)
                {
                    if (i == 0)
                    {
                        rez[i] = (pariz[i] + drniz[i]) - 10;
                        ceobr = (int.Parse(ceobr) + 1).ToString();
                    }
                    else
                    {
                        rez[i] = (pariz[i] + drniz[i]) - 10;
                        pariz[i - 1] = pariz[i - 1] + 1;
                    }
                }
                else rez[i] = pariz[i] + drniz[i];

            }

            br = 0;
            for (j = 0; j < 260; j++)
            {

                if (rez[j] != -1)
                {
                    br++;
                }
            }
            ispis3 = ".";
            for (i = 0; i < br; i++)
            {
                ispis3 = ispis3 + int.Parse(rez[i].ToString());
            }
            string y;
            string b;
            y = Operacije.Saberi(ceobr, ceobr2);
            b = y + ispis3.ToString();

            return b;
        }

        public static string Oduzmi(string ulazniString1, string ulazniString2)
        {
            int i, j, br, pobednik;
            int obrnuto = 0;
            //ispis.Text = " ";
            string ispis1 = " ";
            int[] rez = new int[260];
            //string ulazniString1 = unos.Text;
            int brKaraktera = ulazniString1.Length;
            int[] pariz = new int[260];
            for (i = 0; i < 260; i++)
            {
                rez[i] = -1;
            }
            for (i = brKaraktera; i > 0; i--)
            {
                if (ulazniString1[i - 1] == '-')
                {
                    break;
                }
                pariz[brKaraktera - i] = int.Parse(ulazniString1[i - 1].ToString());
                ispis1 = ispis1 + int.Parse(pariz[brKaraktera - i].ToString());
            }

            string ispis2 = "";
            string ispis3 = "";
            //string ulazniString2 = unos2.Text;
            int brKaraktera2 = ulazniString2.Length;
            int[] drniz = new int[260];
            for (i = brKaraktera2; i > 0; i--)
            {
                if (ulazniString2[i - 1] == '-')
                {
                    break;
                }
                drniz[brKaraktera2 - i] = int.Parse(ulazniString2[i - 1].ToString());
                ispis2 = ispis2 + int.Parse(drniz[brKaraktera2 - i].ToString());
            }
            if (brKaraktera >= brKaraktera2)
            {
                pobednik = brKaraktera;
            }
            else pobednik = brKaraktera2;
            //provera koji je broj veci
            int broj1 = brKaraktera;
            int broj2 = brKaraktera2;
            for (i = pobednik - 1; i >= 0; i--)
            {
                if (pariz[i] < drniz[i])
                {
                    obrnuto = 1;
                    break;
                }
                else
                {
                    if (pariz[i] > drniz[i])
                    {
                        obrnuto = 0;
                        break;
                    }
                }
            }
            //provera
            if (obrnuto == 1)
            {
                for (i = 0; i < pobednik; i++)
                {
                    if (drniz[i] < pariz[i])
                    {
                        rez[i] = (drniz[i] + 10) - pariz[i];
                        j = i + 1;
                        while (drniz[j] == 0)
                        {
                            drniz[j] = 9;
                            j++;
                        }
                        drniz[j] = drniz[j] - 1;
                    }
                    else rez[i] = drniz[i] - pariz[i];
                }
                ispis3 = "-";
            }
            else
            {
                for (i = 0; i < pobednik; i++)
                {
                    if (pariz[i] < drniz[i])
                    {
                        rez[i] = (pariz[i] + 10) - drniz[i];
                        j = i + 1;
                        while (pariz[j] == 0)
                        {
                            pariz[j] = 9;
                            j++;
                        }
                        pariz[j] = pariz[j] - 1;
                    }
                    else rez[i] = pariz[i] - drniz[i];
                }
            }

            br = 0;
            for (j = 0; j < 260; j++)
            {
                if (rez[j] != -1)
                {
                    br++;
                }
            }

            for (i = br - 1; i >= 0; i--)
            {
                ispis3 = ispis3 + int.Parse(rez[i].ToString());
            }

            return ispis3;
            //ispis.Text = ispis3.ToString();
        }


        public static string Oduzmidec(string ulazniString1, string ulazniString2)
        {
            int i, j, id, pobednik, br;
            pobednik = 0;
            string ispis1 = "";
            int[] rez = new int[260];
            int brKaraktera = ulazniString1.Length;
            int[] pariz = new int[260];
            string ispis2 = "";
            string ispis3 = "";
            int brKaraktera2 = ulazniString2.Length;
            int[] drniz = new int[260];
            int[] drniz1 = new int[260];
            int broj = 0;
            int brojj = 0;
            int pok = 0;
            int pok2 = 0;

            ulazniString1 = Alati.SkloniNule(ulazniString1);
            ulazniString2 = Alati.SkloniNule(ulazniString2);
            if (ulazniString1.Contains(".") && !ulazniString2.Contains("."))
            {
                ulazniString2 = ulazniString2 + ".0";
            }
            else
            {
                if (!ulazniString1.Contains(".") && ulazniString2.Contains("."))
                {
                    ulazniString1 = ulazniString1 + ".0";
                }
            }

            for (i = ulazniString1.Length - 1; i >= 0; i--)
            {
                if (ulazniString1[i] == '.')
                {
                    pok = broj;
                    break;
                }
                broj++;

            }
            for (j = ulazniString2.Length - 1; j >= 0; j--)
            {
                if (ulazniString2[j] == '.')
                {
                    pok2 = brojj;
                    break;

                }
                brojj++;

            }

            for (i = 0; i < 260; i++)
            {
                rez[i] = -1;
            }
            if (pok >= pok2)
            {
                if (pok2 == 0)
                {
                    pobednik = pok;
                }
                else
                {
                    for (i = ulazniString2.Length + 1; i <= ulazniString1.Length; i++)
                    {
                        ulazniString2 = ulazniString2 + '0';

                    }
                    pobednik = pok;
                }
            }
            else
            {
                if (pok == 0)
                {
                    pobednik = pok2;
                }
                else
                {
                    for (i = ulazniString1.Length + 1; i <= ulazniString2.Length; i++)
                    {
                        ulazniString1 = ulazniString1 + '0';

                    }

                    pobednik = pok2;
                }
            }

            if (ulazniString1.Length > ulazniString2.Length)
            {
                id = brKaraktera;
            }
            else id = ulazniString2.Length;
            int promeni = 0;
            string ceobr = "";
            string ceobr2 = "";
            int obrtanje = 0;

            int uporedi;
            uporedi = Alati.Uporedi(ulazniString1, ulazniString2);
            if (uporedi == 1)
            {
                for (i = 0; i < ulazniString1.Length; i++)
                {
                    if (ulazniString1[i] == '.')
                    {
                        promeni = 1;
                        continue;
                    }
                    else
                    {

                        if (promeni == 1)
                        {
                            ispis1 = ispis1 + ulazniString1[i];

                        }
                        else
                        {
                            ceobr = ceobr + ulazniString1[i];
                        }
                    }
                }
            }
            else
            {
                obrtanje = 1;
                for (i = 0; i < ulazniString1.Length; i++)
                {
                    if (ulazniString1[i] == '.')
                    {
                        promeni = 1;
                        continue;
                    }
                    else
                    {

                        if (promeni == 1)
                        {
                            ispis2 = ispis2 + ulazniString1[i];

                        }
                        else
                        {
                            ceobr2 = ceobr2 + ulazniString1[i];
                        }
                    }
                }
            }
            /*
            if (ispis1 == "")
            {
                for ( i = 0; i < ulazniString2.Length; i++)
                {
                    ispis1 = ispis1 + '0';
                }
            }
            if (ispis2 == "")
            {
                for (i = 0; i < ulazniString1.Length; i++)
                {
                    ispis2 = ispis2 + '0';
                }
            }
            */
            int pomm = 0;
            if (obrtanje == 1)
            {
                //pomm = ispis2.Length;
                for (i = 0; i < ispis2.Length; i++)
                {
                    if (int.TryParse(ispis2[i].ToString(), out int brojjj))
                    {
                        pariz[i] = brojjj;

                    }

                }

            }
            else
            {
                for (i = 0; i < ispis1.Length; i++)
                {
                    if (int.TryParse(ispis1[i].ToString(), out int brojjj))
                    {
                        pariz[i] = brojjj;

                    }

                }
            }

            int promeni1 = 0;
            int obrtanje2 = 0;
            uporedi = 0;
            uporedi = Alati.Uporedi(ulazniString1, ulazniString2);
            if (uporedi == 1)
            {
                for (i = 0; i < ulazniString2.Length; i++)
                {
                    if (ulazniString2[i] == '.')
                    {
                        promeni1 = 1;
                        continue;
                    }
                    else
                    {

                        if (promeni1 == 1)
                        {
                            ispis2 = ispis2 + ulazniString2[i];

                        }
                        else
                        {
                            ceobr2 = ceobr2 + ulazniString2[i];

                        }
                    }
                }
            }
            else
            {
                obrtanje2 = 1;
                for (i = 0; i < ulazniString2.Length; i++)
                {
                    if (ulazniString2[i] == '.')
                    {
                        promeni1 = 1;
                        continue;
                    }
                    else
                    {

                        if (promeni1 == 1)
                        {
                            ispis1 = ispis1 + ulazniString2[i];

                        }
                        else
                        {
                            ceobr = ceobr + ulazniString2[i];

                        }
                    }
                }

            }
            int pommm = ispis1.Length;
            if (obrtanje2 == 0)
            {
                pomm = ispis2.Length;
                for (i = 0; i < ispis2.Length; i++)
                {
                    if (int.TryParse(ispis2[i].ToString(), out int broj1))
                    {
                        drniz[i] = broj1;
                    }
                }
            }
            else
            {
                pomm = ispis1.Length;
                for (i = 0; i < ispis1.Length; i++)
                {
                    if (int.TryParse(ispis1[i].ToString(), out int broj1))
                    {
                        drniz[i] = broj1;
                    }
                }
            }

            for (i = pomm - 1; i >= 0; i--)
            {

                int flag = 0;
                for (i = pobednik - 1; i >= 0; i--)
                {
                    if (pariz[i] < drniz[i])
                    {
                        rez[i] = (pariz[i] + 10) - drniz[i];
                        j = i - 1;
                        if (j < 0)
                        {

                            if (flag == 0)
                            {
                                ceobr = (int.Parse(ceobr) - 1).ToString();
                            }

                            break;
                        }
                        while (pariz[j] == 0)
                        {
                            //MessageBox.Show("u while-u sam ");

                            if (j <= 0)
                            {
                                //MessageBox.Show("u if-u sam ");
                                ceobr = (int.Parse(ceobr) - 1).ToString();
                                flag = 1;
                                break;
                            }
                            pariz[j] = 9;
                            j--;
                        }

                        pariz[j] = pariz[j] - 1;
                    }
                    else rez[i] = pariz[i] - drniz[i];
                }



            }

            br = 0;
            for (j = 0; j < 260; j++)
            {

                if (rez[j] != -1)
                {
                    br++;
                }
            }
            ispis3 = ".";
            for (i = 0; i < br; i++)
            {
                ispis3 = ispis3 + int.Parse(rez[i].ToString());
            }


            string x;
            string y;
            x = Operacije.Oduzmi(ceobr, ceobr2);
            y = x + ispis3.ToString();

            return y;
        }
        public static string Mnozenje(string brojj1, string brojj2)
        {
            int br = 0;
            int pok = 0;
            int br2 = 0;
            int pok2 = 0;
            int tacka = 0;
            string broj1 = "";
            string broj2 = "";
            int minus;

            if (brojj1[0] == '-' && brojj2[0] == '-')
            {
                minus = 0;
                brojj1 = brojj1.Substring(1);
                brojj2 = brojj2.Substring(1);

            }
            else
            {
                if (brojj1[0] == '-' && brojj2[0] != '-')
                {
                    minus = 1;
                    brojj1 = brojj1.Substring(1);
                }
                else
                {
                    if (brojj1[0] != '-' && brojj2[0] == '-')
                    {
                        minus = 1;
                        brojj2 = brojj2.Substring(1);
                    }
                    else
                    {
                        minus = 0;
                    }
                }
            }

            for (int i = brojj1.Length - 1; i >= 0; i--)
            {
                if (brojj1[i] == '.')
                {
                    pok = br;
                    break;
                }
                br++;

            }
            for (int j = brojj2.Length - 1; j >= 0; j--)
            {
                if (brojj2[j] == '.')
                {
                    pok2 = br2;
                    break;

                }
                br2++;

            }
            for (int i = 0; i < brojj1.Length; i++)
            {
                if (brojj1[i] == '.')
                {
                    continue;
                }
                else
                {
                    broj1 += brojj1[i];
                }
            }
            for (int i = 0; i < brojj2.Length; i++)
            {
                if (brojj2[i] == '.')
                {
                    continue;
                }
                else
                {
                    broj2 += brojj2[i];
                }
            }
            tacka = pok + pok2;

            int[] rezultat = new int[broj1.Length + broj2.Length]; // rezultujući niz brojeva
            for (int i = 0; i < broj1.Length + broj2.Length; i++)
            {
                rezultat[i] = 0;
            }

            for (int i = broj1.Length - 1; i >= 0; i--)
            {
                // Iteracija unazad kroz drugi broj
                for (int j = broj2.Length - 1; j >= 0; j--)
                {
                    int mul = (broj1[i] - '0') * (broj2[j] - '0'); // Množenje cifara
                    int suma = mul + rezultat[i + j + 1]; // Dodavanje proizvoda na odgovarajuće mesto u rezultatu
                    rezultat[i + j] += suma / 10; // Dodavanje prenosne cifre na prethodnu poziciju
                    rezultat[i + j + 1] = suma % 10; // Dodavanje ostataka na trenutnu poziciju
                }
            }

            // Konverzija rezultata u string
            string rezultatString = "";

            foreach (int num in rezultat)
            {
                if (!(rezultatString.Length == 0 && num == 0)) // Ignorisanje vodećih nula
                    rezultatString += num;
            }

            int ttacka;
            string novi = "";
            //rezultatString = rezultatString + '0';
            ttacka = rezultatString.Length - tacka;
            for (int j = 0; j < ttacka; j++)
            {

                novi = novi + rezultatString[j];
            }
            string rez = "";
            string novi2 = "";
            for (int i = rezultatString.Length - 1; i >= ttacka; i--)
            {
                novi2 = rezultatString[i] + novi2;
            }
            if (minus == 1)
            {
                rez = '-' + novi + '.' + novi2;
            }
            else rez = novi + '.' + novi2;

            return rez.Length == 0 ? "0" : rez; // Ako je rezultat prazan, vraćamo "0"
        }
        public static string Deljenje(string ulazniString1, string ulazniString2, string koliko)
        {
            int i, j;
            string ispis1 = "";
            int[] rez = new int[260];
            //string ulazniString1 = unos.Text;
            int brKaraktera = ulazniString1.Length;
            int[] pariz = new int[260];
            string ispis2 = "";
            string ispis3 = "";
            //string ulazniString2 = unos2.Text;
            int brKaraktera2 = ulazniString2.Length;
            int[] drniz = new int[260];
            int[] drniz1 = new int[260];
            string broj1 = "";
            string broj2 = "";
            int br1 = 0;
            string pom1 = "";
            string pom2 = "";
            int broj09 = 0;
            int brojj10 = 0;
            int pok = 0;
            int pok2 = 0;
            if (koliko == "")
            {
                MessageBox.Show("niste uneli na koliko decimala da se zaokruzi resenje");
            }
            int minus = 0;
            for (i = 0; i< 260; i++)
            {
                rez[i] = -1;
            }
            if (ulazniString1[0] == '-' && ulazniString2[0] == '-')
            {
                minus = 0;
                ulazniString1 = ulazniString1.Substring(1);
                ulazniString2 = ulazniString2.Substring(1);

            }
            else
            {
                if (ulazniString1[0] == '-' && ulazniString2[0] != '-')
                {
                    minus = 1;
                    ulazniString1 = ulazniString1.Substring(1);
                }
                else
                {
                    if (ulazniString1[0] != '-' && ulazniString2[0] == '-')
                    {
                        minus = 1;
                        ulazniString2 = ulazniString2.Substring(1);
                    }
                    else
                    {
                        minus = 0;
                    }
                }
            }

            for (i = ulazniString1.Length - 1; i >= 0; i--)
            {
                if (ulazniString1[i] == '.')
                {
                    pok = broj09;
                    break;
                }
                broj09++;

            }
            for (j = ulazniString2.Length - 1; j >= 0; j--)
            {
                if (ulazniString2[j] == '.')
                {
                    pok2 = brojj10;
                    break;

                }
                brojj10++;
            }
            if (broj09 == ulazniString1.Length)
            {
                ulazniString1 += ".0";
                pok = 1;
            }
            if (brojj10 == ulazniString2.Length)
            {
                ulazniString2 += ".0";
                pok2 = 1;
            }
            int flag = 0;
            int fl = 0;
            int pomocni = 0;
            int proveriveci = 0;
            if (pok >= pok2 && (pok > 0 || pok2 > 0))
            {
                /*
                flag = 1;
                for (i = 0; i < ulazniString1.Length + pok - pok2; i++)
                {
                    if (ispis2.Length >= ulazniString2.Length - 1 && pomocni <= pok)
                    {
                        ispis2 = ispis2 + '0';
                        pomocni++;
                    }
                    else
                    {
                        if (pomocni == pok + 1)
                        {
                        break;
                        }
                        if (ulazniString2[i] == '.')
                        {
                        fl = 1;
                        pomocni++;
                        continue;
                        }
                        else
                        {
                            if (fl == 1)
                            {
                            pomocni++;
                            }
                        ispis2 = ispis2 + ulazniString2[i];
                        }
                    }
                }
                for (i = 0; i < ulazniString1.Length; i++)
                {
                    if (ulazniString1[i] == '.')
                    {
                    continue;
                    }
                    else
                    {
                    ispis1 = ispis1 + ulazniString1[i];
                }
                }
                */
                flag = 1;
                for (i = 0; i < ulazniString1.Length + pok - pok2 - 1; i++)
                {
                    if ((ispis2.Length >= (ulazniString2.Length - 1)) && pomocni <= pok )
                    {
                        ispis2 = ispis2 + '0';
                        pomocni++;
                    }
                    else
                    {
                        if (pomocni == pok + 1)
                        {
                            break;
                        }
                        if (ulazniString1.Length > ulazniString2.Length)
                        {
                            proveriveci = 1;
                            if (ulazniString1[i] == '.')
                            {
                                fl = 1;
                                pomocni++;
                                continue;
                            }

                        }
                        else
                        {
                            if (fl == 1)
                            {
                                pomocni++;
                            }
                            ispis2 = ispis2 + ulazniString2[i];
                        }
                    }
                }
                for (i = 0; i < ulazniString1.Length; i++)
                {
                    if (ulazniString1[i] == '.')
                    {
                        continue;
                    }
                    else
                    {
                        ispis1 = ispis1 + ulazniString1[i];
                    }
                }


            }
        else
        {
        if (pok2 > pok)
        {
                    /*
            flag = 1;
            for (i = 0; i < ulazniString1.Length; i++)
            {
                if (ispis1.Length >= ulazniString1.Length - 1 && pomocni <= pok2)
                {
                ispis1 = ispis1 + '0';
                pomocni++;
                }
            else
            {
                if (pomocni == pok2 + 1)
                {
                    break;
                }

                if (ulazniString1[i] == '.')
                {
                    fl = 1;
                    pomocni++;
                    continue;
                }
                else
                {
                    ispis1 = ispis1 + ulazniString1[i];
                }
            }
            }
            for (i = 0; i < ulazniString2.Length; i++)
            {
            if (ulazniString2[i] == '.')
            {
                continue;
            }
            else
            {
                ispis2 = ispis2 + ulazniString2[i];
            }
            }
                    */
                    flag = 1;
                    for (i = 0; i < ulazniString2.Length + pok2 - pok - 1; i++)
                    {
                        if ((ispis1.Length >= (ulazniString1.Length - 1)) && pomocni <= pok2)
                        {
                            ispis1 = ispis1 + '0';
                            pomocni++;
                        }
                        else
                        {
                            if (pomocni == pok2 + 1)
                            {
                                break;
                            }

                            if (ulazniString1[i] == '.')
                            {
                                fl = 1;
                                pomocni++;
                                continue;
                            }
                            else
                            {
                                if (proveriveci != 1)
                                {
                                    proveriveci = 0;
                                    if (fl == 1)
                                    {
                                        pomocni++;
                                    }
                                }
                                
                                ispis1 = ispis1 + ulazniString1[i];
                            }
                        }
                    }
                    for (i = 0; i < ulazniString2.Length; i++)
                    {
                        if (ulazniString2[i] == '.')
                        {
                            continue;
                        }
                        else
                        {
                            ispis2 = ispis2 + ulazniString2[i];
                        }
                    }
        }
    }
    if (flag == 0)
    {
    for (i = 0; i < ulazniString1.Length; i++)
    {
        ispis1 = ispis1 + ulazniString1[i];
    }
    for (i = 0; i < ulazniString2.Length; i++)
    {
        ispis2 = ispis2 + ulazniString2[i];
    }
}
// prebacili smo iz textBox-a u niz
// ako ima tacku na prvom tacka - 1 ako je na 2 ond tacka + 1
for (i = 0; i < ispis2.Length; i++)
{
    broj1 = broj1 + ispis1[i];
    broj2 = broj2 + ispis2[i];
}
int brkol = ispis2.Length - 1;
pom1 = broj1;
pom2 = pom1;
int brojac = 0;
flag = 0;
for (i = ispis2.Length - 1; i < ispis1.Length + int.Parse(koliko); i++)
{
    //flag = Alati.Uporedi(pom2, broj2);
    while (Alati.Uporedi(pom2, broj2) == 1)
    {
        flag = 1;
        pom2 = Operacije.Oduzmi(pom2, broj2);
        br1++;
    }
    if (flag == 0)
    {
        rez[brojac] = 0;
    }
    else
    { rez[brojac] = br1; }
    pom1 = pom2;
    flag = 0;
    brojac++;
    brkol++;
    br1 = 0;
    pom1 = Alati.SkloniNule(pom1);
    if (brkol == ispis1.Length)
    {
        rez[brojac] = '.';
        brojac++;
    }
    if (brkol >= ispis1.Length)
    {

        pom1 = pom1 + '0';
        pom2 = pom1;
        if (brkol == ispis1.Length + int.Parse(koliko))
        {
            break;
        }
    }
    else
    {
        pom1 = pom1 + ispis1[brkol];
        pom2 = pom1;
    }
}
int brr = 0;
for (j = 0; j < 260; j++)
{
    if (rez[j] != -1)
    {
        brr++;
    }
}

for (i = 0; i < brr; i++)
{
    if (rez[i] == 46)
    {
        ispis3 = ispis3 + '.';
    }
    else ispis3 = ispis3 + int.Parse(rez[i].ToString());
}

    if (minus == 1)
            {
                ispis3 = '-' + ispis3;
            }
return ispis3;
        }
    }
}
