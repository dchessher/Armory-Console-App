using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.DChessher
{
    public class Sword : Weapon
    {

        public Sword()
        {
            Rank = 1;
            Damage = 1;
            Material = "Unknown";
            Name = "A Blade Has No Name";
            WeaponType = "Sword";
        }

        public Sword(string name) 
        {
            Rank = 1;
            Damage = 1;
            Material = "Unknown";
            Name = name;
            WeaponType = "Sword";

        }

        public Sword (int rank, int damage, string material, string name, string weaponType) 
        {
            Rank = rank;
            Damage = damage;
            Material = material;
            Name = name;
            WeaponType = weaponType;
        }


        public virtual void SpecialSwordMove()
        {

        }

        public override void Attack() {}
    }
}