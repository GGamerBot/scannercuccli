using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scannercuccli
{
	internal class ScannerProgram
	{
		static HashSet<string> scannedCodes = new HashSet<string>();

		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Kérlek, scanneld be a kódot (vagy írj 'exit'-et a kilépéshez):");
				string code = Console.ReadLine();

				if (code.ToLower() == "exit")
				{
					break;
				}

				if (scannedCodes.Contains(code))
				{
					Console.WriteLine($"A {code} kódu diák kilépett.");
					scannedCodes.Remove(code);  
				}
				else
				{
					Console.WriteLine($"A {code} kódu diák belépett.");
					scannedCodes.Add(code);  
				}
			}
		}
	}
}
