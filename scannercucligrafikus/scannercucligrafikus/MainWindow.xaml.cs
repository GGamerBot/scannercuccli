using System;
using System.Collections.Generic;
using System.Windows;

namespace ScannerApp
{
	//idk hogyan kell összekötni a többivel majd abba kell help
	public partial class MainWindow : Window
	{
		private HashSet<string> scannedCodes = new HashSet<string>();
		private List<Adatsor> adatbazis = new List<Adatsor>();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnScan_Click(object sender, RoutedEventArgs e)
		{
			string code = txtInput.Text.Trim();
			txtInput.Clear(); // Töröljük a bemeneti mezőt

			if (string.IsNullOrWhiteSpace(code))
			{
				MessageBox.Show("Kérlek, adj meg egy kódot!");
				return;
			}

			// Ha a felhasználó egy kilépés kódot ad meg
			if (scannedCodes.Contains(code))
			{
				MessageBox.Show($"A {code} kódu diák kilépett.");
				scannedCodes.Remove(code); // Törölni a kódot
				adatbazis.RemoveAll(adat => adat.Code == code); // Az adatbázisból is töröljük
			}
			else
			{
				MessageBox.Show($"A {code} kódu diák belépett.");
				scannedCodes.Add(code); // Hozzáadjuk a kódot
				adatbazis.Add(new Adatsor(code)); // Adatsor hozzáadása
			}
		}

		private void DisplayResults()
		{
			txtOutput.Clear();
			foreach (var adatsor in adatbazis)
			{
				txtOutput.AppendText(adatsor.ToString() + Environment.NewLine);
			}
			// TBA: CSV file-ba írás
		}
	}

	// Az adatsor osztály definíciója
	public class Adatsor
	{
		public string Code { get; }

		public Adatsor(string code)
		{
			Code = code;
		}

		public override string ToString()
		{
			return Code; // Esetleg itt módosíthatod, hogy több adatot is tartalmazzon
		}
	}
}
