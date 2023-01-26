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
    public partial class Form1 : Form
    {   
        // MUUTTUJIA

        Label ekaKlikkaus  = null;
        Label tokaKlikkaus = null;
        int arvaukset   = 0;
        int kulunutaika = 0;
        int pareja;

        Random r = new Random(); // Random-luokka tarvitaan kuvien satunnaiseen järjestelyyn



        List<string> merkit = new List<string>() 
        {
            "h", "h", "l", "l", "Y", "Y", "!", "!", "b", "b", "N", "N",

         // " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ",
         // " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ",
         // " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ",
        }; // Lista, jossa on kuvien merkit
        
        private void MaaritaKuvat() // Aseta kuvat satunnaisesti näkyviin
        {

            foreach (Control control in tlpTaulu.Controls) // Käy läpi kaikki tlpTaulu-kontrollin sisältämät kontrollit
            {
                Label merkkilabeli = control as Label; // Tarkista, onko kontrolli label 

                if (merkkilabeli != null)
                {
                    int randomR = r.Next(merkit.Count); // Valitse satunnainen indeksi listasta merkit
                    merkkilabeli.Text = merkit[randomR];  // Aseta labelin tekstiksi valittu merkki ja poista se listasta
                    merkit.RemoveAt(randomR);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            MaaritaKuvat();

            string tiedostoPolku = @"C:\temp\yksinpeli_helppo.txt";

            if (!File.Exists(tiedostoPolku))
            {
                using (File.Create(tiedostoPolku))
                {
                    // Tiedosto luotiin
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e) // Tapahtumakäsittelijä, joka suoritetaan, kun jotain labelia klikataan  
        {
            if (tmrKuva.Enabled == true) // Tarkista, onko ajastin tmrKuva käynnissä
                return;

            Label klikattuLabeli = sender as Label; // Muunna sender-parametri Label-tyyppiseksi

            if (klikattuLabeli != null) // Tarkista, että klikattu kontrolli on label
            {
                if (klikattuLabeli.ForeColor == Color.Black)  // Jos labelin fonttiväri on musta, älä tee mitään
                    return;

                if (ekaKlikkaus == null) // Jos ensimmäinen klikkaus on tekemättä, aseta ensimmäinen klikkaus tehdyksi
                {
                    tmrAika.Start();
                    arvaukset++;
                    ekaKlikkaus = klikattuLabeli;
                    ekaKlikkaus.ForeColor = Color.Black;
                    return;
                }

                tokaKlikkaus = klikattuLabeli; // Aseta toinen klikkaus tehdyksi
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

            if (sslbArvaukset != null) // Jos ensimmäisen ja toisen klikatun labelin merkit ovat samat, lisää yksi pari
                sslbArvaukset.Text = "Arvauksia: " + arvaukset.ToString();
        }
        
        private void tmrKuva_Tick_1(object sender, EventArgs e) // Tapahtumakäsittelijä, joka suoritetaan, kun tmrKuva-ajastin käynnistyy
        {
            tmrKuva.Stop(); // Pysäytä ajastin tmrKuva

            ekaKlikkaus.ForeColor  = ekaKlikkaus.BackColor; // Palauta ensimmäisen ja toisen klikatun labelin fonttiväri alkuperäiseen tilaan
            tokaKlikkaus.ForeColor = tokaKlikkaus.BackColor;

            ekaKlikkaus  = null; // Aseta ensimmäinen ja toinen klikkaus tekemättömiksi
            tokaKlikkaus = null;
        }

        private void voitto() // Tarkista, onko peli voitettu
        {
            foreach (Control control in tlpTaulu.Controls) // Käy läpi kaikki tlpTaulu-kontrollin sisältämät kontrollit
            {
                Label merkkilabeli = control as Label;  // Tarkista, onko kontrolli label 

                if (merkkilabeli != null)
                {   
                    
                    if (merkkilabeli.ForeColor == merkkilabeli.BackColor) // Jos labelin fonttiväri ei ole sama kuin taustaväri, peli ei ole vielä voitettu
                    {

                    }
                        return;
                }

                using (StreamWriter sw = new StreamWriter("yksinpeli_helppo.txt", true)) // Peli on voitettu, kirjoita tiedot tiedostoon
                {
                    
                    sw.WriteLine("Pisteet: " + arvaukset + " Aika: " + kulunutaika + " sekuntia");
                }
            }
            

        }

        private void tmrAika_Tick(object sender, EventArgs e)
        {
            kulunutaika++;
            tsslbKulunutAika.Text = "Kulunut aika:" + kulunutaika.ToString();

            if (pareja == 6)
            {       
                tmrAika.Stop();

                DialogResult = MessageBox.Show("JEE", "Arvauksia: " +
                Convert.ToString(arvaukset) + " " + "Kulunut aika oli: " + Convert.ToString(kulunutaika));

                string tiedostoPolku = @"C:\temp\yksinpeli_helppo.txt";

                using (StreamWriter sw = new StreamWriter(tiedostoPolku, true))
                {
                    sw.WriteLine("Pisteet: " + arvaukset + " Aika: " + kulunutaika + " sekuntia");
                }

            }

        }



        // TÄSTÄ ETEENPÄIN ENSIMÄISEN FORMIN KLIKKI TOIMTOJA 

        private void helppoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlpTaulu.Visible = true;
        }

        private void vaikeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yksinpeli_vaikea yv = new Yksinpeli_vaikea();
            yv.Show();
        }  // aukaisee yksinpeli vaikeamman tason toiselle formille

        private void helppoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kaksinpeli_helppo kh = new Kaksinpeli_helppo();
            kh.Show();
        } // aukaisee kaksinpeli helpon tason toiselle formille

        private void vaikeaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kaksinpeli_vaikea kv = new Kaksinpeli_vaikea();
            kv.Show();
        } // aukaisee kaksinpeli vaikeamman tason toiselle formille

        private void tsbSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        } //    SULKEE OHJELMAN

    }
}
