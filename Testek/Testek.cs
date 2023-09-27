using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    abstract class Testek
    {
        public string neve;
        public double egy, ketto, harom;

        public Testek(string neve)
        {
            this.neve = neve;
        }

        public override string ToString()
        {
            return neve;
        }
        abstract public double Terfogat();
        abstract public double Felszin();
    }
    
}
