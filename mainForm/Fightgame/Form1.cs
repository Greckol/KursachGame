using Fightgame.Units;
using System.CodeDom;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static Fightgame.MatrixDef;
using static System.Windows.Forms.DataFormats;

namespace Fightgame
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        Matrix matrix;
        List<Enemy> units = new List<Enemy>();
        Player player;
        Shop shop;
        Stats stats;

        public Form1(string difficulty, int matrixRowsSize, int matrixColumsSize, string plyaerName)
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            player = Player.GetInstance(plyaerName, matrixRowsSize / 2, matrixColumsSize / 2);
            targetSearch = Player.GetInstance();
            ///
            shop = new Shop(listView1);
            shop.fill(listView1);
            listView1.SelectedIndexChanged += listView_SelectedIndexChanged;
            stats = new Stats(listView2, targetSearch);
            stats.fill(listView2);
            matrix = new Matrix(matrixRowsSize, matrixColumsSize, panelMain);
            panelMain.Paint += new PaintEventHandler(DrowMainMatrix);
            buttonAtack.Enabled = false;
            matrix.moveMatrix(player, units);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            panelMain.MouseClick += new MouseEventHandler(Form1_MouseClick);
            this.difficulty = difficulty;
            startEnemys(difficulty);
        }

        string difficulty;
        const string slime = "slime";
        const string skeleton = "skeleton";
        const string hydra = "hydra";
        const string dragon = "dragon";


        void startEnemys(string difficulty)
        {
            switch (difficulty)
            {
                case FormMenu.easy:
                    addPerson(3, slime);
                    break;
                case FormMenu.normal:
                    addPerson(4, slime);
                    break;
                case FormMenu.hard:
                    addPerson(5, slime);
                    break;
                case FormMenu.impossible:
                    addPerson(5, slime);
                    addPerson(1, skeleton);
                    break;
                case FormMenu.nightmare:
                    addPerson(5, slime);
                    addPerson(2, skeleton);
                    addPerson(1, hydra);
                    break;
                default:
                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressB.refreshHpBar(hpBarPlayer, player);
            ProgressB.refreshHpBar(hpBarEnemy, targetSearch);
            ProgressB.refreshLabelHealth(labelMyHealth, labelEnemyHealth, targetSearch);
            ProgressB.refreshExpBar(progressBarExp, player);

            labelStatName.Text = player.Name;
            label1.Text = $"Содержимое клетки: {player.Name}";
            label2.Text = $"{player.Name}";
            labelLVL.Text = "LvL: " + player.getLvl().ToString();
        }

        ListViewItem selectedItem;
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            selectedItem = listView1.SelectedItems[0];
            shop.buttonEnterRefresh(selectedItem, buttonEnterUp);

        }

        int nextTurnClickCount = 0;

        int stage = 1;
        void GamePlan()
        {
            int temp;
            switch (difficulty)
            {
                case FormMenu.easy:
                    temp = 6;
                    break;
                case FormMenu.normal:
                    temp = 5;
                    break;
                case FormMenu.hard:
                    temp = 4;
                    break;
                case FormMenu.impossible:
                    temp = 3;
                    break;
                case FormMenu.nightmare:
                    temp = 2;
                    break;
                default:
                    temp = 5;
                    break;
            }

            int valueR = rand.Next(0, stage);
            string name;

            if (nextTurnClickCount % temp == 0)
            {
                switch (valueR)
                {
                    case int n when (n >= 0 && n <= 5):
                        name = slime;
                        break;
                    case int n when (n >= 6 && n <= 25):
                        name = skeleton;
                        break;
                    case int n when (n >= 26 && n <= 55):
                        name = hydra;
                        break;
                    case int n when (n >= 56):
                        name = dragon;
                        break;
                    default:
                        name = slime;
                        break;
                }
                int countEnemys = rand.Next(1, 3);
                addPerson(countEnemys, name);
                stage++;
                labelStages.Text = $"Stage: {stage}";
            }
        }
        private void addPerson(int count, string type)
        {
            Enemy enemy;
            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case slime:
                        enemy = new Rat();
                        break;
                    case dragon:
                        enemy = new Dragon();
                        break;
                    case hydra:
                        enemy = new Hydra();
                        break;
                    case skeleton:
                        enemy = new Skeleton();
                        break;
                    default:
                        enemy = new Rat();
                        break;
                }
                ///
                int chancebuff;
                switch (difficulty)
                {
                    case FormMenu.easy:
                        chancebuff = 30;
                        break;
                    case FormMenu.normal:
                        chancebuff = 25;
                        break;
                    case FormMenu.hard:
                        chancebuff = 20;
                        break;
                    case FormMenu.impossible:
                        chancebuff = 15;
                        break;
                    case FormMenu.nightmare:
                        chancebuff = 10;
                        break;
                    default:
                        chancebuff = 20;
                        break;
                }

                int buff1 = rand.Next(1, chancebuff + 1);
                if (buff1 == 1)
                {
                    enemy = new Mystery(enemy);
                }
                int buff2 = rand.Next(1, chancebuff + 1);
                if (buff2 == 1)
                {
                    enemy = new Mega(enemy);
                }
                ///
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
            //label1.Text = "Содержимое клетки: " + targetSearch.Name;
            ProgressB.refreshLabelHealth(labelMyHealth, labelEnemyHealth, targetSearch);
            ProgressB.refreshHpBar(hpBarEnemy, targetSearch);
            refreshStatus();
            stats.refreshStats(listView2, targetSearch);
        }
        void refreshStatus()
        {
            label1.Text = "Содержимое клетки: " + targetSearch.Name;
            if (targetSearch is not FreeCell)
            {
                labelStatName.Text = targetSearch.Name;
            }
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
                ProgressB.refreshHpBar(hpBarPlayer, player);
                if (targetSearch is Player)
                {
                    ProgressB.refreshHpBar(hpBarEnemy, targetSearch);
                    stats.refreshStats(listView2, targetSearch);
                }

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
                int attemps = 0;
                bool moved = false;
                do
                {
                    int key = rand.Next(1, 5);
                    switch (toKeys(key))
                    {
                        case Keys.W:
                            if (i.CordRows > 0 && matrix[i.CordRows - 1, i.CordColums] is FreeCell) { i.CordRows--; moved = true; }
                            break;
                        case Keys.S:
                            if (i.CordRows < matrix.Rows - 1 && matrix[i.CordRows + 1, i.CordColums] is FreeCell) { i.CordRows++; moved = true; }
                            break;
                        case Keys.A:
                            if (i.CordColums > 0 && matrix[i.CordRows, i.CordColums - 1] is FreeCell) { i.CordColums--; moved = true; }
                            break;
                        case Keys.D:
                            if (i.CordColums < matrix.Colums - 1 && matrix[i.CordRows, i.CordColums + 1] is FreeCell) { i.CordColums++; moved = true; }
                            break;
                        default:
                            moved = true;
                            break;
                    }
                    attemps++;
                } while (!moved && attemps < 5);

                i.healthRegen();
                if (i == targetSearch)
                {
                    stats.refreshStats(listView2, targetSearch);
                    ProgressB.refreshHpBar(hpBarEnemy, i);
                }
                matrix.moveMatrix(player, units);
            }
        }


        private void DrowMainMatrix(object sender, PaintEventArgs e)
        {
            if (player.getHealth() <= 0)
            {
                buttonExit.Visible = true;
                buttonEnterUp.Visible = false;
                buttonAtack.Visible = false;
                buttonAutoMode.Visible = false;
                buttonNextTurn.Visible = false;
                checkBoxMain.Checked = true;
                checkBoxMain.Visible = false;
                timer1.Enabled = false;

            }

            refreshStatus();
            ProgressB.refreshLabelHealth(labelMyHealth, labelEnemyHealth, targetSearch);

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
                if (checkBoxAutoMode.Checked) timer1.Enabled = false;
                if (player.atack(enemy, false, progressBarExp, hpBarEnemy, hpBarPlayer, checkBoxAutoMode.Checked))
                {
                    labelLVL.Text = "LvL: " + player.getLvl().ToString();
                    units.Remove(enemy);
                };
                if (checkBoxAutoMode.Checked) timer1.Enabled = true;
                stats.refreshStats(listView2, targetSearch);
                ProgressB.refreshLabelHealth(labelMyHealth, labelEnemyHealth, targetSearch);
                panelMain.Invalidate();
            }
        }



        private void buttonNextTurn_Click(object sender, EventArgs e)
        {
            nextTurnClickCount++;
            labelScore.Text = $"Score: {nextTurnClickCount}";

            checkBoxMain.Checked = false;
            List<Enemy> temp = new List<Enemy>();
            foreach (var i in units)
            {
                if (i.checkRangeToPlayer() && i.tryToAtackPlayer())
                {
                    if (checkBoxAutoMode.Checked) timer1.Enabled = false;
                    if (player.atack(i, true, progressBarExp, hpBarEnemy, hpBarPlayer, checkBoxAutoMode.Checked))
                    {
                        labelLVL.Text = $"LvL: {player.getLvl()}";
                        temp.Add(i);
                    }
                    if (checkBoxAutoMode.Checked) timer1.Enabled = true;
                }
            }
            foreach (var t in temp)
            {
                units.Remove(t);
            }
            Move(units);
            GamePlan();
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
            ProgressB.refreshLabelHealth(labelMyHealth, labelEnemyHealth, targetSearch);


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAutoMode_Click(object sender, EventArgs e)
        {

            if (checkBoxAutoMode.Checked)
            {
                checkBoxAutoMode.Checked = false;
                //buttonEnterUp.Enabled = true;
                timer1.Enabled = false;
            }
            else
            {
                checkBoxAutoMode.Checked = true;
                //buttonEnterUp.Enabled = false;
                timer1.Enabled = true;
                timer1.Interval = 2000;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(toKeys(rand.Next(1, 5)).ToString());
            checkBoxAutoMode.Checked = true;
            foreach (var i in units)
            {
                targetSearch = i;
                ProgressB.refreshLabelHealth(labelMyHealth, labelEnemyHealth, targetSearch);
                ProgressB.refreshHpBar(hpBarEnemy, targetSearch);
                refreshStatus();
                stats.refreshStats(listView2, targetSearch);
                if (buttonAtack.Enabled == true) break;
            }
            buttonAtack.PerformClick();
            buttonNextTurn.PerformClick();
        }


    }
}