using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.DChessher
{
    public class Armory
    {
        private List<Weapon> _weaponsCache = new List<Weapon>();

        public void AddWeapon(Weapon wpn) => _weaponsCache.Add(wpn);

        public void PrintWeapons()
        {
            foreach (Weapon wpn in _weaponsCache)
            {
                Console.WriteLine("Weapon Name: {0}", wpn.Name);
                Console.WriteLine("Weapon Type: {0}", wpn.WeaponType);
                Console.WriteLine("Weapon Rank: {0}", wpn.Rank);
                Console.WriteLine("Weapon Material: {0}", wpn.Material);
                Console.WriteLine("Weapon Damage: {0}\n", wpn.Damage);
            }
        }

    }
}