
namespace CSharpSolutions._01400._01476
{
    public class SubrectangleQueries
    {
        private int[,] rect;

        public SubrectangleQueries(int[][] rectangle)
        {
            rect = new int[rectangle.Length, rectangle[0].Length];
            for (int i = 0; i < rectangle.Length; i++)
                for (int j = 0; j < rectangle[0].Length; j++)
                    rect[i, j] = rectangle[i][j];

        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for (int i = row1; i <= row2; i++)
                for (int j = col1; j <= col2; j++)
                    rect[i, j] = newValue;
        }

        public int GetValue(int row, int col)
        {
            return rect[row, col];
        }
    }

    /**
     * Your SubrectangleQueries object will be instantiated and called as such:
     * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
     * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
     * int param_2 = obj.GetValue(row,col);
     */
}
