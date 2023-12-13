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
    internal class Player: Unit
    {
        private static Player player;

        public int exp;
        public int expMax;

        public bool atack(Enemy enemy, List<Enemy> enemys, Matrix matrix, ProgressBar progressBarExp, ProgressBar hpBarEnemy, ProgressBar hpBarPlayer)
        {
            Form2 form2 = new Form2();
            form2.setEnemy(enemy);
            form2.ShowDialog();
            ProgressB.refreshProgress(hpBarEnemy, enemy);
            ProgressB.refreshProgress(hpBarPlayer, player);

            if (enemy.Health <= 0)
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
            set { expMax = value; }
        }

        public int Hit(Unit u)
        {
            int hit = Damage;
            u.health -= hit;
            if (u.health < 0)
            {
                u.health = 0;
            }
           return hit;
        }

        public void LvlUp()
        {
            Lvl += 1;
        }

        private Player(string name, int cordRows, int cordColums) : base()
        {
            Name = name;
            CordRows = cordRows;
            CordColums = cordColums;
            Damage = 5;
            Exp = 0;
            ExpMax = 10;
            RangeAtack = 2;
        }

        public static Player GetInstance(string name = "", int cordRows = 0, int cordColums = 0)
        {
            if (player == null)
            {
                player = new Player(name, cordRows, cordColums);
            }
            return player;
        }

        
    }
}
