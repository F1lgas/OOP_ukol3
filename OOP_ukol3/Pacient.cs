using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ukol3
{
    class Pacient : Osoba
    {
        private double obvodPasu;

        public Pacient(string jmeno, string prijmeni, int hmotnost, double vyska, double obvodPasu) : base(jmeno, prijmeni, hmotnost, vyska)
        {
            ObvodPasu = obvodPasu;
        }

        public double ObvodPasu
        {
            get
            {
                return obvodPasu;
            }
            set
            {
                if (value > 1.5)
                {
                    value /= 100;
                }
                if (value >= 0.4 && value <= 1.5)   //0.4m - člověk s nejmenším obvodem pasu na světě
                {                                   
                    obvodPasu = value;
                }
                else
                {
                    MessageBox.Show("Obvod pasu mimo rozsah!", "Error");
                }
            }
        }

        public double ABSI()
        {
            return Math.Round(obvodPasu / (Math.Pow(BMI(), 0.6666667) * (Math.Pow(vyska, 0.5))), 4);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", \n má obvod pasu {0} m a ABSI {1}", obvodPasu, ABSI());
        }
    }
}
