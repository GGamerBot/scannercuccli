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
		//bool belepE; TBA

		//Be/kilépés rögzítése a belépés időpontjában
		public Adatsor(string vonalkod)
		{
			this.vonalkod = vonalkod;
			this.idopont = DateTime.Now;
		}

		//Be/kilépés utólagos rögzítésére
		public Adatsor(string vonalkod, DateTime idopont)
		{
			this.vonalkod = vonalkod;
			this.idopont = idopont;
		}

		public string Vonalkod { get => vonalkod; }
		public DateTime Idopont { get => idopont; }

		//CSV készítésére való!!
		public override string ToString()
		{

			return $"{vonalkod};{idopont.Year}.{idopont.Month}.{idopont.Day};{idopont.Hour}:{idopont.Minute}:{idopont.Second}";
		}

	}
}
