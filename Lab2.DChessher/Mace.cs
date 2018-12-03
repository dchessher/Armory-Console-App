using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.DChessher
{
    public class Mace : Weapon
    {

        public Mace()
        {
            Rank = 1;
            Damage = 1;
            Material = "Unknown";
            Name = "A Mace Has No Name";
            WeaponType = "Mace";
        }

        public virtual void SpecialMaceMove()
        {

        }

        public override void Attack() {}
    }
}