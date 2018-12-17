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
            List<Weapon> weapons = new List<Weapon>();

            Sword smallSword = new Sword("Small Sword", 2, 4, 1.73, 0.20);
            Sword longSword = new Sword("Long Sword", 3, 6, 1.73, 0.20);
            Weapon handAxe = new Weapon("HandAxe", 2, 4, 4.15);
            Weapon axe = new Weapon("Axe", 3, 6, 4.12);
            Weapon spear = new Weapon("spear", 2, 5, 0.54);
            Weapon lance = new Weapon("Stick", 4, 7, 0.30);
      

            //Adds swords to list
            swords.Add(smallSword);
            swords.Add(longSword);


            //Adds weapons to list
            weapons.Add(handAxe);
            weapons.Add(axe);
            weapons.Add(spear);
            weapons.Add(lance);
            weapons.Add(smallSword);
            return weapons;
        }

    }
}
