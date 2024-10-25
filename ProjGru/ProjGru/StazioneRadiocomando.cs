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
        public StazioneRadiocomando(string numSeriale, Gru gru)
        {
            this.numSeriale = numSeriale;
            this.gru = gru;
        }

        public void Alza()
        {
            Gru.alza();
        }

        public void Abbassa()
        {
            Gru.abbassa();
        }

        public void Reset()
        {
            Gru.reset();
        }

        public int VediAlt()
        {
            return Gru.AltBraccio;
        }

    }
}
