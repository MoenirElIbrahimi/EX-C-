namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string userInput = Console.ReadLine();
            int first = Convert.ToInt32(userInput);
            Console.WriteLine("Give the second number!");
            string userIn = Console.ReadLine();
            int second = Convert.ToInt32(userIn);
            int sum = first + second;
            Console.WriteLine("the sum is "+ sum);


        }
    }
}