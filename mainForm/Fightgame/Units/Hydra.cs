namespace Fightgame.Units
{
    public class Hydra: Enemy
    {
        public Hydra() : base(name: "Hydra", damage: 15, health: 50, healthMax: 50, healthRegeneration: 10, armor: 2, rangeAtack: 3,
            atackCount: 15, cellAtackCount: 15, dangerProcent: 25, expReward: 35, speedAtack: 12)
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
