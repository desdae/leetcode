namespace CSharpSolutions._01400._01401
{
    public class Solution
    {
        public bool CheckOverlap(int radius, int x_center, int y_center, int x1, int y1, int x2, int y2)
        {
            int cx = (x_center < x1 ? x1 : (x_center > x2 ? x2 : x_center));
            int cy = (y_center < y1 ? y1 : (y_center > y2 ? y2 : y_center));
            int dx = cx - x_center;
            int dy = cy - y_center;

            return (dx * dx + dy * dy) <= radius * radius;
        }
    }
}
