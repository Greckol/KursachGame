namespace Fightgame
{
    public abstract class EnemyDecorator: Enemy
    {
        protected Enemy enemy;
        public EnemyDecorator(Enemy enemy, string name): 
        base(name: name, healthMax: enemy.getHealthMax(), health: enemy.getHealth())
        {
            this.enemy = enemy;
        }
        public override Enemy GetBaseComponent() => enemy.GetBaseComponent();
    }
}
