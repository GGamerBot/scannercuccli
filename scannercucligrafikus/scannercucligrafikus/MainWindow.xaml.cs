using System;
using System.Collections.Generic;
using System.Windows;

namespace ScannerApp
{
    public partial class MainWindow : Window
    {
        private HashSet<string> scannedCodes = new HashSet<string>();
        private List<Adatsor> adatbazis = new List<Adatsor>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // TextBox esemény, ami akkor aktiválódik, ha új szöveg érkezik (pl. szkenner beolvasás)
        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string code = txtInput.Text.Trim();

            // Ellenőrizzük, hogy a szöveg hossza 10 karakter
            if (code.Length == 10)
            {
                ProcessCode(code);  // Kód feldolgozása
                txtInput.Clear();   // Töröljük a bemeneti mezőt a következő kódhoz
            }
        }

        // Kód feldolgozása
        private void ProcessCode(string code)
        {
            // Ha a felhasználó egy kilépés kódot ad meg (pl. újra beolvassa)
            if (scannedCodes.Contains(code))
            {
                scannedCodes.Remove(code); // Törölni a kódot
                adatbazis.RemoveAll(adat => adat.Code == code); // Az adatbázisból is töröljük
            }
            else
            {
                scannedCodes.Add(code); // Hozzáadjuk a kódot
                adatbazis.Add(new Adatsor(code)); // Adatsor hozzáadása
            }

            DisplayResults();
        }

        // Eredmények megjelenítése
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
