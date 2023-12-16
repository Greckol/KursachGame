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
        protected int critChance;
        protected int health;
        protected int healthRegeneration;
        protected int healthMax;
        protected int armor;
        protected int rangeAtack;
        protected string name;


        public Unit(int cordColums = 0, int cordRows = 0, int damage = 1, int critChance = 5, int health = 5, int healthMax = 5,
            int armor = 0, string name = "undef", int rangeAtack = 1, int healthRegeneration = 1)
        {
            CordColums = cordColums;
            CordRows = cordRows;
            Name = name;
            this.damage = damage;
            this.critChance = critChance;
            this.health = health;
            this.healthRegeneration = healthRegeneration;
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
        public int Hit()
        {
            Random random = new Random();
            if (critChance >= random.Next(1, 101))
            {
                return getDamage() * 2;
            };
            return getDamage();
        }
        public abstract int getCritChance();
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
