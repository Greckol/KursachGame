using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fightgame
{
    public partial class Form2 : Form
    {
        Rectangle rectTarget;
        Rectangle rectSmall;
        public Form2()
        {
            InitializeComponent();
            //paint();
            //panel2.Paint += new PaintEventHandler(Panel2_Paint);

            panel1.Paint += new PaintEventHandler(Panel1_Paint);
            this.DoubleBuffered = true;
            timer1.Interval = 40;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
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

        private void buttonHit_Click(object sender, EventArgs e)
        {
            if (rectTarget.Contains(rectSmall))
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("No");
            }


        }
    }
}
