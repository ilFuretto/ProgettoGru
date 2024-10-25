namespace ProjGru
{
    public partial class Form1 : Form
    {
        private bool bottonePremuto = false;
        private StazioneRadiocomando stazione1;
        private Gru gru1;
        int posizioneGancio;
        public Form1()
        {
            InitializeComponent();
            posizioneGancio = pictureBox2.Location.Y;
            gru1 = new Gru("000001", "XCMG", 750, this.ClientSize.Height - pictureBox2.Height, posizioneGancio, posizioneGancio);
            stazione1 = new StazioneRadiocomando("000001", gru1);
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
            pictureBox2.Location = new Point(pictureBox2.Location.X, posizioneGancio + Distanza);
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
            pictureBox2.Location = new Point(pictureBox2.Location.X, posizioneGancio);
        }

        private void ApplicaButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= numericUpDown2.Value)
            {
                stazione1.Gru.AltMin = Convert.ToInt16(numericUpDown1.Value);
                stazione1.Gru.AltMax = Convert.ToInt16(numericUpDown2.Value);
                pictureBox2.Location = new Point(pictureBox2.Location.X, Convert.ToInt16(numericUpDown1.Value));
            }
            else
            {
                MessageBox.Show("L'altezza minima deve essere minore o uguale della massima!", "ERRORE!");
            }
            
        }
    }
}