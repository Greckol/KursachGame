using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace Fightgame
{
    public partial class Form1 : Form
    {
        Matrix matrix;
        List<Unit> units = new List<Unit>();
        const int cellSize = 70; 
        const int matrixRowsSize = 9, matrixColumsSize = 9;
        Player player = Player.GetInstance("Genry", matrixRowsSize/2, matrixColumsSize/2);

        public Form1()
        {
            matrix = new Matrix(matrixRowsSize, matrixColumsSize);
            addPerson();

            InitializeComponent();
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        private void addPerson()
        {
            Random rand = new Random();
            Unit unit = new Slime();
            int cordRows, cordColums;
            do
            {
                cordRows = rand.Next(0, matrix.Rows);
                cordColums = rand.Next(0, matrix.Colums);
            } while (!matrix[cordRows,cordColums].Invulnerable || matrix[cordRows,cordColums] == player); // возможно заполнение и вылет
            unit.cordRows = cordRows;
            unit.cordColums = cordColums;
            units.Add(unit);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int row = e.Y / cellSize;
            int colum = e.X / cellSize;

            if (colum >= 0 && colum < matrix.Rows && row >= 0 && row < matrix.Colums)
            {
                char cellContent = matrix[row,colum].Simvol; // Получаем содержимое клетки
                label1.Text = "Содержимое клетки: " + cellContent; // Отображаем информацию в Label
            }
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.W:
                    if (player.cordRows > 0) player.cordRows--;
                    break;
                case Keys.S:
                    if (player.cordRows < matrix.Rows - 1) player.cordRows++;
                    break;
                case Keys.A:
                    if (player.cordColums > 0) player.cordColums--;
                    break;
                case Keys.D:
                    if (player.cordColums < matrix.Colums - 1) player.cordColums++;
                    break;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S ||
                e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            {
            };
            this.Invalidate(); // Перерисовка формы
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
            player.atack(matrix.matrix, units);
            this.Invalidate();
        }
    }
}