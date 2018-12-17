using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateWeapon cw = new CreateWeapon();
            CreateCreature cc = new CreateCreature();


            List<Creature> creatures = cc.NewCreature();
            List<Weapon> weapons = cw.WeaponCreation();
            List<Creature> playerCre = new List<Creature>();
            List<Weapon> playerInventory = new List<Weapon>();



            Console.WriteLine("Select a Hero");
            //Display info about Creatures
            int creIndex = 1;
            foreach (Creature item in creatures)
            {
                Console.WriteLine("Number: {0} Race: {1} HP: {2}",creIndex, item.Name, item.Hp);
                creIndex++;
            }
            int inputC = int.Parse(Console.ReadLine()) ;
            playerCre.Add(creatures[inputC - 1]);

            foreach (Creature item in playerCre)
            {
                Console.WriteLine(item.Name);
            }

            //SELECT weapon
            Console.WriteLine("Select weapon");

            int wIndex = 1;
            foreach (Weapon item in weapons)
            {
                Console.WriteLine("#{0} Name: {1} Damage: {2}-{3} Crit: {4}",wIndex, item.Wname, item.Mindmg, item.Maxdmg, item.Crit);
                wIndex++;
            }
            int inputW = int.Parse(Console.ReadLine());
            playerInventory.Add(weapons[inputW - 1]);



            foreach (Weapon item in playerInventory)
            {
                Console.WriteLine("{0}",item.Wname);
            }

            Console.ReadLine();
        }
    }
}
