namespace ConsoleApplication1.figures
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        protected Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MovePointBy(int x, int y)
        {
            X += x;
            Y += y;
        }

        public string GetClassName()
        {
            return GetType().Name;
        }
    }
}