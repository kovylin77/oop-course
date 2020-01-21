namespace ConsoleApplication1
{
    public class Counter
    {
        public int X { get; set; }

        public int Hx { get; set; }

        public int XMax { get; set; }
        
        public Counter() {}

        public Counter(int x)
        {
            X = x;
        }

        public Counter(int x, int hx)
        {
            X = x;
            Hx = hx;
        }

        public void IncreaseCounter()
        {
            X += Hx;
        }

        public int IncreaseAndReturnCounter()
        {
            IncreaseCounter();
            return X;
        }

        public int this[int i] => X + Hx * i;
    }
}