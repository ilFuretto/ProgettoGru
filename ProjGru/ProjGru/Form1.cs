using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGru
{
    public partial class Form1 : Form
    {
        private bool bottonePremuto = false;
        private SoundPlayer simpleSound;
        private StazioneRadiocomando stazione1;
        private Gru gru1;
        private int posizioneGancio;
        private int altezzaIniziale;
        private bool suonoInRiproduzione = false;
        private readonly object lockObj = new object();

        public Form1()
        {
            InitializeComponent();
            simpleSound = new SoundPlayer(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "audio", "audioGru.wav"));
            posizioneGancio = pictureBox2.Location.Y;
            altezzaIniziale = posizioneGancio;
            gru1 = new Gru("000001", "XCMG", 750, this.ClientSize.Height - pictureBox2.Height, posizioneGancio, posizioneGancio);
            stazione1 = new StazioneRadiocomando("000001", gru1);
            gru1.Stazione = stazione1;
        }

        private void AggiornaForm(int Distanza)
        {
            posizioneGancio += Distanza;
            if (posizioneGancio <= stazione1.Gru.AltMin)
            {
                posizioneGancio = stazione1.Gru.AltMin;
            }
            else if (posizioneGancio >= stazione1.Gru.AltMax)
            {
                posizioneGancio = stazione1.Gru.AltMax;
            }
            pictureBox2.Location = new Point(pictureBox2.Location.X, posizioneGancio);
            pictureBox3.Height = posizioneGancio - altezzaIniziale;

            RiproduciSuonoAsync();
            Thread.Sleep(50);
        }

        private async void Abbassa(object sender, MouseEventArgs e)
        {
            bottonePremuto = true;
            while (bottonePremuto)
            {
                stazione1.Abbassa();
                AggiornaForm(10);
                await Task.Delay(50);
            }
        }

        private async void Alza(object sender, MouseEventArgs e)
        {
            bottonePremuto = true;
            while (bottonePremuto)
            {
                stazione1.Alza();
                AggiornaForm(-10);
                await Task.Delay(50);
            }
        }

        private void bottone_MouseUp(object sender, MouseEventArgs e)
        {
            bottonePremuto = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            stazione1.Reset();
            posizioneGancio = stazione1.Gru.AltMin;
            stazione1.Gru.AltBraccio = posizioneGancio;
            pictureBox3.Height = posizioneGancio - altezzaIniziale;
            pictureBox2.Location = new Point(pictureBox2.Location.X, posizioneGancio);
        }

        private void ApplicaButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= numericUpDown2.Value)
            {
                stazione1.Gru.AltMin = Convert.ToInt16(numericUpDown1.Value);
                stazione1.Gru.AltMax = Convert.ToInt16(numericUpDown2.Value);
                posizioneGancio = stazione1.Gru.AltMin;
                stazione1.Gru.AltBraccio = posizioneGancio;
                pictureBox2.Location = new Point(pictureBox2.Location.X, posizioneGancio);
                pictureBox3.Height = posizioneGancio - altezzaIniziale;
            }
            else
            {
                MessageBox.Show("L'altezza minima deve essere minore o uguale della massima!", "ERRORE!");
                numericUpDown1.Value = stazione1.Gru.AltMin;
                numericUpDown2.Value = stazione1.Gru.AltMax;
            }
        }

        private void RiproduciSuonoAsync()
        {
            lock (lockObj)
            {
                if (suonoInRiproduzione) return;
                suonoInRiproduzione = true;
            }

            Task.Run(() =>
            {
                try
                {
                    simpleSound.PlaySync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel riprodurre il suono: " + ex.Message);
                }
                finally
                {
                    lock (lockObj)
                    {
                        suonoInRiproduzione = false;
                    }
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(pictureBox3.Size.Width, pictureBox2.Size.Height);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("Il numero seriale della stazione collegata alla gru e' " + gru1.Stazione.NumSeriale);
        }
    }
}
