using Newtonsoft.Json.Bson;

namespace NevronTask.Extensions
{
    public static class Numbers
    {
        public static List<int> Elements { get; set; } = new List<int>();
        public static int Sum { get; set; }
        public static int AddRandomNumber(int min, int max)
        {
            int number = new Random().Next(min, max);
            Elements.Add(number);
            return number;
        }
        public static int SumElements()
        {
            Sum = Elements.Sum();
            return Sum;
        }
        public static void Clear()
        {
            Sum = 0;
            Elements.Clear();
        }
    }
}
