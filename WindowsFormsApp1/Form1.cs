using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //zarez tj decimala - 3/4
        //sabiranje radi samo ne radi ako su brojevi 9 + 6 = 15, popraviti SabiranjeV - topp
        // negativni broj na - (ako je prazan string nappisi - i tjt), sabiranje ako 1 sabirak ima - topp
        // popraviti oduzimanje tako sto se zamene samo br1 i br 2 pa se ispred stavi - topp
        //staviti bolju pozainu
        //uraditi deljenje i mnozenje V - 1/2
        //ostatak pri deljenju rimskih - topp
        //procedura koja sklanja 0 sa pocetka - topp
        //funkcija uporedi 2 broja - topp
        // napraviti metodu (substring) koja sklanja nule sa pocetka broja - topp (trebalo bi)
        
        public int z, j, i, konacan, r, d;

        public int rez, br1, br2, pom1, pom2, pom22, pom33, pom3, pom4, pobednik;
        public int smanji, smanji2, operacija, b, br, veci, obrnuto, os, pok, pok2;
        public int[] niz;
        public string[] nizbr;
        public string pr, dr;
        public int op = 0;
        public int p = 0;
        public string [] glniz = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

public Form1()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            unos.ReadOnly = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ispis_TextChanged(object sender, EventArgs e)
        {
            //ispis.Size = new System.Drawing.Size(352, 71);

        }

        private void unos_TextChanged(object sender, EventArgs e)
        {
            //unos.ReadOnly = false;  
        }

        private void ok(object sender, EventArgs e)
        {
           
            // necu koristiti ovaj nacin nego cu napraviti niz od 1 do n koji je ispunje brojevima 100,90,50... i 
            // bice 1 for petlja koja prolazi i oduzima i zapisuje ako moze da se oduzme(to je malo bar pametniji nacin)

            niz = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            nizbr = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            groupBox2.Visible = false;
            b = 1;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;

            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            label1.BackColor =label5.BackColor;
            label2.BackColor =label5.BackColor;
            label3.BackColor =label5.BackColor;
            label4.BackColor =label5.BackColor;
            if (button19.Visible == false)
            {
                groupBox1.BackgroundImage = button32.BackgroundImage;
            }
            button31.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (op == 1)
            {
                unos2.Text = unos2.Text + "1";
            }
            else unos.Text = unos.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + "2";
            }
            else unos.Text = unos.Text + "2";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + '3';
            }
            else unos.Text = unos.Text + '3';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + '4';
            }
            else unos.Text = unos.Text + '4';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + '5';
            }
            else unos.Text = unos.Text + '5';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + '6';
            }
            else unos.Text = unos.Text + '6';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + '7';
            }
            else unos.Text = unos.Text + '7';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + '8';
            }
            else unos.Text = unos.Text + '8';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + '9';
            }
            else unos.Text = unos.Text + '9';
        }

        private void button32_Click(object sender, EventArgs e)
        {
            
            string broj1 = unos.Text;
            //string broj1 = "1554648787452213352698956";  
            string broj2 = unos2.Text;
            //string broj2 = "427483257872236598638963";

            string rezzzz = Operacije.Mnozenje(broj1, broj2);

            ispis.Text = ( rezzzz);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int i, j;
            string ispis1 = "";
            int[] rez = new int[260];
            string ulazniString1 = unos.Text;
            int brKaraktera = ulazniString1.Length;
            int[] pariz = new int[260];
            string ispis2 = "";
            string ispis3 = "";
            string ulazniString2 = unos2.Text;
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
            if (textBox1.Text == "")
            {
                MessageBox.Show("niste uneli na koliko decimala da se zaokruzi resenje");
            }
            for (i = 0; i < 260; i++)
            {
                rez[i] = -1;
            }

            for (i = brKaraktera - 1; i >= 0; i--)
            {
                if (ulazniString1[i] == '.')
                {
                    pok = broj09;
                    break;
                }
                broj09++;

            }
            for (j = brKaraktera2 - 1; j >= 0; j--)
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
            if (pok >= pok2 && (pok > 0 || pok2 > 0))
            {
                flag = 1;
                for(i = 0; i < ulazniString1.Length + pok - pok2; i++)
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
            }
            else
            {
                if (pok2 > pok)
                {
                    flag = 1;
                    for (i = 0; i < ulazniString2.Length + pok2 - pok; i++)
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
            int koliko = int.Parse(textBox1.Text);
            // prebacili smo iz textBox-a u niz
            // ako ima tacku na prvom tacka - 1 ako je na 2 ond tacka + 1
            for ( i = 0; i < ispis2.Length; i++)
            {
                broj1 = broj1 + ispis1[i];
                broj2 = broj2 + ispis2[i];
            }
            int brkol = ispis2.Length - 1;
            pom1 = broj1;
            pom2 = pom1;
            int brojac = 0;
            flag = 0;
            for (i = ispis2.Length - 1; i < ispis1.Length + koliko; i++)
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
                    if (brkol == ispis1.Length + koliko)
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
            
            ispis.Text = ispis3 ;



            //ispis.Text = Alati.Uporedi(unos.Text, unos2.Text).ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + '0';
            }
            else unos.Text = unos.Text + '0';
        }

        private void C_dugme(object sender, EventArgs e)
        {
            unos.Text = "";
            ispis.Text = "";
            unos2.Text = "";
            op = 0;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + ".";
            }
            else unos.Text = unos.Text + ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + "I";
            }
            else unos.Text = unos.Text + "I";

        }

        private void del(object sender, EventArgs e)
        {
            int pomoc;
            string pomoc1;
            if (op == 1)
            {
                pomoc1 = "";
                pomoc = unos2.TextLength - 1;
                for (int i = 0; i < pomoc; i++)
                {
                    pomoc1 = pomoc1 + unos2.Text[i];
                }
                unos2.Text = pomoc1;
            }
            else
            {
               pomoc1 = "";
               pomoc = unos.TextLength - 1;
               for (int i = 0; i < pomoc; i++)
               {
                    pomoc1 = pomoc1 + unos.Text[i];
               }
                unos.Text = pomoc1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            //ispis.Text = (5 % 3).ToString();
            //ispis.Text = (int.Parse(unos.Text) % int.Parse(unos2.Text)).ToString();
            int i, j, id;
            ispis.Text = "";
            string ispis1 = "";
            int[] rez = new int[260];
            string ulazniString1 = unos.Text;
            int brKaraktera = ulazniString1.Length;
            int[] pariz = new int[260];
            string ispis2 = "";
            string ispis3 = "";
            string ulazniString2 = unos2.Text;
            int brKaraktera2 = ulazniString2.Length;
            int[] drniz = new int[260];
            int[] drniz1 = new int[260];
            int broj = 0;
            int brojj = 0;
            for (i = 0; i < 260; i++)
            {
                rez[i] = -1;
            }
            for (i = 0; i < 260; i++)
            {
                pariz[i] = -1;
            }

            for (i = brKaraktera - 1; i >= 0; i--)
            {
                if (ulazniString1[i] == '.')
                {
                    pok = broj;
                    break;
                }
                broj++;

            }
            for (j = brKaraktera2 - 1; j >= 0; j--)
            {
                if (ulazniString2[j] == '.')
                {
                    pok2 = brojj;
                    break;
                    
                }
                brojj++;

            }
            if (pok >= pok2)
            {
                for (i = brKaraktera2 + 1; i <= brKaraktera; i++)
                {
                    ulazniString2 = ulazniString2 + '0';
                    
                }
                pobednik = pok;
            }
            else
            {
                for (i = brKaraktera + 1; i <= brKaraktera2; i++)
                {
                    ulazniString1 = ulazniString1 + '0';

                }
                //ulazniString1 += "7";
                pobednik = pok2;
            }
            if (brKaraktera > brKaraktera2)
            {
                id = brKaraktera;
            }
            else id = brKaraktera2;
            //obrtanje
            for (i = brKaraktera2 - 1; i >= 0; i--)
            {
                if (ulazniString1[i] == '.')
                {
                    continue;
                }
                else
                {
                    
                    if (ulazniString1[i] == '0')
                    {
                        ispis1 = (ispis1 + '0');
                    }
                    ispis1 = ispis1 + ulazniString1[i];
                   
                }
            }
            
            for (i = 0; i < brKaraktera2 - 1; i++)
            {
                if (int.TryParse(ispis1[i].ToString(), out int brojjj))
                {
                    pariz[i] = brojjj;

                }
                
            }


            for (i = brKaraktera2 - 1; i >= 0; i--)
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
                /*
            for (i = brKaraktera2 - 1; i >= 0; i--)
            {
                ispis2 = ispis2 + ulazniString2[i];
            }
                */
                ispis.Text = ispis2;
                for (i = 0; i < id - 1; i++)
                {
                    if (int.TryParse(ispis2[i].ToString(), out int broj1))
                    {
                        drniz[i] = broj1;

                    }
                }
                //for 
                /*
                for (i = brKaraktera - 1 ; i >= 0; i--)
                {
                    if (ulazniString1[i] != '.')
                    {
                        pariz[brKaraktera - i + 1] = int.Parse(ulazniString1[i - 1].ToString());
                        ispis1 = ispis1 + int.Parse(pariz[brKaraktera - i].ToString());
                    }
                    else MessageBox.Show("ima");
                }
                */
                /*
                for (i = brKaraktera2; i > 0; i--)
                {
                if (ulazniString2[i] != '.')
                {
                    drniz[brKaraktera2 - i] = int.Parse(ulazniString2[i - 1].ToString());
                    ispis2 = ispis2 + int.Parse(drniz[brKaraktera2 - i].ToString());
                }
                }
                */
                if (brKaraktera >= brKaraktera2)
                {
                    for (i = 0; i < brKaraktera - 1; i++)
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
                    for (i = 0; i < brKaraktera2 - 1; i++)
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

                /*
                for (i = 0; i < brKaraktera2; i++)
                {
                    veci = pariz[i] + drniz[i];
                    if (veci >= 10)
                    {
                        rez[i] = (pariz[i] + drniz[i]) - 10;
                        pariz[i + 1] = pariz[i + 1] + 1;
                    }
                    else rez[i] = pariz[i] + drniz[i];
                }
                */
                //for (i = rez)
                br = 0;
                for (j = 0; j < 260; j++)
                {

                    if (rez[j] != -1)
                    {
                        br++;
                    }
                }
                if (pobednik > 0)
                {
                    for (i = br; i >= pobednik; i--)
                    {
                        rez[i + 1] = rez[i];

                    }
                    rez[pobednik] = '.';
                    for (i = br; i >= 0; i--)
                    {
                        if (rez[i] == '.')
                        {
                            ispis3 = ispis3 + '.';
                        }
                        else ispis3 = ispis3 + int.Parse(rez[i].ToString());
                    }
                }
                else
                {
                    for (i = br - 1; i >= 0; i--)
                    {
                        ispis3 = ispis3 + int.Parse(rez[i].ToString());
                    }
                }

                ispis.Text = ispis3.ToString();

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void Rimski(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button31.Visible = false;
            textBox1.Visible = false;
            label4.Visible = false;
            label1.BackColor = label6.BackColor;
            label2.BackColor = label6.BackColor;
            label3.BackColor = label6.BackColor;
            label4.BackColor = label6.BackColor;
            if (button19.Visible == true)
            {
                groupBox1.BackgroundImage = button30.BackgroundImage;
            }
            
            b = 2;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            unos.Text = "";
            ispis.Text = "";
            unos2.Text = "";
            op = 0;
            operacija = 0;
        }

        private void jednako(object sender, EventArgs e)
        {
            
            if (operacija == 1)
            {
                int i, j;
                ispis.Text = "";
                int[] rez = new int[260];
                string ulazniString1 = unos.Text;
                int brKaraktera = ulazniString1.Length;
                int[] pariz = new int[260];
                string ulazniString2 = unos2.Text;
                int brKaraktera2 = ulazniString2.Length;
                int[] drniz = new int[260];
                int[] drniz1 = new int[260];
                int broj = 0;
                int brojj = 0;
                int pok = 0;
                int pok2 = 0;
                string p;
                for (i = brKaraktera - 1; i >= 0; i--)
                {
                    if (ulazniString1[i] == '.')
                    {
                        pok = broj;
                        break;
                    }
                    broj++;

                }
                for (j = brKaraktera2 - 1; j >= 0; j--)
                {
                    if (ulazniString2[j] == '.')
                    {
                        pok2 = brojj;
                        break;

                    }
                    brojj++;

                }
                if (pok > 0 || pok2 > 0 )
                {
                    if ((unos.Text[0] == '-') || (unos2.Text[0] == '-'))
                    {
                        if (unos.Text[0] == '-')
                        {
                           
                            int flag = 0;
                            if ((unos.Text[0] == '-') && (unos2.Text[0] == '-'))
                            {
                                
                                if (ulazniString1[0] == '-')
                                {
                                    brKaraktera--;
                                    ulazniString1 = ulazniString1.Substring(1);
                                }
                                if (ulazniString2[0] == '-')
                                {
                                    brKaraktera2--;
                                    ulazniString2 = ulazniString2.Substring(1);
                                }
                                

                                flag = 1;
                                ispis.Text = '-' + Operacije.Sabiranjedec(ulazniString1, ulazniString2, pok, pok2);
                                //ispis.Text = '-' + Alati.SkloniNule(p); ne vracaj
                            }
                            //string pomocni = "";
                            if (ulazniString1[0] == '-' && flag == 0)
                            {
                               
                                ulazniString1 = ulazniString1.Substring(1);
                                
                            }
                            int uporedi;
                            uporedi = Alati.Uporedi(ulazniString1, ulazniString2);
                            if (uporedi == 1 && flag == 0)
                            {
                                p = Operacije.Oduzmidec(ulazniString1, ulazniString2);
                                ispis.Text = '-' + Alati.SkloniNule(p);
                            }
                            else
                            {
                                if (flag == 0)
                                {
                                    p = Operacije.Oduzmidec(ulazniString2, ulazniString1);
                                    ispis.Text = Alati.SkloniNule(p);
                                }
                            }
                        }  
                        else
                        {
                            if (ulazniString2[0] == '-')
                            {
                                ulazniString2 = ulazniString2.Substring(1);
                            }
                            int uporedi;
                            uporedi = Alati.Uporedi(ulazniString1, ulazniString2);
                            if (uporedi == 1)
                            {
                                ispis.Text = Operacije.Oduzmidec(ulazniString1, ulazniString2);
                            }
                            else
                            {
                                ispis.Text = '-' + Operacije.Oduzmidec(ulazniString2, ulazniString1);
                            }
                           
                        }
                    }
                    else
                    {
                        ispis.Text = Operacije.Sabiranjedec(unos.Text, unos2.Text, pok, pok2);
                    }
                    
                }
                else
                {
                    if (unos.Text[0] == '-' )
                    {
                        ulazniString1 = ulazniString1.Substring(1);
                        ispis.Text = Operacije.Oduzmi(ulazniString2, ulazniString1);
                        //ispis.Text = Alati.SkloniNule(p); ne vracaj
                    }
                    if (unos2.Text[0] == '-')
                    {
                        ulazniString2 = ulazniString2.Substring(1);
                        ispis.Text = Operacije.Oduzmi(ulazniString1, ulazniString2);
                        //ispis.Text = Alati.SkloniNule(p); ne vracaj
                    }
                    if ((unos.Text[0] != '-') && (unos2.Text[0] != '-') )
                    {
                        ispis.Text = Operacije.Saberi(unos.Text, unos2.Text);
                    }
                    if ((unos.Text[0] == '-') && (unos2.Text[0] == '-'))
                    {
                        //ulazniString1 = ulazniString1.Substring(1);
                        //ulazniString2 = ulazniString2.Substring(1);
                        ispis.Text = '-' + Operacije.Saberi(ulazniString1, ulazniString2);
                        //ispis.Text = Alati.SkloniNule(p); ne radi 
                    }
                }
            }


            //ako je 1 broj duzi znaci da je veci sem u negativnim brojevima, al oba moraju da idu do duzeg niza
            //jer je popunjen sa -1 tkd ce sve biti ok; 

            if (operacija == 2)
            {
                ispis.Text = "";
                int[] rez = new int[260];
                string ulazniString1 = unos.Text;
                int brKaraktera = ulazniString1.Length;
                int[] pariz = new int[260];
                string ulazniString2 = unos2.Text;
                int brKaraktera2 = ulazniString2.Length;
                int[] drniz = new int[260];
                int[] drniz1 = new int[260];
                int broj = 0;
                int brojj = 0;
                int pok = 0;
                int pok2 = 0;
                string p = "";
                for (i = brKaraktera - 1; i >= 0; i--)
                {
                    if (ulazniString1[i] == '.')
                    {
                        pok = broj;
                        break;
                    }
                    broj++;

                }
                for (j = brKaraktera2 - 1; j >= 0; j--)
                {
                    if (ulazniString2[j] == '.')
                    {
                        pok2 = brojj;
                        break;

                    }
                    brojj++;

                }
                if (pok > 0 || pok2 > 0)
                {
                    if ((unos.Text[0] == '-') || (unos2.Text[0] == '-'))
                    {
                        if (unos.Text[0] == '-')
                        {
                            
                            int flag = 0;
                            brKaraktera--;
                            if ((unos.Text[0] == '-') && (unos2.Text[0] == '-'))
                            {
                                flag = 1;
                                brKaraktera--;
                                ulazniString1 = Alati.SkloniMinus(unos.Text);
                                brKaraktera2--;
                                ulazniString2 = Alati.SkloniMinus(unos2.Text);
                                int uporedi;
                                uporedi = Alati.Uporedi(ulazniString1, ulazniString2);
                                if (uporedi == 1)
                                { 
                                    p = Operacije.Oduzmidec(ulazniString1, ulazniString2);
                                    ispis.Text = Alati.SkloniNule(p);
                                }
                                else
                                {
                                    p = Operacije.Oduzmidec(ulazniString2, ulazniString1);
                                    ispis.Text = '-' + Alati.SkloniNule(p);
                                }

                            }
                            //string pomocni = "";
                            if (ulazniString1[0] == '-' && flag == 0)
                            {
                                brKaraktera--;
                                ulazniString1 = Alati.SkloniMinus(unos.Text);
                                p = Operacije.Sabiranjedec(ulazniString1, unos2.Text, pok, pok2);
                                ispis.Text = '-' + Alati.SkloniNule(p);

                            }
                            else
                            {
                                if (flag == 0)
                                {
                                    brKaraktera2--;
                                    ulazniString2 = Alati.SkloniMinus(unos2.Text);
                                    p =  Operacije.Sabiranjedec(unos.Text, ulazniString2, pok, pok2);
                                    ispis.Text = '-' + Alati.SkloniNule(p);
                                }
                            }
                        }
                        else
                        {
                            brKaraktera2--;
                            ulazniString2 = Alati.SkloniMinus(unos2.Text);
                            ispis.Text = Operacije.Sabiranjedec(ulazniString1, ulazniString2, pok, pok2);
                            //ispis.Text = Alati.SkloniNule(p); - vec su skinute ai ne radi kad se stavi
                        }
                    }
                    else
                    {
                        string zed;
                        int uporedi;
                        //ulazniString2 = ulazniString2.Substring(1);
                        uporedi = Alati.Uporedi(ulazniString1, ulazniString2);
                        if (uporedi == 1)
                        {
                            zed = Operacije.Oduzmidec(ulazniString1, ulazniString2);
                            ispis.Text = zed;
                        }
                        else
                        {
                            zed = Operacije.Oduzmidec(ulazniString2,ulazniString1);
                            ispis.Text = '-' + zed;
                        }
                    }
                    
                }
                else
                {
                    if (unos.Text[0] == '-')
                    {
                        ispis.Text = "";
                        brKaraktera--;
                        ulazniString1 = Alati.SkloniMinus(unos.Text);
                        p = '-' + Operacije.Saberi(unos2.Text, ulazniString1);
                        ispis.Text = '-' + Alati.SkloniNule(p);

                    }
                    if (unos2.Text[0] == '-')
                    {
                        brKaraktera2--;
                        ulazniString2 = Alati.SkloniMinus(unos2.Text);
                        //p = Operacije.Saberi(unos.Text, ulazniString2);
                        p = '-' + Operacije.Saberi(unos.Text, ulazniString2);
                        ispis.Text = '-' + Alati.SkloniNule(p);
                    }
                    if ((unos.Text[0] != '-') && (unos2.Text[0] != '-'))
                    {
                        int uporedi;
                        uporedi = Alati.Uporedi(unos.Text, unos2.Text);
                        if (uporedi == 1)
                        {
                            //p = Operacije.Oduzmi(unos.Text, unos2.Text);
                            p = Operacije.Oduzmi(unos.Text, unos2.Text);
                            ispis.Text =  Alati.SkloniNule(p);
                        }
                        else
                        {
                            //p = Operacije.Oduzmi(unos2.Text, unos.Text);
                            p =  Operacije.Oduzmi(unos2.Text, unos.Text);
                            ispis.Text = '-' + Alati.SkloniNule(p);
                        }
                    }
                    if ((unos.Text[0] == '-') && (unos2.Text[0] == '-'))
                    {
                        brKaraktera--;
                        ulazniString1 = Alati.SkloniMinus(unos.Text);
                        brKaraktera2--;
                        ulazniString2 = Alati.SkloniMinus(unos2.Text);
                        int uporedi;
                        uporedi = Alati.Uporedi(ulazniString1, ulazniString2);
                        if (uporedi == 1)
                        { 
                            p = Operacije.Oduzmi(ulazniString1, ulazniString2);
                            ispis.Text = '-' + Alati.SkloniNule(p);
                        }
                        else
                        {
                            p = Operacije.Oduzmi(ulazniString2, ulazniString1);
                            ispis.Text =  Alati.SkloniNule(p);
                        }
                    }
                }
            }

            if (operacija == 3)
            {
                string broj1 = unos.Text;
                string broj2 = unos2.Text;
                string rezzzz = Operacije.Mnozenje(broj1, broj2);

                ispis.Text = (rezzzz);
            }

            if (operacija == 4)
            {
                if (unos.TextLength < unos2.TextLength && ((unos.Text.Contains(".")  || unos2.Text.Contains(".")) || (unos.Text.Contains(".") && unos2.Text.Contains("."))))
                {
                    string broj1 = unos.Text;
                    string broj2 = unos2.Text;
                    string koliko = textBox1.Text;
                    if (broj2 == "0")
                    {
                        MessageBox.Show("Ne sme da se deli sa 0");
                    }
                    else 
                    { 
                        if(int.Parse(koliko) > 20)
                        {
                            MessageBox.Show("sledeci put stavite manje decimala");
                        }
                    string rezzzz = Operacije.Deljenje(broj1, broj2, koliko);
                    ispis.Text = (rezzzz);
                    }

                }
                else 
                {

                    int i, j;
                    string ispis1 = "";
                    int[] rez = new int[260];
                    string ulazniString1 = unos.Text;
                    int brKaraktera = ulazniString1.Length;
                    int[] pariz = new int[260];
                    string ispis2 = "";
                    string ispis3 = "";
                    string ulazniString2 = unos2.Text;
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
                    int koliko = 0;
                    if (ulazniString2 == "0")
                    {
                        MessageBox.Show("Ne sme da se deli sa 0");

                    }
                    else
                    {
                        if (koliko > 20)
                        {
                            MessageBox.Show("sledeci put stavite manje decimala");
                        }

                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("niste uneli na koliko decimala da se zaokruzi resenje");
                            koliko = 1;
                        }
                        else { koliko = int.Parse(textBox1.Text); }
                        int minus = 0;

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


                        for (i = 0; i < 260; i++)
                        {
                            rez[i] = -1;
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
                        if (pok >= pok2 && (pok > 0 || pok2 > 0))
                        {
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
                        }
                        else
                        {
                            if (pok2 > pok)
                            {
                                flag = 1;
                                for (i = 0; i < ulazniString2.Length + pok2 - pok; i++)
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
                            if (i + 1 <= ispis1.Length)
                            {
                                broj1 = broj1 + ispis1[i];
                            }
                            broj2 = broj2 + ispis2[i];
                        }
                        int brkol = ispis2.Length - 1;
                        pom1 = broj1;
                        pom2 = pom1;
                        int brojac = 0;
                        flag = 0;
                        int proveraa = 0;
                        for (i = ispis2.Length - 1; i < ispis1.Length + koliko; i++)
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
                            if (brkol > ispis1.Length && proveraa == 0)
                            {
                                rez[brojac] = '.';
                                brojac++;
                                proveraa = 1;

                            }
                            if (brkol == ispis1.Length && proveraa == 0)
                            {
                                rez[brojac] = '.';
                                brojac++;
                                proveraa = 1;
                            }
                            if (brkol >= ispis1.Length)
                            {

                                pom1 = pom1 + '0';
                                pom2 = pom1;
                                if (brkol == ispis1.Length + koliko)
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
                        ispis.Text = ispis3;
                    }

                }
            }



        }

        private void button26_Click(object sender, EventArgs e)
        {
            int minus1 = 0;
            string ostatak = "";
            d = Alati.RuA(unos2.Text);
            if (operacija == 1)
            {
                pom1 = p + d;
                if (pom1 == 0)
                {
                    MessageBox.Show(" 0 ne postoji u rimskim brojevima");
                }
                ispis.Text = pom1.ToString();
            }
            if (operacija == 2)
            {
                pom2 = p - d;
                if (pom2 == 0)
                {
                    MessageBox.Show(" 0 ne postoji u rimskim brojevima");
                }
                if (pom2 < 0)
                {
                    pom22 = d - p;
                    ispis.Text = pom22.ToString();
                    minus1 = 1;
                }
                else ispis.Text = pom2.ToString();
            }
            if (operacija == 3)
            {
                pom3 = p * d;
                ispis.Text = pom3.ToString();
            }
            if (operacija == 4)
            {
                pom4 = p / d;
                ispis.Text = pom4.ToString();
                //ispis.Text = ispis.Text + "( ostatak je " + (p % d).ToString() + ")";
                os = p % d;
                //ostatak
            }
            if (int.TryParse(ispis.Text.ToString(), out int w))
            {
                z = w;
            }
            else
            {
                MessageBox.Show("unesite ceo broj");
            }

            if (minus1 == 1)
            {
                ispis.Text = "- ";
            }
            else ispis.Text = "";
            niz = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            nizbr = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (i = 0; i < 13; i++)
            {
                if ((z - niz[i]) >= 0)
                {
                    z = z - niz[i];
                    ispis.Text = ispis.Text + nizbr[i];
                    i--;
                }
            }
            for (j = 0; j < 13; j++)
            {
                if ((os - niz[j]) >= 0)
                {
                    os = os - niz[j];
                    ostatak = ostatak + nizbr[j];
                    j--;
                }
            }
            if (ostatak != "")
            {
                ispis.Text = ispis.Text + " ( ostatak je " + ostatak + " )";
            }
            string z1 = class1.Provera(unos.Text);
            if (z1 != unos.Text)
            {
                MessageBox.Show("Broj 1 nije ok");
            }
            string zz = class1.Provera(unos2.Text);
            if (zz != unos2.Text)
            {
                MessageBox.Show("Broj 2 nije ok");
            }
            string zzz = class1.Provera(ispis.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + "V";
            }
            else unos.Text = unos.Text + "V";
        }

        private void unos2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + "X";
            }
            else unos.Text = unos.Text + "X";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + "L";
            }
            else unos.Text = unos.Text + "L";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + "C";
            }
            else unos.Text = unos.Text + "C";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + "D";
            }
            else unos.Text = unos.Text + "D";
        }

        private void minus(object sender, EventArgs e)
        {
            int flag = 0;
            if ((unos.Text == ""))
            {
                unos.Text = "-";
                flag = 1;

            }
            if (flag == 0)
            {
                if (groupBox2.Visible == true)
                {
                    p = Alati.RuA(unos.Text);
                }
                
                op = 1;
                operacija = 2;
                pom2 = 0;
            }
            
        }

        private void puta(object sender, EventArgs e)
        {
            if (groupBox2.Visible == true)
            {
                p = Alati.RuA(unos.Text);
            }
            op = 1;
            operacija = 3;
            pom3 = 0;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                unos2.Text = unos2.Text + "M";
            }
            else unos.Text = unos.Text + "M";
        }

        private void plus(object sender, EventArgs e)
        {
            if (groupBox2.Visible == true)
            {
                p = Alati.RuA(unos.Text);
            }
            
            op = 1;
            operacija = 1;
            pom1 = 0;
        }

        private void podeljeno(object sender, EventArgs e)
        {
            if (button19.Visible == true)
            {
                p = Alati.RuA(unos.Text);
            }
            textBox1.Visible = true;
            op = 1;
            operacija = 4;
            pom4 = 0;
        }

        private void RuA(object sender, EventArgs e)
        {
            /*
            string y = class1.Provera(unos.Text);
            if (y != unos.Text)
            {
                MessageBox.Show("Broj nije ok");
            }
            else MessageBox.Show("SVE TOP");
            */
            //ispis.Text = Operacije.Sabiranjedec(unos.Text, unos2.Text, pok, pok2);
            ispis.Text = Alati.Uporedi(unos.Text, unos2.Text).ToString();
        }
    }
}
