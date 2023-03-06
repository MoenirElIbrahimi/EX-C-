namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your age:");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);
            if (number < 1900) {
                Console.WriteLine("you're old");
            }


        }
    }
}