using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scannercuccli
{
    internal class Diak
    {
        private string nev;
        private string szulDatum;
        private string kod;

        public Diak(string nev, string szulDatum, string kod)
        {
            this.nev = nev;
            this.szulDatum = szulDatum;
            this.kod = kod;
        }

        public string Nev { get => nev; }
        public string SzulDatum { get => szulDatum; }
        public string Kod { get => kod; set => kod = value; }

        public override string ToString()
        {
            return $"{this.nev} {this.szulDatum} {this.kod}";
        }
    }
}
