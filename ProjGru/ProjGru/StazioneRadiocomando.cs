using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjGru
{
    internal class StazioneRadiocomando
    {
        private string numSeriale;
        public string NumSeriale 
        { get { return numSeriale; } }

        private Gru gru;
        public Gru Gru 
        { 
            get { return gru; } 
            set { gru = value; }
        }
        public StazioneRadiocomando(string numSeriale)
        {
            this.numSeriale = numSeriale;
        }

        public void alza()
        {
            Gru.alza();
        }

        public void abbassa()
        {
            Gru.abbassa();
        }

        public void reset()
        {
            Gru.reset();
        }

        public void vediAlt()
        {
            Console.WriteLine(Gru.AltBraccio);
        }

    }
}
