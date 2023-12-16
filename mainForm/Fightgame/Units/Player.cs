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
        private int gold;

        public int getLvl()
        {
            return lvl;
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

        public int getExp() 
        {
            while (exp >= expMax)
            {
                exp -= expMax;
                expMax += Convert.ToInt32(Convert.ToDouble(expMax) * 0.5);
                LvlUp();
            }
            return exp;
        }
        public int getExpMax()
        {
            while (exp >= expMax)
            {
                exp -= expMax;
                expMax += Convert.ToInt32(Convert.ToDouble(expMax) * 0.5);
                LvlUp();
            }
            return expMax;
        }
       

        public void LvlUp()
        {
            lvl += 1;

            
            damage += 2;
            damage += Convert.ToInt32(Convert.ToDouble(damage) * 0.4);

            armor += 1;

            healthMax += 10;
            health += 10;
            health = healthMax;

            if (lvl % 5 == 0)
            {
                critChance += 2;
                rangeAtack += 1;
                healthRegeneration += 1;
            }

        }
        public void ExpUp(int value)
        {
            exp += value;
            getExp(); // костыль
        }

        public void GoldUp(int value)
        {
            gold += value;
        }

        private Player(string name, int cordRows, int cordColums) : base(damage: 20, rangeAtack: 10, name: name, cordRows: cordRows,
            cordColums: cordColums)
        {
            exp = 0;        // если exp > expMax уровенть не повысится
            expMax = 10;
            lvl = 1;
            gold = 1501;
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
            switch (listViewItem.Text)
            {
                case Shop.damage:
                    damage += 1;
                    break;
                case Shop.healthMax:
                    healthMax += 1;
                    health += 1;
                    break;
                case Shop.critChance:
                    critChance += 1;
                    break;
                case Shop.rangeAtack:
                    rangeAtack += 1;
                    break;
                case Shop.armor:
                    armor += 1;
                    break;
                case Shop.health:
                    health = healthMax;
                    break;
                default:
                    break;
            }
            gold -= Convert.ToInt32(listViewItem.SubItems[1].Text);
        }

        public override int getHealthRegeneration()
        {
            return healthRegeneration;
        }

        public override int getCritChance()
        {
           return critChance;
        }
    }
}
