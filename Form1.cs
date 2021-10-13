using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StapelOefening
{
    public partial class Form1 : Form
    {
        Stapel<int> intStapel = new Stapel<int>();
        Stapel<string> stringStapel = new Stapel<string>();
        Stapel<double> doubleStapel = new Stapel<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void uitInt_Click(object sender, EventArgs e)
        {
            intStapel.VanStapel();
            textBox.Text = intStapel.ToString();
        }

        

        private void uitString_Click(object sender, EventArgs e)
        {
            stringStapel.VanStapel();
            textBox.Text = stringStapel.ToString();
        }

        private void inString_Click(object sender, EventArgs e)
        {
            stringStapel.OpStapel(str.Text);


            textBox.Text = stringStapel.ToString();
            str.Text = "";
        }

        private void inInt_Click(object sender, EventArgs e)
        {
            int getal = Convert.ToInt32(str.Text);
            intStapel.OpStapel(getal);


            textBox.Text = intStapel.ToString();
            str.Text = "";
        }

        private void zoekInt_Click(object sender, EventArgs e)
        {
            int getal = Convert.ToInt32(str.Text);
            Boolean check = intStapel.ZitIn(getal);
            if (check)
            {
                zoekInt.BackColor = Color.Green;
            }
            else
            {
                zoekInt.BackColor = Color.Red;
            }
        }

        private void zoekString_Click(object sender, EventArgs e)
        {
            Boolean check = stringStapel.ZitIn(str.Text);
            if (check)
            {
                zoekString.BackColor = Color.Green;
               
            }
            else
            {
                zoekString.BackColor = Color.Red;

            }

        }

        private void kopieInt_Click(object sender, EventArgs e)
        {
            intStapel.Kopieer();
        }

        private void terugInt_Click(object sender, EventArgs e)
        {
            intStapel.terugzet();
            textBox.Text = intStapel.ToString();
        }
        private void toonIntKopie_Click(object sender, EventArgs e)
        {
            textBox.Text = intStapel.Copy();
        }
        private void stringKopie_Click(object sender, EventArgs e)
        {
            stringStapel.Kopieer();
        }

        private void terugString_Click(object sender, EventArgs e)
        {
            stringStapel.terugzet();
            textBox.Text = stringStapel.ToString();
            
        }

        private void ToonStringKopie_Click(object sender, EventArgs e)
        {
            textBox.Text = stringStapel.Copy();
        }

        private void inDouble_Click(object sender, EventArgs e)
        {
            double getal = Convert.ToDouble(str.Text);
            doubleStapel.OpStapel(getal);


            textBox.Text = doubleStapel.ToString();
            str.Text = "";
        }

        private void zoekdouble_Click(object sender, EventArgs e)
        {
            double getal = Convert.ToDouble(str.Text);
            Boolean check = doubleStapel.ZitIn(getal);
            if (check)
            {
                zoekdouble.BackColor = Color.Green;
            }
            else
            {
                zoekdouble.BackColor = Color.Red;
            }
        }

        private void uitDouble_Click(object sender, EventArgs e)
        {
            doubleStapel.VanStapel();
            textBox.Text = doubleStapel.ToString();
        }
        private void doubleKopie_Click(object sender, EventArgs e)
        {
            doubleStapel.Kopieer();
        }

        private void terugDouble_Click(object sender, EventArgs e)
        {
            doubleStapel.terugzet();
            textBox.Text = doubleStapel.ToString();
        }

        private void ToonDoubleKopie_Click(object sender, EventArgs e)
        {
            textBox.Text = doubleStapel.Copy();
        }

        private void doubleLeeg_Click(object sender, EventArgs e)
        {
            doubleStapel.Leegmaken();
            textBox.Text = "";

        }

        private void stringLeeg_Click(object sender, EventArgs e)
        {
            stringStapel.Leegmaken();
            textBox.Text = "";

        }

        private void intLeeg_Click(object sender, EventArgs e)
        {
            intStapel.Leegmaken();
            textBox.Text = "";
        }
    }
}
