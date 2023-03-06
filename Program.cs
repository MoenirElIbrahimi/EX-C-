namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            string userInput = Console.ReadLine();
            int numberst = Convert.ToInt32(userInput);// ask 1st for input and convert it


            if (numberst % 2 == 0) 
            {
            Console.WriteLine("it is even.");
            }
            else { Console.WriteLine("It is odd."); }
        }
    }
}