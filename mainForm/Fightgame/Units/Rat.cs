namespace Fightgame
{
    public class Rat : Enemy
    {
        public Rat() : base(name: "Rat", damage: 4, health: 8, healthMax: 8, healthRegeneration: 1, armor: 1, rangeAtack: 1,
            atackCount: 10, cellAtackCount: 15, dangerProcent: 10, expReward: 5, goldReward: 7, speedAtack: 5){ }
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