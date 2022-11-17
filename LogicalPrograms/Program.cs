namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0, val2 = 1, addition = 0;

            Console.WriteLine("Enter value  ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0 \n1");
            for (int i = 2; i < length; i++)
            {
                addition = val1 + val2;
                Console.WriteLine(addition);
                val1 = val2;
                val2 = addition;
            }
        }
    }
}