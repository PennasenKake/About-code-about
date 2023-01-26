using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Kaksinpeli_vaikea : Form
    {
        Label ekaKlikkaus = null;
        Label tokaKlikkaus = null;
        int arvaukset = 0;
        int kulunutaika = 0;
        int pareja;
        string player1 = "Pelaaja1"; // pelaaja nro 1 
        string player2 = "Pelaaja2"; //pejaaja nro 2
        int player1Pisteet = 0;
        int player2Pisteet = 0;
        string nykyinenPelajaa;

        Random r = new Random();

        public Kaksinpeli_vaikea()
        {
            InitializeComponent();
            MaaritaKuvat();

            nykyinenPelajaa = "player1";
        }

        List<string> merkit = new List<string>()
        {
            "h", "h", "l", "l", "Y", "Y",
            "!", "!", "b", "b", "N", "N",

            "j", "j", "J", "J", "P", "P",
            "v", "v", ",", ",", "$", "$",

            "E", "E", "~", "~", "o", "o",
            "m", "m", "N", "N", "M", "M",

        };

        private void MaaritaKuvat()
        {
            foreach (Control control in tlbTaulu.Controls)
            {
                Label merkkilabeli = control as Label;
                if (merkkilabeli != null)
                {
                    int randomR = r.Next(merkit.Count);
                    merkkilabeli.Text = merkit[randomR];
                    merkit.RemoveAt(randomR);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (tmrKuva.Enabled == true)
                return;

            Label klikattuLabeli = sender as Label;

            if (klikattuLabeli != null)
            {
                if (klikattuLabeli.ForeColor == Color.Black)
                    return;

                if (ekaKlikkaus == null)
                {
                    tmrAika.Start();
                    ekaKlikkaus = klikattuLabeli;
                    ekaKlikkaus.ForeColor = Color.Black;
                    return;
                }

                tokaKlikkaus = klikattuLabeli;
                tokaKlikkaus.ForeColor = Color.Black;

                if (ekaKlikkaus.Text == tokaKlikkaus.Text)
                {
                    pareja++;
                    ekaKlikkaus = null;
                    tokaKlikkaus = null;
                    player1Pisteet = arvaukset++;
                    player2Pisteet = arvaukset++;
                    return;
                }
                tmrKuva.Start();
            }

            if (tsslbVuoro!= null)
                tsslbVuoro.Text = "Vuoro: " + nykyinenPelajaa;
        }

        private void voitto()
        {
            foreach (Control control in tlbTaulu.Controls)
            {
                Label merkkilabeli = control as Label;

                if (merkkilabeli != null)
                {
                    if (merkkilabeli.ForeColor == merkkilabeli.BackColor)
                        return;
                }
            }

            MessageBox.Show("JEE");
        }


        private void tmrAika_Tick_1(object sender, EventArgs e)
        {
            kulunutaika++;
            tsslbKulunutAika.Text = "Kulunut aika:" + kulunutaika.ToString();

            if (pareja == 18)
            {
                tmrAika.Stop();

                string voittaja = player1Pisteet > player2Pisteet ? player1 : player2;
                int pisteet = Math.Max(player1Pisteet, player2Pisteet);
                MessageBox.Show($"Voittaja on {voittaja} pistein {pisteet}!");
            }

        }

        private void tmrKuva_Tick(object sender, EventArgs e)
        {
            tmrKuva.Stop();

            ekaKlikkaus.ForeColor = ekaKlikkaus.BackColor;
            tokaKlikkaus.ForeColor = tokaKlikkaus.BackColor;

            ekaKlikkaus = null;
            tokaKlikkaus = null;

            if (nykyinenPelajaa == player1)
            {
                nykyinenPelajaa = player2;
            }
            else
            {
                nykyinenPelajaa = player1;
            }

            tsslbVuoro.Text = "Vuoro: " + nykyinenPelajaa;

        }

        private void tsbSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        } // sulkee kyseisen formin

        private void Kaksinpeli_vaikea_Load(object sender, EventArgs e)
        {

        }
    }
}
