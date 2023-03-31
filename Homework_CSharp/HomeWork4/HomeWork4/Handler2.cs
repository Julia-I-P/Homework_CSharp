namespace HomeWork4
{
    internal class Handler2
    {
        private int _score;
        public void Message()
        {
            Console.WriteLine($"It`s {_score} already! Go and do something!") ;
        }

        public void SetScore(int score) { _score = score; }
        public int GetScore() { return _score; }
    }
}