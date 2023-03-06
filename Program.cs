namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speak, friend, and enter!");
 //           string userInput = Console.ReadLine();
 //           int numberst = Convert.ToInt32(userInput);// ask 1st for input and convert it
            string srtInput = Console.ReadLine();

            if (srtInput == "Mellon") 
            {
            Console.WriteLine("Welcome, friend");
            }
            else { Console.WriteLine("They've got a cave troll!"); }
        }
    }
}