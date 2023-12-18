namespace Fightgame
{
    public class Player : Unit
    {
        private static Player player;
        private Player(string name, int cordRows, int cordColums) :
            base(damage: 5, rangeAtack: 2, healthMax: 10, health: 10, 
                name: name, cordRows: cordRows, cordColums: cordColums)
        {
            exp = 0;        
            expMax = 10;
            lvl = 1;
            gold = 15;
            critChance = 5;
        }
        public static Player GetInstance(string name = "", int cordRows = 0, int cordColums = 0)
        {
            if (player == null)
            {
                player = new Player(name, cordRows, cordColums);
            }
            return player;
        }
        private int exp;
        private int expMax;
        private int lvl;
        private int gold;
        public int getLvl()
        {
            return lvl;
        }
        public bool atack(Enemy enemy, bool enemyAtack, ProgressBar progressBarExp, ProgressBar hpBarEnemy, ProgressBar hpBarPlayer, bool autoMod)
        {
            Form2 form2 = new Form2(enemy, enemyAtack, autoMod);
            form2.ShowDialog();
            ProgressB.refreshHpBar(hpBarEnemy, enemy);
            ProgressB.refreshHpBar(hpBarPlayer, player);
            if (enemy.getHealth() <= 0)
            {
                ProgressB.refreshExpBar(progressBarExp, player);
                return true;
            }
            return false;
        }
        public int getExp() 
        {
            while (exp >= expMax)
            {
                exp -= expMax;
                expMax += Convert.ToInt32(Convert.ToDouble(expMax) * 0.5);
                LvlUp();
            }
            return exp;
        }
        public int getExpMax()
        {
            while (exp >= expMax)
            {
                exp -= expMax;
                expMax += Convert.ToInt32(Convert.ToDouble(expMax) * 0.5);
                LvlUp();
            }
            return expMax;
        }
        public void LvlUp()
        {
            lvl += 1;
            damage += 2;
            damage += damage / 4;
            armor += 1;
            critChance += 1;
            healthMax += 10;
            healthMax += healthMax / 5;
            health = healthMax;
            if (lvl % 5 == 0)
            {
                critChance += 1;
                rangeAtack += 1;
                healthRegeneration += 1;
            }
        }
        public void ExpUp(int value)
        {
            exp += value;
            getExp(); // костыль
        }
        public void GoldUp(int value)
        {
            gold += value;
        }
        public override int getDamage() => damage;
        public override int getArmor() => armor;
        public override int getRangeAtack() => rangeAtack;
        public int getGold() => gold;
        public override int getHealthRegeneration() => healthRegeneration;
        public override int getCritChance() => critChance;
        public override void Die() { return; }
        public void update(ListViewItem listViewItem)
        {
            switch (listViewItem.Text)
            {
                case Shop.damage:
                    damage += 1;
                    break;
                case Shop.healthMax:
                    healthMax += 1;
                    health += 1;
                    break;
                case Shop.critChance:
                    critChance += 1;
                    break;
                case Shop.rangeAtack:
                    rangeAtack += 1;
                    break;
                case Shop.armor:
                    armor += 1;
                    break;
                case Shop.health:
                    health = healthMax;
                    break;
                case Shop.healthRegeneration:
                    healthRegeneration += 1;
                    break;
                default:
                    break;
            }
            gold -= Convert.ToInt32(listViewItem.SubItems[1].Text);
        }
    }
}
