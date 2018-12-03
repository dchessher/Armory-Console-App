using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.DChessher
{
    public class Staff : Weapon
    {
        public Staff()
        {
            Rank = 1;
            Damage = 1;
            Material = "Unknown";
            Name = "A Staff Has No Name";
            WeaponType = "Staff";
        }
               
        public virtual void SpecialStaffMove()
        {

        }

        public override void Attack() {}
    }
}