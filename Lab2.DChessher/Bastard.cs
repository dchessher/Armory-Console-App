using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.DChessher
{
    public class Bastard : Sword
    {
        public Bastard() : base(){}

        public Bastard (string name) : base(name){}

        public Bastard (int rank, int damage, string material, string name, string weaponType)
            : base(rank, damage, material, name, weaponType) {}
    }
}