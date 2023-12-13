using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static Fightgame.MatrixDef;

namespace Fightgame
{
    public partial class Form1 : Form
    {
        const int matrixRowsSize = 20;
        const int matrixColumsSize = 20;
        Random rand = new Random();
        Matrix matrix;
        List<Enemy> units = new List<Enemy>();
        Player player = Player.GetInstance("Genry", matrixRowsSize / 2, matrixColumsSize / 2);

        public Form1()
        {
            InitializeComponent();

            matrix = new Matrix(matrixRowsSize, matrixColumsSize, panelMain);
            panelMain.Paint += new PaintEventHandler(DrowMainMatrix);
            buttonAtack.Enabled = false;
            matrix.moveMatrix(player, units);
            addPerson(6, "slime");
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            panelMain.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        private void addPerson(int count, string type)
        {
            Enemy enemy;
            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "slime":
                        enemy = new Slime();
                        break;
                    default:
                        enemy = new Slime();
                        break;
                }
                do
                {
                    enemy.cordRows = rand.Next(0, matrix.Rows);
                    enemy.cordColums = rand.Next(0, matrix.Colums);
                } while (matrix[enemy.cordRows, enemy.cordColums] is not FreeCell || matrix[enemy.cordRows, enemy.cordColums] is Player);
                units.Add(enemy);
            }
        }
        Unit targetSearch = Player.GetInstance();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int rowMouseClick = e.Y / matrix.CellSizeColum;
            int columnMouseClick = e.X / matrix.CellSizeRow;
            targetSearch = matrix[rowMouseClick, columnMouseClick];
            label1.Text = "Содержимое клетки: " + targetSearch.Name;
            ProgressB.refreshProgress(hpBarEnemy, targetSearch);
            refreshStatus();

        }
        void refreshStatus()
        {
            if (targetSearch.Health <= 0) targetSearch = player;
            bool isNeighbor = Math.Abs(player.cordRows - targetSearch.CordRows) +
                Math.Abs(player.cordColums - targetSearch.CordColums) <= (player.RangeAtack);
            if (isNeighbor && targetSearch is not FreeCell && targetSearch != player) buttonAtack.Enabled = true;
            else buttonAtack.Enabled = false;
        }

        bool mainActiv;
        bool sideActiv;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxMain.Checked) return;
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (player.CordRows > 0 && matrix[player.cordRows - 1, player.cordColums] is FreeCell) player.cordRows--;
                    break;
                case Keys.S:
                    if (player.CordRows < matrix.Rows - 1 && matrix[player.cordRows + 1, player.cordColums] is FreeCell) player.CordRows++;
                    break;
                case Keys.A:
                    if (player.CordColums > 0 && matrix[player.cordRows, player.cordColums - 1] is FreeCell) player.CordColums--;
                    break;
                case Keys.D:
                    if (player.CordColums < matrix.Colums - 1 && matrix[player.cordRows, player.cordColums + 1] is FreeCell) player.CordColums++;
                    break;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S ||
                e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            {
                checkBoxMain.Checked = true;

                matrix.moveMatrix(player, units);
                panelMain.Invalidate();

            };
        }

        Keys toKeys(int number)
        {
            switch (number)
            {
                case 1:
                    return Keys.W;
                case 2:
                    return Keys.S;
                case 3:
                    return Keys.A;
                case 4:
                    return Keys.D;
                default:
                    return Keys.O;
            }
        }
        private void Move(List<Enemy> unit)
        {
            foreach (var i in unit)
            {
                int key = rand.Next(1, 5);
                switch (toKeys(key))
                {
                    case Keys.W:
                        if (i.CordRows > 0 && matrix[i.CordRows - 1, i.CordColums] is FreeCell) i.CordRows--;
                        break;
                    case Keys.S:
                        if (i.CordRows < matrix.Rows - 1 && matrix[i.CordRows + 1, i.CordColums] is FreeCell) i.CordRows++;
                        break;
                    case Keys.A:
                        if (i.cordColums > 0 && matrix[i.CordRows, i.CordColums - 1] is FreeCell) i.CordColums--;
                        break;
                    case Keys.D:
                        if (i.cordColums < matrix.Colums - 1 && matrix[i.CordRows, i.CordColums + 1] is FreeCell) i.CordColums++;
                        break;
                }
                matrix.moveMatrix(player, units);
            }
        }


        private void DrowMainMatrix(object sender, PaintEventArgs e)
        {
            refreshStatus();
            Graphics g = e.Graphics;
            matrix.moveMatrix(player, units);

            for (var i = 0; i < matrix.Rows; i++)
            {
                for (var b = 0; b < matrix.Colums; b++)
                {
                    if (checkBoxRangeEnemys.Checked) matrix.DrawAll(g, player, units, i, b);
                    else matrix.DrawAll(g, player, i, b);
                }
            }
        }


        private void buttonAtack_Click(object sender, EventArgs e)
        {
            if (targetSearch is Enemy enemy)
            {
                player.atack(enemy, units, matrix, progressBarExp, hpBarEnemy, hpBarPlayer);
                if (enemy.Health <= 0) units.Remove(enemy);
            }
            buttonAtack.Enabled = false;
            panelMain.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressB.refreshExpBar(progressBarExp, player);
            ProgressB.refreshProgress(hpBarPlayer, player);
        }

        private void buttonNextTurn_Click(object sender, EventArgs e)
        {
            checkBoxMain.Checked = false;
            checkBoxSide.Checked = false;
            List<Enemy> temp = new List<Enemy>();
            foreach (var i in units)
            {
                if (i.checkRangeToPlayer() && i.tryToAtackPlayer())
                {
                    if (player.atack(i, units, matrix, progressBarExp, hpBarEnemy, hpBarPlayer))
                    {
                        temp.Add(i);
                    }
                }
            }
            foreach (var t in temp)
            {
                units.Remove(t);
            }
            Move(units);
            panelMain.Invalidate();
        }

        private void checkBoxRangeEnemys_CheckedChanged(object sender, EventArgs e)
        {
            panelMain.Invalidate();
        }
    }
}