namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be checked:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum++;
                }

            }
            if (sum == 2)
            {
                Console.WriteLine("The number is a prime number");
            }
            else
            {
                Console.WriteLine("The number is not a prime number");
            }
            Console.ReadLine();
        }
    }
}