using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scannercuccli
{
	internal class Adatsor
	{
		string vonalkod;
		DateTime idopont;
		bool belepE; 

		//Be/kilépés rögzítése a belépés időpontjában
		public Adatsor(string vonalkod, bool belepE)
		{
			this.vonalkod = vonalkod;
			this.idopont = DateTime.Now;
			this.belepE	= belepE;
		}

		//Be/kilépés utólagos rögzítésére
		public Adatsor(string vonalkod, DateTime idopont, bool belepE)
		{
			this.vonalkod = vonalkod;
			this.idopont = idopont;
			this.belepE = belepE;
		}

		public string Vonalkod { get => vonalkod; }
		public DateTime Idopont { get => idopont; }
		public bool BelepE { get => belepE; }

		//CSV készítésére való!
		public override string ToString()
		{

			return $"{vonalkod};{idopont.Year}.{idopont.Month}.{idopont.Day} {idopont.Hour}:{idopont.Minute}:{idopont.Second};{belepE}";
		}

	}
}
