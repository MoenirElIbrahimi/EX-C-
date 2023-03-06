namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);
            if (number > 0) {
                Console.WriteLine("It is positive");
            }
            else { 
                Console.WriteLine("it is not positive");
            }


        }
    }
}