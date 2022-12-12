using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bejcek_20221212
{
    internal class Soldier
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Shield { get; set; }
        public int Damage { get; set; }
        public int MaxShield { get; set; }

        public Soldier(string name)
        {
            Name = name;
            HP = 0;
            MaxHP = 100;  
            Shield = 100;
            Damage = 20;
            MaxShield = 100;
        }

        public void Attack(Soldier Enemy)
        {
           if(Enemy.Shield <= 0)
            {

            }
        }

        public void Heal()
        {

        }
    }
}
