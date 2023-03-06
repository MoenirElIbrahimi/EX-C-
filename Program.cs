namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string userInput = Console.ReadLine();
            int first = Convert.ToInt32(userInput); // ask for 1st int ask for input and convert

            Console.WriteLine("Give the second number!");
            string userIn = Console.ReadLine();
            int second = Convert.ToInt32(userIn);// ask for 2nd int ask for input and convert

            Console.WriteLine("Give the second number!");
            string user = Console.ReadLine();
            int third = Convert.ToInt32(user);// ask for 3rd int ask for input and convert

            int sum = first + second + third;
            Console.WriteLine("the sum is "+ sum); // calulates the 3 inputs by + and print it


        }
    }
}