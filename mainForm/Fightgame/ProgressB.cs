namespace Fightgame
{
    public class ProgressB
    {
        static public void refreshHpBar(ProgressBar progressB, Unit u)
        {
            progressB.Minimum = 0;
            progressB.Maximum = u.getHealthMax();
            progressB.Value = u.getHealth();
        }
        static public void refreshExpBar(ProgressBar expBar, Player player)
        {
            expBar.Minimum = 0;
            expBar.Maximum = player.getExpMax();
            expBar.Value = player.getExp();
        }
        static public void refreshLabelHealth(Label labelMyHealth, Label labelEnemyHealth, Unit unit)
        {
            labelMyHealth.Text = Player.GetInstance().getHealth().ToString();
            if (unit is FreeCell) labelEnemyHealth.Text = " ";
            else labelEnemyHealth.Text = unit.getHealth().ToString();
        }
    }
}
