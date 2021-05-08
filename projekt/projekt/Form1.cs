using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
                
        }

        class szamla
        {
            public static string[] tulajdonosok = { "Károly", "Magdolna", "Gizella", "Ákos", "Sándor" };
            public static int[] szamlak = { 5000, 20000, 666, 1000, 40000 };
            public static int szamlalo = 0;


            public static int osszeg;
            public static int jelenlegi_osszeg;
            
            
            public static int feltoltes(int feltoltes_utani_osszeg)
            {
                feltoltes_utani_osszeg = osszeg + jelenlegi_osszeg;
                return feltoltes_utani_osszeg;
            }

            public static int kivetel(int kivetel_utani_osszeg)
            {
                kivetel_utani_osszeg = jelenlegi_osszeg-osszeg;
                return kivetel_utani_osszeg;
            }
            public static int utalas_levetel(int utalas_utani_osszeg)
            {
                utalas_utani_osszeg = jelenlegi_osszeg - osszeg;
                return utalas_utani_osszeg;
                
            }
            public static int utalas_feltoltes(int utalas_utani_osszeg)
            {
                utalas_utani_osszeg = jelenlegi_osszeg + osszeg;
                return utalas_utani_osszeg;

            }





        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(szamla.szamlalo==4)
            {
                szamla.szamlalo = 0;
            }
            textBox1.Text=szamla.tulajdonosok[szamla.szamlalo];
            textBox2.Text = Convert.ToString(szamla.szamlak[szamla.szamlalo]);
            szamla.szamlalo++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            if (szamla.szamlalo == 4)
            {
                szamla.szamlalo = 0;
            }
            textBox3.Text = szamla.tulajdonosok[szamla.szamlalo];
            textBox4.Text = Convert.ToString(szamla.szamlak[szamla.szamlalo]);
            szamla.szamlalo++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox5.Text)<0)
            {
                MessageBox.Show("A szám nem lehet negatív!");
            }
            if (Convert.ToInt32(textBox5.Text) > (Convert.ToInt32(textBox2.Text)))
            {
                MessageBox.Show("Nincs elég pénz a számlán!");
            }

            szamla.osszeg = Convert.ToInt32(textBox5.Text);
            szamla.jelenlegi_osszeg= Convert.ToInt32(textBox2.Text);
            textBox2.Text = Convert.ToString(szamla.feltoltes(0));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox5.Text) < 0)
            {
                MessageBox.Show("A szám nem lehet negatív!");
            }
            if (Convert.ToInt32(textBox5.Text) > (Convert.ToInt32(textBox2.Text)))
            {
                MessageBox.Show("Nincs elég pénz a számlán!");
            }
            szamla.osszeg = Convert.ToInt32(textBox5.Text);
            szamla.jelenlegi_osszeg = Convert.ToInt32(textBox2.Text);
            textBox2.Text = Convert.ToString(szamla.kivetel(0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox5.Text) < 0)
            {
                MessageBox.Show("A szám nem lehet negatív!");
            }
            if (Convert.ToInt32(textBox5.Text) > (Convert.ToInt32(textBox2.Text)))
            {
                MessageBox.Show("Nincs elég pénz a számlán!");
            }
            szamla.osszeg = Convert.ToInt32(textBox5.Text);
            szamla.jelenlegi_osszeg = Convert.ToInt32(textBox2.Text);
            textBox2.Text = Convert.ToString(szamla.utalas_levetel(0));
            szamla.jelenlegi_osszeg = Convert.ToInt32(textBox4.Text);
            textBox4.Text = Convert.ToString(szamla.utalas_feltoltes(0));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox6.Text) < 0)
            {
                MessageBox.Show("A szám nem lehet negatív!");
            }
            if (Convert.ToInt32(textBox6.Text) > (Convert.ToInt32(textBox4.Text)))
            {
                MessageBox.Show("Nincs elég pénz a számlán!");
            }
            szamla.osszeg = Convert.ToInt32(textBox6.Text);
            szamla.jelenlegi_osszeg = Convert.ToInt32(textBox4.Text);
            textBox4.Text = Convert.ToString(szamla.feltoltes(0));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox6.Text) < 0)
            {
                MessageBox.Show("A szám nem lehet negatív!");
            }
            if (Convert.ToInt32(textBox6.Text) > (Convert.ToInt32(textBox4.Text)))
            {
                MessageBox.Show("Nincs elég pénz a számlán!");
            }
            szamla.osszeg = Convert.ToInt32(textBox6.Text);
            szamla.jelenlegi_osszeg = Convert.ToInt32(textBox4.Text);
            textBox4.Text = Convert.ToString(szamla.utalas_levetel(0));
            szamla.jelenlegi_osszeg = Convert.ToInt32(textBox2.Text);
            textBox2.Text = Convert.ToString(szamla.utalas_feltoltes(0));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox6.Text) < 0)
            {
                MessageBox.Show("A szám nem lehet negatív!");
            }
            if (Convert.ToInt32(textBox6.Text) > (Convert.ToInt32(textBox4.Text)))
            {
                MessageBox.Show("Nincs elég pénz a számlán!");
            }
            szamla.osszeg = Convert.ToInt32(textBox6.Text);
            szamla.jelenlegi_osszeg = Convert.ToInt32(textBox4.Text);
            textBox4.Text = Convert.ToString(szamla.kivetel(0));
        }
    }
}
