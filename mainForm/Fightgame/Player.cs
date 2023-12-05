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
                    bool isNeighbor = Math.Abs(player.cordColums - i) + Math.Abs(player.cordRows - b) < (player.RangeAtack+1);
                    if (isNeighbor && matrix[i][b] != '#' && matrix[i][b] != 'P') return true;
                }
            }
            return false;
        }

        public void atack(List<List<Unit>> matrix, List<Unit> units)
        {
            for (int i = cordRows-RangeAtack; i <= cordRows + RangeAtack; i++)
            {
                for (int b = cordColums-rangeAtack; b <= cordColums + RangeAtack; b++)
                {
                    bool isNeighbor = Math.Abs(cordRows - i) + Math.Abs(cordColums - b) < (RangeAtack + 1);
                    if (!matrix[i][b].Invulnerable && matrix[i][b] != player && isNeighbor)
                    {
                        while (matrix[i][b].Health > 0)
                        {
                            matrix[i][b].Health -= Damage;
                            if (matrix[i][b].Health <= 0)
                            {
                                units.Remove(matrix[i][b]);
                            }
                        }
                    }
                }
            }

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
