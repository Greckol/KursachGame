using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Fightgame
{
    public partial class Form1 : Form
    {
        const int matrixRowsSize = 9;
        const int matrixColumsSize = 9;
        Random rand = new Random();

        Matrix matrix;
        List<Unit> units = new List<Unit>();
        Player player = Player.GetInstance("Genry", matrixRowsSize / 2, matrixColumsSize / 2);

        public Form1()
        {
            matrix = new Matrix(matrixRowsSize, matrixColumsSize, 70);
            InitializeComponent();
            ProgressB.refreshProgress(progressBarPlayer, player);
            matrix.moveMatrix(player, units);
            addPerson(5, "slime");
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        private void addPerson(int count, string title)
        {
            Unit unit;
            for (int i = 0; i < count; i++)
            {
                switch (title)
                {
                    case "slime":
                        unit = new Slime();
                        break;
                    default:
                        unit = new Slime();
                        break;
                }
                do
                {
                    unit.cordRows = rand.Next(0, matrix.Rows);
                    unit.cordColums = rand.Next(0, matrix.Colums);
                } while (!matrix[unit.cordRows, unit.cordColums].Invulnerable || matrix[unit.cordRows, unit.cordColums] == player); // возможно заполнение и вылет
                units.Add(unit);
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int row = e.Y / matrix.CellSize;
            int colum = e.X / matrix.CellSize;

            if (colum >= 0 && colum < matrix.Rows && row >= 0 && row < matrix.Colums)
            {
                char cellContent = matrix[row, colum].Simvol; // Получаем содержимое клетки
                label1.Text = "Содержимое клетки: " + cellContent; // Отображаем информацию в Label
                ProgressB.refreshProgress(progressBarEnemy, matrix[row, colum]);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (player.CordRows > 0) player.cordRows--;
                    break;
                case Keys.S:
                    if (player.CordRows < matrix.Rows - 1) player.CordRows++;
                    break;
                case Keys.A:
                    if (player.CordColums > 0) player.CordColums--;
                    break;
                case Keys.D:
                    if (player.CordColums < matrix.Colums - 1) player.CordColums++;
                    break;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S ||
                e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            {
                matrix.moveMatrix(player, units);
                Move(units);
            };
            this.Invalidate(); // Перерисовка формы
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
                    return Keys.D;
            }
        }
        private void Move(List<Unit> unit)
        {
            foreach (var i in unit)
            {
                int key = rand.Next(1, 5);
                switch (toKeys(key))
                {
                    case Keys.W:
                        if (i.CordRows > 0)
                        {
                            if (matrix[i.CordRows - 1, i.CordColums].Invulnerable) i.CordRows--;
                        }
                        break;
                    case Keys.S:
                        if (i.CordRows < matrix.Rows - 1)
                        {
                            if (matrix[i.CordRows + 1, i.CordColums].Invulnerable) i.CordRows++;
                        }
                        break;
                    case Keys.A:
                        if (i.cordColums > 0)

                        {
                            if (matrix[i.CordRows, i.CordColums - 1].Invulnerable) i.CordColums--;
                        }
                        break;
                    case Keys.D:
                        if (i.cordColums < matrix.Colums - 1)
                        {
                            if (matrix[i.CordRows, i.CordColums + 1].Invulnerable) i.CordColums++;
                        }
                        break;
                }
                matrix.moveMatrix(player, units);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            matrix.moveMatrix(player, units);

            for (var i = 0; i < matrix.Rows; i++)
            {
                for (var b = 0; b < matrix.Colums; b++)
                {
                    matrix.DrawAll(g, this, player, i, b);
                }
            }
        }

        private void buttonAtack_Click(object sender, EventArgs e)
        {
            player.atack(matrix, units, progressBarPlayer);
            this.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }
    }
}