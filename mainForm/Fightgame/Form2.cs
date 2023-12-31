﻿namespace Fightgame
{
    public partial class Form2 : Form
    {
        Rectangle rectTarget;
        Rectangle rectSmall;
        Enemy enemy;
        Player player = Player.GetInstance();
        bool autoMode;
        public Form2(Enemy enemy, bool enemyAtack, bool autoMode)
        {
            this.autoMode = autoMode;
            this.enemy = enemy;
            InitializeComponent();
            if (enemyAtack) labelEnemyName.Text = "You are being attacked\n" + enemy.Name;
            else labelEnemyName.Text = enemy.Name;
            this.ControlBox = false;
            this.KeyPreview = true;
            //this.DoubleBuffered = true;
            matrixD = new MatrixDef(enemy.getMatrixDefRows(), enemy.getMatrixDefColumns(), panel2);
            panel1.Paint += new PaintEventHandler(Panel1_Paint);
            panel2.Paint += new PaintEventHandler(matrixVisuble);
            panel2.Hide();
            panel1.Hide();
            timer1.Interval = 40;
            speed = enemy.getSpeed();
            //timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer2.Tick += timer2_Tick;
            /*if (autoMode) */
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);
            ProgressB.refreshLabelHealth(labelMyHealth, labelEnemyHealth, enemy);
        }

        protected void timer1_Tick(object sender, EventArgs e)
        {
            if (autoMode)
            {
                if (flagAutoHit)
                {
                    if (rectTarget.Contains(rectSmall))
                    {
                        buttonHit.PerformClick();
                    }
                }
                else
                {
                    buttonHit.PerformClick();
                }
            }
            x += speed;
            if (x >= panel1.ClientSize.Width - mainBorderWidth - atackLineWidth || x <= 0)
            {
                speed = -speed;

            }
            panel1.Invalidate(new Rectangle(x + mainBorderWidth / 2, mainBorderWidth / 2, atackLineWidth, panel1.ClientSize.Height - mainBorderWidth - 1));
            panel1.Invalidate(new Rectangle(x + mainBorderWidth / 2 - speed, mainBorderWidth / 2, atackLineWidth, panel1.Height - mainBorderWidth - 1));
        }
        protected void timer2_Tick(object sender, EventArgs e)
        {
            bool flag = false;

            if (player.getHealth() <= 0)
            {
                this.Close();
                player.Die();
            }
            if (timer2TickCount % 2 == 0)
            {
                enemy.AtackPattern(matrixD);
            }
            else
            {
                flag = true;
            }
            matrixD.moveMatrix(flag);
            panel2.Invalidate();
            if (matrixD.matrix[matrixD.CordRowPlayer][matrixD.CordColumnPlayer] == 'T')
            {
                int value = player.takedamage(enemy.Hit());
                labelInfo2.Text = '-' + value.ToString();
                ProgressB.refreshLabelHealth(labelMyHealth, labelEnemyHealth, enemy);
                ProgressB.refreshHpBar(hpBarPlayer, player);
            }
            if (flag) matrixD.enemys.Clear();
            timer2TickCount++;
            if (enemy.getAtackCount() <= timer2TickCount)
            {
                buttonEscape.Enabled = true;
                timer2.Stop();
                panel2.Visible = false;
                x = 0;
                matrixD.enemys.Clear();
                matrixD.moveMatrix();
                buttonHit.Enabled = true;
                if (autoMode) buttonHit.PerformClick();
            }
        }
        MatrixDef matrixD;
        int timer2TickCount;
        int x = 0;
        int speed;
        int mainBorderWidth = 24; // только четное
        int atackLineWidth = 5;
        SolidBrush color = new SolidBrush(Color.Red);

        protected void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            rectTarget = new Rectangle(panel1.Width / 2, mainBorderWidth / 2, 100, panel1.Height);
            rectSmall = new Rectangle(x + mainBorderWidth / 2, mainBorderWidth / 2, atackLineWidth, panel1.ClientSize.Height - mainBorderWidth - 1);
            Rectangle clearRect = new Rectangle(x + mainBorderWidth / 2, mainBorderWidth / 2, atackLineWidth, panel1.ClientSize.Height - mainBorderWidth - 1);
            Pen p = new Pen(Color.Black);
            p.Width = mainBorderWidth;
            Rectangle rect = new Rectangle(0, 0, panel1.ClientSize.Width - 1, panel1.ClientSize.Height - 1);
            g.FillRectangle(new SolidBrush(panel1.BackColor), clearRect);
            g.FillRectangle(color, rectSmall);
            g.DrawRectangle(Pens.Red, rectTarget);
            g.DrawRectangle(p, rect);
        }

        bool flag = true;
        bool flagAutoHit = false;
        private void buttonHit_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                buttonEscape.Enabled = false;
                panel1.Visible = true;
                if (autoMode)
                {
                    Random random = new Random();
                    if (1 == random.Next(1, 3)) flagAutoHit = true;
                    else flagAutoHit = false;
                }
                timer1.Enabled = true;
                return;
            }

            else if (rectTarget.Contains(rectSmall))
            {
                int value = enemy.takedamage(player.Hit());
                labelInfo.Text = '-' + value.ToString();
                ProgressB.refreshLabelHealth(labelMyHealth, labelEnemyHealth, enemy);
                ProgressB.refreshHpBar(hpBarEnemy, enemy);
                if (enemy.getHealth() <= 0)
                {
                    this.Close();
                    return;
                }
            }
            else
            {
                labelInfo.Text = "Miss";
            }
            flag = true;
            panel1.Visible = false;
            matrixD.moveMatrix();
            panel2.Visible = true;
            timer1.Stop();
            timer2.Enabled = true;
            timer2.Interval = 700;
            timer2TickCount = 0;
            buttonHit.Enabled = false;
            this.Focus();
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (matrixD.CordRowPlayer > 0) matrixD.CordRowPlayer--;
                    break;
                case Keys.S:
                    if (matrixD.CordRowPlayer < matrixD.Rows - 1) matrixD.CordRowPlayer++;
                    break;
                case Keys.A:
                    if (matrixD.CordColumnPlayer > 0) matrixD.CordColumnPlayer--;
                    break;
                case Keys.D:
                    if (matrixD.CordColumnPlayer < matrixD.Colums - 1) matrixD.CordColumnPlayer++;
                    break;
                default:
                    break;
            }
            matrixD.moveMatrix();
            panel2.Invalidate();
        }
        void matrixVisuble(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (var i = 0; i < matrixD.Rows; i++)
            {
                for (var b = 0; b < matrixD.Colums; b++)
                {
                    matrixD.DrawAll(g, i, b);
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ProgressB.refreshHpBar(hpBarEnemy, enemy);
            ProgressB.refreshHpBar(hpBarPlayer, player);
            if (autoMode) buttonHit.PerformClick();
        }
        private void buttonEscape_Click(object sender, EventArgs e)
        {
            player.takedamage(enemy.Hit());
            ProgressB.refreshHpBar(hpBarPlayer, player);
            this.Close();
            return;
        }
    }
}
