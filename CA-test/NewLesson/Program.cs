namespace NewLesson
{
    public class Test
    {
        //Auto implemented prop
        public int[] Numbers { get; private set; }

        private Test()
        {
            Numbers = new[] { 2, 3, 4 };
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();

        }
    }
}