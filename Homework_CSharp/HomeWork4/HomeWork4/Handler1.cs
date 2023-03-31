namespace HomeWork4
{
    internal class Handler1
    {
        private int _score;
        public void Message()
        {
            Console.WriteLine($"Oh Lord, it`s {_score}! It`s time to act!!");
        }

        public void SetScore(int score) { _score = score; }
        public int GetScore() { return _score;}
    }
}
