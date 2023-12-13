using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fightgame
{
    public partial class Form2 : Form
    {
        Rectangle rectTarget;
        Rectangle rectSmall;
        Enemy enemy;
        Player player = Player.GetInstance();

        public Form2(Enemy enemy)
        {
            this.enemy = enemy;
            InitializeComponent();
            this.ControlBox = false;
            this.KeyPreview = true;
            this.DoubleBuffered = true;
            matrixD = new MatrixDef(enemy.MatrixDefRows, enemy.MatrixDefColumns, panel2);
            panel1.Paint += new PaintEventHandler(Panel1_Paint);
            panel2.Paint += new PaintEventHandler(matrixVisuble);
            panel2.Hide();
            panel1.Hide();
            timer1.Interval = 40;
            //timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer2.Tick += timer2_Tick;
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);
        }

        protected void timer1_Tick(object sender, EventArgs e)
        {
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

            if (player.Health <= 0)
            {
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
                player.Health -= enemy.damage;
                ProgressB.refreshProgress(hpBarPlayer, player);
            }
            if (flag) matrixD.enemys.Clear();
            timer2TickCount++;
            if (enemy.AtackCount <= timer2TickCount)
            {
                buttonEscape.Enabled = true;
                timer2.Stop();
                panel2.Visible = false;
                x = 0;
                matrixD.enemys.Clear();
                matrixD.moveMatrix();
            }
        }
        MatrixDef matrixD;
        int timer2TickCount;
        int x = 0;
        int speed = 5;
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
        private void buttonHit_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                buttonEscape.Enabled = false;
                panel1.Visible = true;
                timer1.Enabled = true;
                return;
            }

            else if (rectTarget.Contains(rectSmall))
            {
                labelInfo.Text = '-' + player.Hit(enemy).ToString();
                ProgressB.refreshProgress(hpBarEnemy, enemy);
                if (enemy.Health <= 0)
                {
                    enemy.Die();
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
            labelEnemyName.Text = enemy.Name;
            ProgressB.refreshProgress(hpBarEnemy, enemy);
            ProgressB.refreshProgress(hpBarPlayer, player);
        }

        private void buttonEscape_Click(object sender, EventArgs e)
        {
            player.Health -= enemy.damage;
            ProgressB.refreshProgress(hpBarPlayer, player);
            this.Close();
            return;
        }
    }
}
