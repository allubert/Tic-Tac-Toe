using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ristinolla_Harjoitustyo
{
    public struct Henkilo
    {
        public string etunimi;
        public string sukunimi;
        public int syntymavuosi;
    }
    public partial class frmAloitus : Form
    {
        public frmAloitus()
        {
            InitializeComponent();
        }

        private void btnPelaaja2_Click(object sender, EventArgs e)
        {
            //Tekee toisen pelaajan syöttökentistä näkyvät.

            lblPelaaja2.Visible = true;
            tbEtu2.Visible = true;
            tbSuku2.Visible = true;
            tbSyntvuosi2.Visible = true;
            btnTallenna2.Visible = true;
            btnHae2.Visible = true;

        }

        private void btnTallenna1_Click(object sender, EventArgs e)
        {
            Button btnTallenna = (Button)sender;

            Henkilo h1, h2;
            h1.etunimi = tbEtu1.Text;
            h1.sukunimi = tbSuku1.Text;
            h1.syntymavuosi = int.Parse(tbSyntvuosi.Text);

            h2.etunimi = tbEtu2.Text;
            h2.sukunimi = tbSuku2.Text;
            h2.syntymavuosi = int.Parse(tbSyntvuosi2.Text);

            if (btnHae1.Enabled == false || btnHae2.Enabled == false)
            {
                btnHae1.Enabled = true;
                btnHae2.Enabled = true;
            }

            //Tallentaa tiedostoon pelaaja 1 kysytyt tiedot.
            StreamWriter sw = new StreamWriter("Pelaajat.txt");
            //sw.WriteLine(tb.Text, tb.Text, tb.Text); "tb not found" piti poistaa ei antanut debuggaa muuten
            sw.Close();
        }

        private void tbEtu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //etunimi kenttään ei voi syöttää muuta kun kirjaimia
            TextBox tb = (TextBox)sender;

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnTietokone_Click(object sender, EventArgs e)
        {
            //Jos valitaan tietokone vastustajaksi, toisen pelaajan syötettävät tiedot eivät tule näkyviin.
            lblPelaaja2.Visible = false;
            tbEtu2.Visible = false;
            tbSuku2.Visible = false;
            tbSyntvuosi2.Visible = false;
            btnTallenna2.Visible = false;
            btnHae2.Visible = false;
        }

        private void btnHae1_Click(object sender, EventArgs e)
        {

        }

        private void tbSyntvuosi_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            tb.MaxLength = 4;
        }

        private void tbSyntvuosi_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int vuosi = int.Parse(tb.Text);

            if (vuosi > 2022)
            {
                tb.Text = "2022";
            }
            else if (vuosi < 1920)
            {
                tb.Text = "1920";
            }
        }

        private void btnAloita_Click(object sender, EventArgs e)
        {
            Ristinolla rs = new Ristinolla();
            rs.Show();
        }

        private void saannotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ristinolla on kahden pelaajan peli. Tässä versiossa on 3x3 ruudun pelilauta, johon kumpikin pelaaja piirtää vuoron perään oman merkkinsä, ristin tai ympyrän. Tavoitteena on saada kolme omaa merkkiä samalle pysty-, vaaka- tai vinoriville. Peli päättyy aina tasapeliin, jos kumpikaan pelaaja ei siinä onnistu.", "Ristinollan säännöt");
        }
    }
}
