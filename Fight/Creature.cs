using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    public enum Grade
    {
        A, B, C, D, F
    }
    class Creature
    {
        private string name;
        private byte hp;
        private byte evade;

        public Grade? Grade { get; set; }


        public string Name { get { return name; } set { this.name = value; } }
        public byte Hp { get { return hp; } set { this.hp = value; } }
        public byte Evade { get { return evade; } set { this.evade = value; } }


        public Creature(string cname, byte chp, byte cevade)
        {
            name = cname;
            hp = chp;
            evade = cevade;
        
        }

    }
   


}
