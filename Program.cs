namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give a number!");
            String userInput = Console.ReadLine();          
            double DoubleValue = Convert.ToDouble(userInput);
            Console.WriteLine("You gave " + DoubleValue);
   


        }
    }
}