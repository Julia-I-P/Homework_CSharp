namespace HomeWork4
{
    internal class Counter
    {
        public delegate void MethodKeeper();

        public int _score = 88;

        public event MethodKeeper onCount;
        public void Count () 
        {
            for (int i = 0; i < 1001; i++)
            {
                //Console.WriteLine(i);
                if (i == _score)
                {
                    onCount();
                }
            }
        }

        public void SetScore(int score) { _score = score; }
        public int GetScore() { return _score; }
    }
}
