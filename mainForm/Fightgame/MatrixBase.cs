namespace Fightgame
{
    public class MatrixBase
    {
        public MatrixBase(int matrixRows, int matrixColumns, Panel panel)
        {
            Rows = matrixRows;
            Colums = matrixColumns;
            CellSizeRow = (panel.Width / matrixColumns) - 1;
            CellSizeColum = (panel.Height / matrixRows) - 1;
        }

        protected void RectangleDrow(Graphics g, int row, int colum)
        {
            g.DrawRectangle(Pens.Black, colum * CellSizeRow, row * CellSizeColum, CellSizeRow, CellSizeColum);
        }

        int cellSizeX;
        int cellSizeY;
        int matrixRows;
        int matrixColumns;

        public int CellSizeRow
        {
            get { return cellSizeX; }
            set { cellSizeX = value; }
        }
        public int CellSizeColum
        {
            get { return cellSizeY; }
            set { cellSizeY = value; }
        }
        public int Rows
        {
            get { return matrixRows; }
            set { matrixRows = value; }
        }
        public int Colums
        {
            get { return matrixColumns; }
            set { matrixColumns = value; }
        }
    }
}
