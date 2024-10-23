using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjGru
{
    internal class Gru
    {
        private string numSeriale;
        private string produttore;
        private int pesoMax;
        public int PesoMax
        {
            get { return pesoMax; }
        }
        private int altMax;
        public int AltMax
        {
            get { return altMax; }
            set { altMax=value; }
        }
        private int altMin;
        public int AltMin
        {
            get { return altMin; }
            set { altMin = value; }
        }
        private int altBraccio;
        public int AltBraccio
        {
            get { return altBraccio; }
            set { altBraccio = value; }
        }

        public Gru(string numSeriale, string produttore, int pesoMax, int altMax, int altMin, int altBraccio) 
        {
            this.numSeriale = numSeriale;
            this.produttore = produttore;
            this.pesoMax = pesoMax;
            this.altMax = altMax;   
            this.altMin = altMin;
            this.altBraccio = altBraccio;
        }

        public void alza()
        {
            if (AltBraccio <= AltMax)
                AltBraccio += 10;
        }

        public void abbassa()
        {
            if(AltBraccio>=AltMin)
                AltBraccio -= 10;
        }

        public void reset()
        {
            AltBraccio = AltMin;
        }

    }
}
