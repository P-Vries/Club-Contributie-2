using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubContributie_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        //Methodes
        //

        private void Bereken(int Aantalsporten)
        {
            int leeftijd = DateTime.Now.Year - dateTimePicker1.Value.Year;
            int lidmaatschap = DateTime.Now.Year - dateTimePicker2.Value.Year;
            double uit = 40;
            //Basis
            if (Aantalsporten <= 4)
            {if (Aantalsporten < 2)
                {
                    uit += Aantalsporten * 22;
                }
                else uit += 25 * Aantalsporten;
            }
            if (Aantalsporten >= 5) uit += Aantalsporten * 20;

            //Kortingen
            //Leeftijd
            if (leeftijd < 18 || leeftijd > 40) uit = (uit / 100) * 90;
            //Lidmaatschap
            if (lidmaatschap >= 5) uit = (uit / 100) * 95;
            MessageBox.Show("U moet nog €" + uit + " betalen");

        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            Bereken(int.Parse(txbIn.Text));
        }
    }
}
