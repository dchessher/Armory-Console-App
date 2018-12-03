using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.DChessher
{
    public abstract class Weapon
    {
        private string _material;
        private string _name;
        private string _weaponType;
        private int _damage;
        private int _rank;

        public string Material
        {
            get => _material;
            set => _material = value;
        }

        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public int Rank
        {
            get => _rank;
            set => _rank = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string WeaponType
        {
            get => _weaponType;
            set => _weaponType = value;
        }

        public abstract void Attack();

        //static public void Attack()
        //{
        //    throw new System.NotImplementedException();
        //}
    }

}