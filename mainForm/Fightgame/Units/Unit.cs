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
        protected int cordColums;
        protected int cordRows;
        protected int damage;
        protected int health;
        protected int hpRegeneration;
        protected int healthMax;
        protected int armor;
        protected int rangeAtack;
        protected string name;


        public Unit(int cordColums = 0, int cordRows = 0, int damage = 1, int health = 5, int healthMax = 5,
            int armor = 0, string name = "undef", int rangeAtack = 1, int hpRegeneration = 1)
        {
            CordColums = cordColums;
            CordRows = cordRows;
            Name = name;
            this.damage = damage;
            this.health = health;
            this.hpRegeneration = hpRegeneration;
            this.healthMax = healthMax;
            this.armor = armor;
            this.rangeAtack = rangeAtack;
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
        public abstract int getDamage();
        
        public abstract int getArmor();
        public abstract int getRangeAtack();
        public abstract int getHealthRegeneration();
        public void healthRegen()
        {
            if (getHealth() + getHealthRegeneration() < getHealthMax())
            {
                health += getHealthRegeneration();
            }
            else health = healthMax;
        }
        public int getHealth()
        {
            return health;
        }
        public int getHealthMax()
        {
            return healthMax;
        }
        public void takedamage(int damage)
        {
            if (health - damage < 0)
            {
                health = 0;
                Die();
            }
            else
            {
                health -= damage;
            }
        }

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public abstract void Die();
    }
}
