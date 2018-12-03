using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.DChessher
{
    public class Katana : Sword
    {

        public Katana()
        {
            Name = "A Katana has no name.";
            WeaponType = "Katana";
        }

        public Katana (string name) : base(name){}

        public override void SpecialSwordMove()
        {
            base.SpecialSwordMove();

            Console.WriteLine("Special {0} Attack", this.WeaponType);
        }
    }
}