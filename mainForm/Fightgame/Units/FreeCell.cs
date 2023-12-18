namespace Fightgame
{
    public class FreeCell : Unit
    {
        public FreeCell(): base(name: "#", health: 0) {}
        public override void Die() {}
        public override int getArmor() => armor;
        public override int getCritChance() => critChance;
        public override int getDamage() => damage;
        public override int getHealthRegeneration() => healthRegeneration;
        public override int getRangeAtack() => rangeAtack;
    }
}
