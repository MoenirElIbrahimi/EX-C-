namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first string:");
 //           string userInput = Console.ReadLine();
 //           int numberst = Convert.ToInt32(userInput);// ask 1st for input and convert it
            string srtInput = Console.ReadLine();
            Console.WriteLine("Give the second string:");
            string srtInput2 = Console.ReadLine();

            if (srtInput == srtInput2) 
            {
            Console.WriteLine("Echo!");
            }
            else { Console.WriteLine("Nope!"); }
        }
    }
}