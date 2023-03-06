namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string userInput = Console.ReadLine();
            double first = Convert.ToDouble(userInput); // ask for 1st int ask for input and convert

            Console.WriteLine("Give the second number!");
            string userIn = Console.ReadLine();
            double second = Convert.ToDouble(userIn);// ask for 2nd int ask for input and convert

            Console.WriteLine("Give the second number!");
            string user = Console.ReadLine();
            double third = Convert.ToDouble(user);// ask for 3nd int ask for input and convert

            double sum = first + second + third;
            double sumsum= sum / 3;
            Console.WriteLine("The average is "+ sumsum); 


        }
    }
}