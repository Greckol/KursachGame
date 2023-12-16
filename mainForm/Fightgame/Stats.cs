using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    public class Stats: Shop
    {
        Unit unit;
        public Stats(ListView listview, Unit unit): base(listview)
        {
            this.unit = unit;
        }
        protected override void FillColumns(ListView listView)
        {
            listView.Columns.Add("Stat", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Value", -2, HorizontalAlignment.Left);
        }

        //public const string name = "Name";
        // Player

        public const string exp = "Exp";
        public const string expMax = "ExpMax";
        public const string lvl = "Lvl";
        public const string gold = "Gold";
        // Enemy
        public const string dangerProcent = "DangerProcent";
        public const string atackCount = "AtackCount";
        public const string cellAtackCount = "CellAtackCount";
        public const string speed = "Speed";
        public const string matrixDefRows = "MatrixDefRows";
        public const string matrixDefColumns = "MatrixDefColumns";
        public const string expReward = "ExpReward";
        public const string goldReward = "GoldReward";
        public void setUnit(Unit unit, ListView listView)
        {
            this.unit = unit;
            dictionaryShop.Clear();
            fill(listView);
        }
        
        public void refreshStats(ListView listView, Unit unit)
        {
            setUnit(unit, listView);
            //refresh(listView);
        }
        public override void fill(ListView listView)
        {
            dictionaryShop.Add(damage, unit.getDamage());
            dictionaryShop.Add(health, unit.getHealth());
            dictionaryShop.Add(healthMax, unit.getHealthMax());
            dictionaryShop.Add(healthRegeneration, unit.getHealthRegeneration());
            dictionaryShop.Add(armor, unit.getArmor());
            dictionaryShop.Add(rangeAtack, unit.getRangeAtack());
            dictionaryShop.Add(critChance, unit.getCritChance());
            //dictionaryShop.Add(name, unit.Name);
            if (unit is Player player)
            {
                dictionaryShop.Add(exp, player.getExp());
                dictionaryShop.Add(expMax, player.getExpMax());
                dictionaryShop.Add(lvl, player.getLvl());
                dictionaryShop.Add(gold, player.getGold());
            }
            else if (unit is Enemy enemy)
            {
                dictionaryShop.Add(dangerProcent, enemy.getDanegerProcent());
                dictionaryShop.Add(atackCount, enemy.getAtackCount());
                dictionaryShop.Add(cellAtackCount, enemy.getCellAtackCount());
                dictionaryShop.Add(speed, enemy.getSpeed());
                dictionaryShop.Add(expReward, enemy.getExpReward());
                dictionaryShop.Add(goldReward, enemy.getGoldReward());
                dictionaryShop.Add(matrixDefRows, enemy.getMatrixDefRows());
                dictionaryShop.Add(matrixDefColumns, enemy.getMatrixDefColumns());

            }
            refresh(listView);
        }
    }
}
