namespace Fightgame.Units
{
    public class Dragon: Enemy
    {
        public Dragon(): base(name: "Dragon", damage: 30, health: 100, healthMax: 100, healthRegeneration: 5, armor: 8, rangeAtack: 2,
            atackCount: 20, cellAtackCount: 20, dangerProcent: 20, expReward: 50, speedAtack: 15) { }
        public override int getArmor() => armor;
        public override int getAtackCount() => atackCount;
        public override Enemy GetBaseComponent() => this;
        public override int getCellAtackCount() => cellAtackCount;
        public override int getCritChance() => critChance;
        public override int getDamage() => damage;
        public override int getDanegerProcent() => dangerProcent;
        public override int getExpReward() => expReward;
        public override int getGoldReward() => goldReward;
        public override int getHealthRegeneration() => healthRegeneration;
        public override int getMatrixDefColumns() => matrixDefColumns;
        public override int getMatrixDefRows() => matrixDefRows;
        public override int getRangeAtack() => rangeAtack;
        public override int getSpeed() => speedAtack;
    }
}
