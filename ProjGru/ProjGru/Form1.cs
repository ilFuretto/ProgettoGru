namespace ProjGru
{
    public partial class Form1 : Form
    {
        private StazioneRadiocomando stazioneRadiocomando;
        private Gru gru;
        public Form1()
        {
            InitializeComponent();
            Gru gru1 = new Gru("1", "1", 1,2,3,4);
            StazioneRadiocomando stazione1 = new StazioneRadiocomando("123", gru1);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }
    }
}