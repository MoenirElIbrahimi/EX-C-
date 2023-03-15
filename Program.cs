using System.Diagnostics.Metrics;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login();



            }
        public static void Login() 
        {

            Console.WriteLine("Enter username:");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string userInput1 = Console.ReadLine();
            if (userInput == "alex" & userInput1 == "sunshine")
            {
                Console.WriteLine("You have successfully logged in!");
            }
            else if  (userInput == "emma" & userInput1 == "haskell")
            {
                Console.WriteLine("You have successfully logged in!");
            }
            else
            {
                Console.WriteLine("Incorrect username or password!");
            }
            //int number = Convert.ToInt32(userInput);



        }






    }
    }
