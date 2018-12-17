using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class CreateCreature
    {
        public List<Creature> NewCreature()
        {
            Creature Human = new Creature("Human", 25, 4);
            Creature Dwarf = new Creature("Dwarf", 28, 2);
            Creature Orc = new Creature("Orc", 28, 1);
            List<Creature> newcreatures = new List<Creature>();
            newcreatures.Add(Human);
            newcreatures.Add(Dwarf);

            return newcreatures;
        }



    }
}
