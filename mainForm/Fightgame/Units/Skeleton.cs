namespace Fightgame.Units
{
    public class Skeleton: Enemy
    {
        public Skeleton() : base(name: "Skeleton", damage: 10, health: 20, healthMax: 20, healthRegeneration: 2, armor: 2, rangeAtack: 1,
            atackCount: 8, cellAtackCount: 18, dangerProcent: 15, expReward: 15, speedAtack: 8)
        { }
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

