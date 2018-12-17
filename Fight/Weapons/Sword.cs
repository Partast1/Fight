using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight.Weapons
{
    class Sword : Weapon
    {

        //SubClass Sword : Doublehit
        private double doublehit;
        public double Doublehit { get { return doublehit; } set { doublehit = value; } }

        public Sword(string cname, int cmin, int cmax, double ccrit, double cdoublehit) : base(cname, cmin, cmax, ccrit)
        {
         
            cdoublehit = doublehit;
        }

        public void Doublestrike()
        {
            Random r = new Random();
            double dh = doublehit;
            if (r.Next(0, 99) < dh)
            {
                int md = Mindmg * 2;
                int mxd = Maxdmg * 2;
            }
        }
    }
}
