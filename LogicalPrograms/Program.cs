namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be checked:");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            int remainder = 0;
            while (number > 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reversed Number is :" + reverse);
        }
    }
}