using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.DChessher
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create program with multiple levels/ types of inheritance. Use some custom constructors and properties. Use "static," "base," various access modifiers, "virtual," "override," and "abstract." Submit update.
            Armory badlandArmory = new Armory();

            List<Weapon> weaponsCache = new List<Weapon>();

            Weapon forgeWeapon = new Sword();

            Forge.StartForge(ref badlandArmory, ref forgeWeapon);

            badlandArmory.PrintWeapons();

            Console.ReadLine();

        }
    }
}
