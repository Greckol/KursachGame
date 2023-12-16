using System.CodeDom;
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
        Player player;
        Shop shop;
        Stats stats;
        public Form1()
        {
            InitializeComponent();
            player = Player.GetInstance("Genry", matrixRowsSize / 2, matrixColumsSize / 2);
            targetSearch = Player.GetInstance();
            label1.Text = $"Содержимое клетки {player.Name}";
            labelStatName.Text = player.Name;
            shop = new Shop(listView1);
            shop.fill(listView1);
            //shop.refresh(listView1);
            listView1.SelectedIndexChanged += listView_SelectedIndexChanged;

            stats = new Stats(listView2, targetSearch);
            stats.fill(listView2);
            //stats.refresh(listView2);

            labelLVL.Text = player.getLvl().ToString();
            matrix = new Matrix(matrixRowsSize, matrixColumsSize, panelMain);
            panelMain.Paint += new PaintEventHandler(DrowMainMatrix);
            buttonAtack.Enabled = false;
            matrix.moveMatrix(player, units);
            addPerson(1, "slime");
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            panelMain.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressB.refreshExpBar(progressBarExp, player);
            ProgressB.refreshProgress(hpBarPlayer, player);
        }

        ListViewItem selectedItem;
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            selectedItem = listView1.SelectedItems[0];
            shop.buttonEnterRefresh(selectedItem, buttonEnterUp);

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
                        enemy = new Vampire(enemy);
                        //enemy = new Mega(enemy);
                        break;
                    default:
                        enemy = new Slime();
                        break;
                }
                do
                {
                    enemy.CordRows = rand.Next(0, matrix.Rows);
                    enemy.CordColums = rand.Next(0, matrix.Colums);
                } while (matrix[enemy.CordRows, enemy.CordColums] is not FreeCell || matrix[enemy.CordRows, enemy.CordColums] is Player);
                units.Add(enemy);
            }
        }
        Unit targetSearch;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int rowMouseClick = e.Y / matrix.CellSizeColum;
            int columnMouseClick = e.X / matrix.CellSizeRow;
            targetSearch = matrix[rowMouseClick, columnMouseClick];
            label1.Text = "Содержимое клетки: " + targetSearch.Name;
            if (targetSearch is not FreeCell) labelStatName.Text = targetSearch.Name;
            ProgressB.refreshProgress(hpBarEnemy, targetSearch);
            refreshStatus();
            stats.refreshStats(listView2, targetSearch);

        }
        void refreshStatus()
        {
            if (targetSearch.getHealth() <= 0) targetSearch = player;
            bool isNeighbor = Math.Abs(player.CordRows - targetSearch.CordRows) +
                Math.Abs(player.CordColums - targetSearch.CordColums) <= (player.getRangeAtack());
            if (isNeighbor && targetSearch is not FreeCell && targetSearch != player) buttonAtack.Enabled = true;
            else buttonAtack.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxMain.Checked) return;
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (player.CordRows > 0 && matrix[player.CordRows - 1, player.CordColums] is FreeCell) player.CordRows--;
                    break;
                case Keys.S:
                    if (player.CordRows < matrix.Rows - 1 && matrix[player.CordRows + 1, player.CordColums] is FreeCell) player.CordRows++;
                    break;
                case Keys.A:
                    if (player.CordColums > 0 && matrix[player.CordRows, player.CordColums - 1] is FreeCell) player.CordColums--;
                    break;
                case Keys.D:
                    if (player.CordColums < matrix.Colums - 1 && matrix[player.CordRows, player.CordColums + 1] is FreeCell) player.CordColums++;
                    break;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S ||
                e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            {
                checkBoxMain.Checked = true;
                player.healthRegen();
                ProgressB.refreshProgress(hpBarPlayer, player);

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
                        if (i.CordColums > 0 && matrix[i.CordRows, i.CordColums - 1] is FreeCell) i.CordColums--;
                        break;
                    case Keys.D:
                        if (i.CordColums < matrix.Colums - 1 && matrix[i.CordRows, i.CordColums + 1] is FreeCell) i.CordColums++;
                        break;
                }
                i.healthRegen();
                if (i == targetSearch)
                {
                    stats.refreshStats(listView2, targetSearch);
                    ProgressB.refreshProgress(hpBarEnemy, i);
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
                    if (checkBoxRangeEnemys.Checked) matrix.DrawAll(g, this, player, units, i, b);
                    else matrix.DrawAll(g, this, player, i, b);
                }
            }
        }


        private void buttonAtack_Click(object sender, EventArgs e)
        {
            if (targetSearch is Enemy enemy)
            {
                if (player.atack(enemy, false, progressBarExp, hpBarEnemy, hpBarPlayer))
                {
                    labelLVL.Text = player.getLvl().ToString();
                    units.Remove(enemy);
                };
                stats.refreshStats(listView2, targetSearch);
                panelMain.Invalidate();
            }
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
                    if (player.atack(i, true, progressBarExp, hpBarEnemy, hpBarPlayer))
                    {
                        labelLVL.Text = player.getLvl().ToString();
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



        private void buttonEnterUp_Click(object sender, EventArgs e)
        {
            player.update(selectedItem);
            if (selectedItem.Text == Shop.rangeAtack) panelMain.Invalidate();
            shop.refreshCost(listView1, selectedItem);
            foreach (ListViewItem i in listView1.Items)
            {
                if (i.Text == selectedItem.Text)
                {
                    selectedItem = i;
                    break;
                }
            }
            shop.buttonEnterRefresh(selectedItem, buttonEnterUp);


            stats.refreshStats(listView2, targetSearch);

        }

        private void labelStatName_Click(object sender, EventArgs e)
        {

        }
    }
}