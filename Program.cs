namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);
            if (number >= 18) {
                Console.WriteLine("you're an adult!");
            }
            else { 
                Console.WriteLine("you're under age!");
            }


        }
    }
}