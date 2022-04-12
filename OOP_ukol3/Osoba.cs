using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ukol3
{
    class Osoba
    {
        protected string jmeno { get; set; }
        protected string prijmeni { get; set; }
        protected int hmotnost;
        protected double vyska;

        public Osoba(string jmeno, string prijmeni, int hmotnost, double vyska)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            Hmotnost = hmotnost;
            Vyska = vyska;
        }

        public int Hmotnost
        {
            get
            {
                return hmotnost;
            }
            set
            {
                if (value < 0 || value > 300)
                {
                    MessageBox.Show("Hmotnost mimo rozsah!", "Error");
                }
                else
                {
                    hmotnost = value;
                }
            }
        }

        public double Vyska
        {
            get
            {
                return vyska;
            }
            set
            {
                if (value > 2.7)
                {
                    value /= 100;
                }
                if (value >= 0.6 && value <= 2.7)   //0.6m - nejmenší člověk světa
                {                                   //2.7m - nejvyšší člověk světa
                    vyska = value;
                }
                else
                {
                    MessageBox.Show("Výška mimo rozsah!", "Error");
                }
            }
        }

        public double BMI()
        {
            return Math.Round((hmotnost / (vyska * vyska)), 2);
        }

        public override string ToString()
        {
            return String.Format("Osoba {0} {1}, která je vysoká {2} m a váží {3} kg, má BMI {4}", jmeno, prijmeni, vyska, hmotnost, BMI());
        }
    }
}
