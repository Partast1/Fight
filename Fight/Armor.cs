using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Armor
    {
        private string aname;
        private int defence;
        private decimal block;

        public string Aname { get { return aname; } set { this.aname = value; } }
        public int Defence { get { return defence; } set { this.defence = value; } }
        public decimal Block { get { return block; } set { this.block = value; } }



            public Armor(string cname, int cdef, decimal cblock)
        {
            this.aname = cname;
            this.defence = cdef;
            this.block = cblock;

        }

    }
}
