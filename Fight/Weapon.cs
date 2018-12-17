using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Weapon
    {
        private string wname;
        private int mindmg;
        private int maxdmg;
        private double crit;
        public string Wname { get { return wname; } set { wname = value; } }
        public int Mindmg { get { return mindmg; } set { mindmg = value; } }
        public int Maxdmg { get { return maxdmg; } set { maxdmg = value; } }
        public double Crit { get { return crit; } set { crit = value; } }


        //Weapon constructor
        public Weapon(string cname,int cmin, int cmax, double ccrit)
        {
            wname = cname;
            mindmg = cmin;
            Maxdmg = cmax;
            crit = ccrit;
        }

    }



}
