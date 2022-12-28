using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bejcek_20221212
{
    public class Soldier
    {
        public string Name { get; set; }
        public int DMGinRow { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int DMG { get; set; }
        public int Shield { get; set; }
        public int MaxShield { get; set; }
        public int Level { get; set; }
        public bool lost = false;
        public Soldier(string name)
        {
            Name = name;
            HP = 100;
            MaxHP = 100;
            DMG = 25;
            Shield = 100;
            MaxShield = 100;
            Level = 1;
        }
        public void Check(Soldier Enemy)
        {
            if (HP <= 0)
            {
                Enemy.lost = true;
            }
        }
        public void Attack(Soldier Enemy)
        {
            if (Enemy.Shield > 0)
            {
                Enemy.Shield -= DMG;
            }
            else
            {
                Enemy.Shield = 0;
                Enemy.HP -= DMG;
                DMGinRow += DMG;
            }
            LevelUp();
        }
        public void Heal()
        {
            HP = MaxHP;
        }
        public void LevelUp()
        {
            if (DMGinRow >= 100)
            {
                DMGinRow = 0;
                MaxHP += 20;
                MaxShield += 20;
                Shield = MaxShield;
                Heal();
                Level++;
            }
        }
    }
}
