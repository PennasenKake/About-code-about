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
    public partial class Kaksinpeli_helppo : Form
    {
        Label ekaKlikkaus = null; // Kaksi Label-tyyppistä muuttujaa, jotka tallentavat viimeksi
        Label tokaKlikkaus = null;// klikatut merkkilabeleiden viitteet.
        int arvaukset = 0; // Muuttuja arvauksien määrälle
        int kulunutaika = 0; // Muuttuja ajalle, jonka kuluminen näytetään ajastimessa.
        int pareja; // Muuttuja löydetyille pareille
        string player1 = "Pelaaja1"; // pelaaja nro 1 
        string player2 = "Pelaaja2"; //pejaaja nro 2
        int player1Pisteet = 0; // Muuttujat pelaajien pisteille
        int player2Pisteet = 0;
        string nykyinenPelaaja;

        Random r = new Random(); // Random-luokan ilmentymä satunnaislukujen arpomiseen

        List<string> merkit = new List<string>()
        {
            "h", "h", "l", "l", "Y", "Y", "!", "!", 
            "b", "b", "N", "N", "j", "j", "J", "J", 

         // "P", "P", "v", "v", ",", ",", "$", "$",

         // " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ",
         // " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ",
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
        } // Lista merkeistä, joista muodostetaan pareja

        public Kaksinpeli_helppo()
        {
            InitializeComponent();
            MaaritaKuvat();

            nykyinenPelaaja = "player1"; // Aseta aluksi pelaajaksi 1
        }

        private void label1_Click(object sender, EventArgs e) // Tapahtumakäsittelijä merkkilabelien klikkaamiselle
        {
            if (tmrKuva.Enabled == true) // Tarkistetaan, onko ajastin päällä
                return;

            Label klikattuLabeli = sender as Label; // Luodaan muuttuja klikatun merkkilabelin lähettämää objektia varten

            if (klikattuLabeli != null)
            {
                if (klikattuLabeli.ForeColor == Color.Black)
                    return;

                if (ekaKlikkaus == null) // Tarkistetaan, että muuttuja ei ole null ja että sen tekstinväri ei ole musta
                {
                    tmrAika.Start();// Käynnistetään ajastin, tallennetaan klikattu labeli ekaKlikkaus-muuttujaan ja muutetaan sen tekstinväri mustaksi
                    ekaKlikkaus = klikattuLabeli;
                    ekaKlikkaus.ForeColor = Color.Black;
                    return;
                }

                tokaKlikkaus = klikattuLabeli;  // Tallennetaan klikattu labeli tokaKlikkaus-muuttujaan ja muutetaan sen tekstinväri mustaksi
                tokaKlikkaus.ForeColor = Color.Black;

                if (ekaKlikkaus.Text == tokaKlikkaus.Text) // Tarkistetaan, ovatko ekaKlikkaus ja tokaKlikkaus samat
                {
                    pareja++; // Lisätään pareja-muuttujaan yksi ja asetetaan ekaKlikkaus ja tokaKlikkaus nulliksi
                    ekaKlikkaus = null;
                    tokaKlikkaus = null;
                    player1Pisteet = arvaukset++;
                    player2Pisteet = arvaukset++; // Lisätään arvaukset-muuttujaan yksi ja lisätään player1Pisteet ja player2Pisteet yhdellä
                    return;
                }
                tmrKuva.Start(); // Käynnistetään ajastin
            }


            if (tsslbVuoro != null) // Asetetaan tsslbVuoro-muuttujaan teksti "Vuoro: " sekä nykyinenPelaaja
                tsslbVuoro.Text = "Vuoro: " + nykyinenPelaaja;
        } 



        private void voitto() // Tarkistetaan, ovatko kaikki merkkilabelit mustia
        {
            foreach (Control control in tlbTaulu.Controls)
            {
                Label merkkilabeli = control as Label;

                if (merkkilabeli != null)
                {
                    if (merkkilabeli.ForeColor != merkkilabeli.BackColor)
                    {
                        return;
                    }
                }
            }
        }

        private void tmrKuva_Tick(object sender, EventArgs e)
        {
            tmrKuva.Stop();

            ekaKlikkaus.ForeColor = ekaKlikkaus.BackColor;
            tokaKlikkaus.ForeColor = tokaKlikkaus.BackColor;

            ekaKlikkaus = null;
            tokaKlikkaus = null;

            if (nykyinenPelaaja == player1)
            {
                nykyinenPelaaja = player2;
            }
            else
            {
                nykyinenPelaaja = player1;
            }

            tsslbVuoro.Text = "Vuoro: " + nykyinenPelaaja;

        }

        private void tmrAika_Tick_1(object sender, EventArgs e)
        {
            kulunutaika++;
            tsslbPeliAika.Text = "Peli aika: " + kulunutaika.ToString();

            if (nykyinenPelaaja == "player1")
            {
                player1Pisteet++;
            }
            else
            {
                player2Pisteet++;
            }

            if (pareja == 8)
            {
                tmrAika.Stop();

                string voittaja = player1Pisteet > player2Pisteet ? player1 : player2;
                int pisteet = Math.Max(player1Pisteet, player2Pisteet);
                MessageBox.Show($"Voittaja on {voittaja} pistein {pisteet}!");
          
            }
        }


        private void Sulje_Click(object sender, EventArgs e) //sulkee kyseisen formin
        {
            this.Close();
        }

    }
}
