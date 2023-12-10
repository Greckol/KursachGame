using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class Player: Unit
    {
        private static Player player;

        public override bool checkVision()
        {
            throw new NotImplementedException();
        }

        public override bool checkAtackRange(List<List<char>> matrix)
        {
            for (var i = 0; i < matrix.Count; i++)
            {
                for (var b = 0; b < matrix[i].Count; b++)
                {
                    bool isNeighbor = Math.Abs(player.cordColums - i) + Math.Abs(player.cordRows - b) <= (player.RangeAtack);
                    if (isNeighbor && matrix[i][b] != '#' && matrix[i][b] != 'P') return true;
                }
            }
            return false;
        }

        public void atack(Matrix matrix, List<Unit> units, ProgressBar healthBarPlayer)
        {
            for (int i = cordRows-RangeAtack; i <= cordRows + RangeAtack && i >= 0 &&  i < matrix.Rows; i++)
            {
                for (int b = cordColums-rangeAtack; b <= cordColums + RangeAtack && b >= 0 && b < matrix.Colums; b++)
                {
                    bool isNeighbor = Math.Abs(cordRows - i) + Math.Abs(cordColums - b) <= (RangeAtack);
                    if (!matrix[i, b].Invulnerable && matrix[i, b] != player && isNeighbor)
                    {
                        Form form2 = new Form2();
                        form2.Show();
                        //fightLogic(matrix, i, b, units);
                        //ProgressB.refreshProgress(healthBarPlayer, player);
                    }
                }
            }
        }

        private void fightLogic(Matrix matrix, int row, int col, List<Unit> units)
        {
            if (checkDie(player)) 
            { 
                PlayerDie(); 
                return; 
            };

            if (checkDie(matrix[row, col]))
            {
                units.Remove(matrix[row, col]); 
                return;
            }

            matrix[row, col].Health -= Damage;

            if (checkDie(matrix[row, col]))
            {
                units.Remove(matrix[row, col]);
                return;
            }

            Health -= matrix[row, col].Damage;

            if (checkDie(player))
            {
                PlayerDie();
                return;
            };
        }

        void PlayerDie()
        {
            ///
        }

        private bool checkDie(Unit unit)
        {
            if (unit.Health < 1)
            {
                return true;
            }
            return false;
        }

        private Player(string name, int cordRows, int cordColums) : base()
        {
            Name = name;
            CordRows = cordRows;
            CordColums = cordColums;
            Simvol = 'P';
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
