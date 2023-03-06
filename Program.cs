namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your percent [0-100]");
            string userInput = Console.ReadLine();
            int numberst = Convert.ToInt32(userInput);// ask 1st for input and convert it


            if (numberst < 0) 
            {
            Console.WriteLine("Impossible");
            }
            else if (numberst > 100) 
            { 
            Console.WriteLine("Outstanding!");
            }
            else if (numberst > 89)
            {
            Console.WriteLine("5");
            }
            else if (numberst > 79)
            {
            Console.WriteLine("4");
            }
            else if (numberst > 69)
            {
            Console.WriteLine("3");
            }
            else if (numberst > 59)
            {
            Console.WriteLine("2");
            }
            else if (numberst > 49)
            {
            Console.WriteLine("1");
            }
            else if (numberst >= 0)
            {
            Console.WriteLine("Fail");
            }
        }
    }
}