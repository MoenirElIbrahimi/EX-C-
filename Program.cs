namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many days");
            int sec = 86400;
            Console.WriteLine("Give an integer:");
            string userInput = Console.ReadLine();
            int days = Convert.ToInt32(userInput);
            int sum = days * sec;
            Console.WriteLine(sum);






        }
    }
}