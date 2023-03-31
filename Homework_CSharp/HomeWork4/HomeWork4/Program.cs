namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter Counter1 = new Counter();
            Handler1 FirstHandler = new Handler1();
            Handler2 SecondHandler = new Handler2();

            Console.WriteLine("This is an 1000-score counter.");
            Console.WriteLine("If you want to get a reminder on certain count," +
                " enter your number (from 0 to 1000)");
            Console.WriteLine("Otherwise you will receive a reminder on count 88 " +
                "(`cause it`s my favourite number :)).");
            int score = int.Parse(Console.ReadLine());
            Counter1.SetScore(score);

            FirstHandler.SetScore(score);
            SecondHandler.SetScore(score);

            Counter1.onCount += FirstHandler.Message;
            Counter1.onCount += SecondHandler.Message;

            Counter1.Count();
            
        }
    }
}