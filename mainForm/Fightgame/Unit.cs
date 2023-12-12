using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    public abstract class Unit
    {
        public int cordColums;
        public int cordRows;
        public int damage;
        public int health;
        public int healthMax;
        public int armor;
        public int evasion;
        public int lvl;
        public int rangeAtack;
        public string name;
        

        public Unit(int cordColums = 0, int cordRows = 0, int damage = 1, int health = 5, int helthMax = 5,
            int armor = 0, int evasion = 0, int lvl = 1, string name = "undef", int rangeAtack = 1) 
        {
            CordColums = cordColums;
            CordRows = cordRows;
            Damage = damage;
            Health = health;
            HealthMax = helthMax;
            Armor = armor;
            Evasion = evasion;
            Lvl = lvl;
            Name = name;
            RangeAtack = rangeAtack;
        }
        
        public int Lvl
        {
            get { return lvl; }
            set { lvl = value; }
        }
        
        public int CordColums
        {
            get { return cordColums; }
            set { cordColums = value; }
        }
        public int CordRows
        {
            get { return cordRows; }
            set { cordRows = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int HealthMax
        {
            get { return healthMax; }
            set { healthMax = value; }
        }
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }

        public int Evasion
        {
            get { return evasion; }
            set { evasion = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int RangeAtack
        {
            get { return rangeAtack; }
            set { rangeAtack = value; }
        }

        protected int atackCount = 5;
        protected int cellAtackCount = 6;
        public int AtackCount
        {
            get { return atackCount; }
        }
        public virtual void Die() 
        {
            Player.GetInstance().Exp += 5;
        }
    }
}
