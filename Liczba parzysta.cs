
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Liczba_parzysta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sprawdź_Click(object sender, EventArgs e)
        {
            int liczba = int.Parse(Liczba.Text);
            if (liczba % 2 == 0)
                wynik.Text = "Liczba " + liczba + " jest liczbą parzystą";
            else
                wynik.Text = "Liczba " + liczba + " nie jest liczbą parzystą";
        }
    }
}
