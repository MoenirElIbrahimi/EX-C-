namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your speed!");
            string userInput = Console.ReadLine();
            int speed = Convert.ToInt32(userInput);
            if (speed > 120) {
                Console.WriteLine("Speeding!");
            }


        }
    }
}