namespace Fightgame
{
    public class Mega : EnemyDecorator
    {
        public Mega(Enemy enemy) : base(enemy, "Mega " + enemy.Name)
        {
            healthMax = getHealthMax() * 2;
            health = getHealth() * 2;
        }
        public override int getArmor() => enemy.getArmor() + enemy.getArmor() / 3;
        public override int getAtackCount() => enemy.getAtackCount() * 2;
        public override int getCellAtackCount() => enemy.getCellAtackCount() * 2;
        public override int getCritChance() => enemy.getCritChance() * 2;
        public override int getDamage() => enemy.getDamage() * 2;
        public override int getDanegerProcent() => enemy.getDanegerProcent() * 2;
        public override int getExpReward() => enemy.getExpReward() * 5;
        public override int getGoldReward() => enemy.getGoldReward() * 3;
        public override int getHealthRegeneration() => enemy.getHealthRegeneration() * 2;
        public override int getMatrixDefColumns() => enemy.getMatrixDefColumns() + enemy.getMatrixDefColumns() / 2;
        public override int getMatrixDefRows() => enemy.getMatrixDefRows() + enemy.getMatrixDefColumns() / 2;
        public override int getRangeAtack() => enemy.getRangeAtack() + 3;
        public override int getSpeed() => enemy.getSpeed() * 2;

    }
}