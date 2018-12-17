using Fight.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class CreateWeapon
    {
        public List<Weapon> WeaponCreation()
        {
            
            List<Sword> swords = new List<Sword>();
            List<Axe> axes = new List<Axe>();
            List<Spear> spears = new List<Spear>();
            List<Weapon> weapons = new List<Weapon>();

            Sword smallSword = new Sword("Small Sword", 2, 4, 1.73, 0.20);
            Sword longSword = new Sword("Long Sword", 3, 6, 1.73, 0.20);
            Axe handAxe = new Axe("HandAxe", 2, 4, 4.15);
            Axe axe = new Axe("Axe", 3, 6, 4.12);
            Spear spear = new Spear("Spear", 2, 5, 0.54);
            Spear lance = new Spear("Lance", 4, 7, 0.30);


            //Adds swords to list
            swords.Add(smallSword);
            swords.Add(longSword);

            //Adds axes to list
            axes.Add(handAxe);
            axes.Add(axe);

            //Adds spears to list
            spears.Add(spear);
            spears.Add(lance);

            ////Adds weapons to list
            //weapons.Add(handAxe);
            //weapons.Add(axe);
            //weapons.Add(spear);
            //weapons.Add(lance);

            foreach (Sword sitem in swords)
            {
                weapons.Add(sitem);
            }
            foreach (Axe aitem in axes)
            {
                weapons.Add(aitem);
            }
            foreach (Spear spitem in spears)
            {
                weapons.Add(spitem);
            }
            return weapons;
        }

    }
}
