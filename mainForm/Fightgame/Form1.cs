using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace Fightgame
{
    public partial class Form1 : Form
    {
        const string name = "Genry";
        List<List<Unit>> matrix = new List<List<Unit>>();
        List<Unit> units = new List<Unit>();
        List<List<Unit>> FreeMatrix = new List<List<Unit>>();
        const int cellSize = 70;    //70
        const int matrixRowsSize = 9, matrixColumsSize = 9;
        Player player = Player.GetInstance(name, matrixRowsSize/2, matrixColumsSize/2);

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
            fieldMatrix(matrix, matrixRowsSize, matrixColumsSize);  // 9 9
        }

        private void addPerson()
        {
            Random rand = new Random();
            Unit unit = new Slime();
            int cordColums, cordRows;
            do
            {
                cordColums = rand.Next(0, matrix.Count);
                cordRows = rand.Next(0, matrix[0].Count);
            } while (!matrix[cordRows][cordColums].Invulnerable || matrix[cordRows][cordColums] == player); // возможно заполнение и вылет
            unit.cordRows = cordRows;
            unit.cordColums = cordColums;
            units.Add(unit);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / cellSize;
            int y = e.Y / cellSize;

            if (x >= 0 && x < matrix.Count && y >= 0 && y < matrix[x].Count)
            {
                char cellContent = matrix[x][y].Simvol; // Получаем содержимое клетки
                label1.Text = "Содержимое клетки: " + cellContent; // Отображаем информацию в Label
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fieldMatrix(FreeMatrix, matrixRowsSize, matrixColumsSize);
            addPerson();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.W:
                    if (player.cordRows > 0) player.cordRows--;
                    break;
                case Keys.S:
                    if (player.cordRows < matrix.Count - 1) player.cordRows++;
                    break;
                case Keys.A:
                    if (player.cordColums > 0) player.cordColums--;
                    break;
                case Keys.D:
                    if (player.cordColums < matrix[0].Count - 1) player.cordColums++;
                    break;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S ||
                e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            {
            };
            this.Invalidate(); // Перерисовка формы
        }
        private void fieldMatrix(List<List<Unit>> matrix, int sizeRows, int sizeColums)
        {
            for (int i = 0; i < sizeRows; i++)
            {
                List<Unit> row = new List<Unit>();
                for (int j = 0; j < sizeColums; j++)
                {
                    row.Add(new FreeCell());
                }
                matrix.Add(row);
            }
        }

        private void moveMatrix()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[0].Count; j++)
                {

                    matrix[i][j] = FreeMatrix[i][j];
                }
            }
            matrix[player.cordRows][player.cordColums] = player;
            foreach (var i in units)
            {
                matrix[i.cordRows][i.cordColums] = i;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;



            moveMatrix();
            for (var i = 0; i < matrix.Count; i++)
            {
                for (var b = 0; b < matrix[0].Count; b++)
                {
                    bool isNeighbor = Math.Abs(player.cordRows - i) + Math.Abs(player.cordColums - b) < (player.RangeAtack + 1);   // область возле игрока
                    if (isNeighbor) g.FillRectangle(Brushes.DarkRed, b * cellSize, i * cellSize, cellSize, cellSize);

                    if (matrix[i][b] == player)
                    {
                        g.FillRectangle(Brushes.Green, b * cellSize, i * cellSize, cellSize, cellSize);
                    }

                    if (matrix[i][b].Simvol == 'S')
                    {
                        g.FillRectangle(Brushes.Yellow, b * cellSize, i * cellSize, cellSize, cellSize);
                    }

                    g.DrawRectangle(Pens.Black, b * cellSize, i * cellSize, cellSize, cellSize);

                    string value = matrix[i][b].Simvol.ToString();
                    PointF textPosition = new PointF(b * cellSize + (cellSize / 4), i * cellSize + (cellSize / 4));
                    g.DrawString(value, this.Font, Brushes.Black, textPosition);
                }
            }
        }

        private void buttonAtack_Click(object sender, EventArgs e)
        {
            player.atack(matrix, units);
            this.Invalidate();
        }
    }
}