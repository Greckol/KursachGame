using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Fightgame.MatrixDef;

namespace Fightgame
{
    internal class Player : Unit
    {
        private static Player player;

        private int exp;
        private int expMax;
        private int lvl;
        private int critChance;
        private int gold;

        public int Lvl
        {
            get
            { return lvl; }
            protected set
            { lvl = value; }
        }
        public bool atack(Enemy enemy, bool enemyAtack, ProgressBar progressBarExp, ProgressBar hpBarEnemy, ProgressBar hpBarPlayer)
        {
            Form2 form2 = new Form2(enemy, enemyAtack);
            form2.ShowDialog();
            ProgressB.refreshProgress(hpBarEnemy, enemy);
            ProgressB.refreshProgress(hpBarPlayer, player);

            if (enemy.getHealth() <= 0)
            {
                ProgressB.refreshExpBar(progressBarExp, player);
                return true;
            }
            return false;
        }
        public int Exp
        {
            get
            {
                while (exp >= expMax)
                {
                    exp -= expMax;
                    expMax += Convert.ToInt32(Convert.ToDouble(expMax) * 0.5);
                    LvlUp();
                }
                return exp;
            }
            set { exp = value; }
        }
        public int ExpMax
        {
            get
            {
                while (exp >= expMax)
                {
                    exp -= expMax;
                    expMax += Convert.ToInt32(Convert.ToDouble(expMax) * 0.5);
                    LvlUp();
                }
                return expMax;
            }
            set
            {
                expMax = value;
            }
        }

        public void LvlUp()
        {
            Lvl += 1;
        }

        private Player(string name, int cordRows, int cordColums) : base(damage: 5, rangeAtack: 2, name: name, cordRows: cordRows,
            cordColums: cordColums)
        {
            Exp = 0;
            ExpMax = 10;
            Lvl = 1;
            critChance = 5;
        }

        public static Player GetInstance(string name = "", int cordRows = 0, int cordColums = 0)
        {
            if (player == null)
            {
                player = new Player(name, cordRows, cordColums);
            }
            return player;
        }

        public override int getDamage()
        {
            Random random = new Random();
            if (critChance >= random.Next(1, 101)) 
            {
                return damage * 2;
            };
            return damage;
        }

        public override int getArmor()
        {
            return armor;
        }
        public override int getRangeAtack()
        {
            return rangeAtack;
        }

        public int getGold()
        {
            return gold;
        }

        public override void Die()
        {
            MessageBox.Show("Yor Die");
        }

        public void update(ListViewItem listViewItem)
        {
            if (listViewItem.Text == "Damage")
            {
                damage += 1;
            }
        }

        public override int getHealthRegeneration()
        {
            return hpRegeneration;
        }
    }
}
