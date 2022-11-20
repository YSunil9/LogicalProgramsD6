namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be checked:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, num;
            num = n;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }

            }
            if (sum == num)
            {
                Console.WriteLine("The number is a perfect number");
            }
            else
            {
                Console.WriteLine("The number is not a perfect number");
            }
            Console.ReadLine();
        }
    }
}