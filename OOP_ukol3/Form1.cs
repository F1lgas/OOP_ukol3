using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ukol3
{
    public partial class Form1 : Form
    {
        Osoba osoba;
        Pacient pacient;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            osoba = new Osoba(textBox_jmeno.Text, textBox_prijmeni.Text, Convert.ToInt32(textBox_hmotnost.Text), Convert.ToDouble(textBox_vyska.Text));
            info.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(osoba.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pacient = new Pacient(textBox_jmeno2.Text, textBox_prijmeni2.Text, Convert.ToInt32(textBox_hmotnost2.Text), Convert.ToDouble(textBox_vyska2.Text), Convert.ToDouble(textBox_obvodpasu.Text));
            info2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pacient.ToString());
        }
    }
}