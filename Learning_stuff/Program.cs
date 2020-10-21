using System;
using System.Data.SqlTypes;
using System.Threading;

namespace Learning_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //below is the console customization
            Console.Title = "BasicStuff";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            //below is an integer action (int)
            int x = 20;
            int a = 10;
            string c = "Alphabet test";
            Console.WriteLine(x + a);
            Console.WriteLine(c);

            //below os the name and password registration
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            if (name == "Everts")
            {
                Console.WriteLine("Name found on database");
            }
            else
            {
                Console.WriteLine("try again - what is your name: ");

            }

            Console.Write("Password: ");
            string password = Console.ReadLine();
            if (password == "test123")
            {
                Console.WriteLine("Success!");
            }
            else if (password != "test123")
            {
                Console.WriteLine("wrong password, restart app to retry the password");
                Console.ReadKey();
                return;
            }




            Console.WriteLine("You have logged in as " + name + ", welcome!");

            //below is a boolean

            bool AttackOnChinaSuccess = true;
            if (AttackOnChinaSuccess)
            {
                Console.WriteLine("Initiating attack on China");
                Console.WriteLine("Attack initiated");
            }
            else
            {
                Console.WriteLine("Initiating attack on china");
                Console.WriteLine("attack failed to innitiate");
            }
            Console.WriteLine("--------------------------------------------------------------");
            // below is the avarage of 3 numbers

            double num01;
            double num02;
            double num03;

            Console.Write("Insert the 1st number: ");
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("The 2nd number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("and the 3rd number: ");
            num03 = Convert.ToDouble(Console.ReadLine());

            double result = (num01 + num02 + num03) / 3;


            Console.WriteLine("The avarage is " + result);
            Console.WriteLine("--------------------------------------------------------------");

            //below is something I barely grasped the idea of, i still don't think i understand this. The if statements were 'easy', but the convert.toX was and still is confusing.

            Console.WriteLine("Tickets are 5 each!");
            Console.Write("the amount of money you have: ");
            double money = Convert.ToDouble(Console.ReadLine());
            double change = money - 5;
            if (money < 5)
            {
                Console.WriteLine("sorry, but you only have " + money + " dollars, but you need 5!");
            }
            else if (money == 5)
            {
                Console.WriteLine("Exactly 5 dollars!");
            }
            else
            {
                Console.WriteLine("Great! Here is your change of " + Convert.ToString(change) + " dollars. Thank you!");
                change = money - 5;          
            }

            //below is the math challenge

            Console.Write("3+2*4: ");
            double result1 = Convert.ToDouble(Console.ReadLine());
            if (result1 != 11)
            {
                Console.WriteLine("Wrong, the result was 11. you do 2*4 first and then add the 3");
                Console.WriteLine("press any key to continue!");
            }
            else if (result1 == 11)
            {
                Console.WriteLine("Correct, on to the next one!");
            }
            Console.Write("7+9/2: ");
            double result2 = Convert.ToDouble(Console.ReadLine());
            if (result2 == 11.5)
            {
                Console.WriteLine("Correct!");

            }
            else
            {
                Console.WriteLine("eeeer, wrong! Just like in the previous one do 9/2 first and then add that to 7");
            }

            Console.Write("2*10/2: ");
            double result3 = Convert.ToDouble(Console.ReadLine());
            if (result3 == 10)
            {
                Console.WriteLine("you are absolutely correct!");
            }
            else
            {
                Console.WriteLine("Wrong! This one is just like adding and subtracting, but with * and /. From lef tto right none have priorities here.");
            }
            


        }
    }
}
