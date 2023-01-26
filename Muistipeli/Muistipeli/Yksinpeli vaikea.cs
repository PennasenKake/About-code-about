using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Yksinpeli_vaikea : Form
    {
        Label ekaKlikkaus = null;
        Label tokaKlikkaus = null;
        int arvaukset = 0;
        int kulunutaika = 0;
        int pareja;

        Random r = new Random();


        List<string> merkit = new List<string>()
        {
            "h", "h", "l", "l", "Y", "Y", 
            "!", "!", "b", "b", "N", "N",

            "j", "j", "J", "J", "P", "P", 
            "v", "v", ",", ",", "$", "$",

          //  "E", "E", "~", "~", "o", "o",
          //  "A", "A", "k", "k", "M", "M",

          //  "@", "@", "U", "U", "W", "W", 
           // "m", "m", "&", "&", "-", "-",
        };

        private void MaaritaKuvat()
        {
            foreach (Control control in tlpTaulu.Controls)
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


        public Yksinpeli_vaikea()
        {
            InitializeComponent();
            MaaritaKuvat();

            string tiedostoPolku = @"C:\temp\yksinpeli_vaikea.txt";

            if (!File.Exists(tiedostoPolku))
            {
                using (File.Create(tiedostoPolku))
                {
                    // Tiedosto luotiin
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
                    arvaukset++;
                    ekaKlikkaus = klikattuLabeli;
                    ekaKlikkaus.ForeColor = Color.Black;
                    return;
                }

                tokaKlikkaus = klikattuLabeli;
                tokaKlikkaus.ForeColor = Color.Black;

                if (ekaKlikkaus.Text == tokaKlikkaus.Text)
                {
                    pareja++;
                    arvaukset++;
                    ekaKlikkaus = null;
                    tokaKlikkaus = null;
                    return;
                }
                tmrKuva.Start();
            }

            if (sslbArvaukset != null)
                sslbArvaukset.Text = "Arvaukset: " + arvaukset.ToString();
        }



        private void voitto()
        {
            foreach (Control control in tlpTaulu.Controls)
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

        private void tmrKuva_Tick_1(object sender, EventArgs e)
        {
            tmrKuva.Stop();

            ekaKlikkaus.ForeColor = ekaKlikkaus.BackColor;
            tokaKlikkaus.ForeColor = tokaKlikkaus.BackColor;

            ekaKlikkaus = null;
            tokaKlikkaus = null;
        }

        private void tmrAika_Tick_1(object sender, EventArgs e)
        {
            kulunutaika++;
            tsslbKulunutAika.Text = "Kulunut aika:" + kulunutaika.ToString();

            if (pareja == 12)
            {
                tmrAika.Stop();

                DialogResult = MessageBox.Show("JEE", "Arvaukset: " +
                Convert.ToString(arvaukset) + " " + "Kulunut aika oli: " + Convert.ToString(kulunutaika));

                string tiedostoPolku = @"C:\temp\yksinpeli_vaikea.txt";

                using (StreamWriter sw = new StreamWriter(tiedostoPolku, true))
                {
                    sw.WriteLine("Pisteet: " + arvaukset + " Aika: " + kulunutaika + " sekuntia");
                }
            }
        }

        private void tsbSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        } // sulkee kyseisen formin

        private void Yksinpeli_vaikea_Load(object sender, EventArgs e) 
        {

        }
    }

}

