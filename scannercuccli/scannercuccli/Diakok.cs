using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scannercuccli
{
    internal class Diakok
    {
        private List<Diak> diakokList;

        public Diakok()
        {
            diakokList = new List<Diak>();
        }
        public void DiakHozzaad(Diak diak)
        {
            diakokList.Add(diak);
            Console.WriteLine("Diák hozzá lett adva");
        }
        public void DiakEltavolit(string kod)
        {
            int index = 0;
            foreach(var diak in diakokList)
            {
                if(diak.Kod == kod)
                {
                    diakokList.RemoveAt(index);
                }
                index++;
            }
        }
        public void DiakKereses(string kod)
        {
            foreach (var diak in diakokList)
            {
                if (diak.Kod == kod)
                {
                    Console.WriteLine(diak);
                }
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (Diak diak in diakokList)
            {
                s += diak + "\n";
            }
            return s;
        }
    }
}
