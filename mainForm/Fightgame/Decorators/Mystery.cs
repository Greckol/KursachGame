namespace Fightgame
{
    public class Mystery : EnemyDecorator
    {
        public Mystery(Enemy enemy) : base(enemy, "Mystery " + enemy.Name)
        {
            healthMax += getHealthMax() / 2;
            health += getHealth() / 2;
        }
        public override int getArmor() => enemy.getArmor() + 1;
        public override int getAtackCount() => enemy.getAtackCount() + 2;
        public override int getCellAtackCount() => enemy.getCellAtackCount() - 2;
        public override int getCritChance() => enemy.getCritChance() + 10;
        public override int getDamage() => enemy.getDamage() + 1;
        public override int getDanegerProcent() => enemy.getDanegerProcent() + 10;
        public override int getExpReward() => enemy.getExpReward() * 2;
        public override int getGoldReward() => enemy.getGoldReward() * 2;
        public override int getHealthRegeneration() => enemy.getHealthRegeneration() + 1;
        public override int getMatrixDefColumns() => enemy.getMatrixDefColumns() + 1;
        public override int getMatrixDefRows() => enemy.getMatrixDefRows() + 1;
        public override int getRangeAtack() => enemy.getRangeAtack() + 1;
        public override int getSpeed() => enemy.getSpeed() + 7;
    }
}
