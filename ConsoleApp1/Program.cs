using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert; 

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            /*
            bool var2, var3;
            bool var1;

            var2 = false;
            var3 = true;

            var1 = var2^var3;

            Console.WriteLine(var1);
            Console.ReadLine();

    




            Console.WriteLine("Enter an integer:");
            int myInt = ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0and5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine("Integer less than 10?  " + isLessThan10);
            Console.WriteLine("Integer is between 0 and 5?  " + isBetween0and5);
            Console.WriteLine ("only one is true?  "  + (isBetween0and5 ^ isLessThan10));

            Console.ReadLine();

    



            Console.Write("please input a integer: ");
            int S1 = ToInt32(Console.ReadLine());

            String myStr = (S1 < 10) ? "Less than 10" : "Greater than 10";

            Console.WriteLine("you input " + S1  +"\n" + " The result is: "+ myStr); 
            Console.Write(myStr);
            Console.ReadLine();

            





            Console.Write("please input the first number: ");
            double var1 = ToDouble(Console.ReadLine());

            Console.Write("please input another number:  ");
            double var2 = ToDouble(Console.ReadLine());

            string compar;

            if (var1 < var2)
                compar = "less than";
            else
            {
                if (var1 == var2)
                    compar = "equal to";

                else
                    compar = "greater than";
            }


            Console.WriteLine($"the First number is " + compar + " the second number");
            Console.ReadLine(); 



    



            int S1, S2;
            S1 = 1;
            S2 = 5;
            String Str = "";

            if (S1 == 3 || S2 == 4)
                Str = "Like";

            else
                Str = "dislike";

            Console.WriteLine(Str);
            Console.ReadLine(); 

              
           


            const string myName = "jianqing";
            const string niceName = "sd";
            const string sillyName = "y";
            string name;

            Console.Write("what is your name: ");
            name = Console.ReadLine();

            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("you have the same name with me!");
                    break;
                case niceName:
                    Console.WriteLine("you have the same name with my girlfriend!\0");
                    break;
                case sillyName:
                    Console.WriteLine("you have the same name with my sex partner \0");
                    break;
                
                

            }
            Console.WriteLine("hello," + name);

            Console.ReadLine();

    


            Console.WriteLine("\nInterest Calculator, Programmed by Jianqing in 5/4/2018\n \n \0"); 
            double balance, rate, targetBalance;
            Console.Write("what is your current balance:");
            balance = ToDouble(Console.ReadLine());

            Console.Write("What is your current interests rate in %: ");
            rate = 1 + ToDouble(Console.ReadLine())/100;

            Console.Write("what is your target balance: ");
            targetBalance = ToDouble(Console.ReadLine());

            int totalYears=0;

            do
            {
                balance *= rate;
                ++totalYears;
            }

            while (balance < targetBalance);
            Console.WriteLine("in " + totalYears + " " + "year" + (totalYears == 1 ? "" : "s")+", " + "you'll have a balance of " + balance);

            Console.ReadLine();




    

            Console.WriteLine("\nInterest Calculator, Programmed by Jianqing in 5/4/2018\n \n \0");
            double balance, rate, targetBalance;
            Console.Write("what is your current balance:");
            balance = ToDouble(Console.ReadLine());

            Console.Write("What is your current interests rate in %: ");
            rate = 1 + ToDouble(Console.ReadLine()) / 100;

            Console.Write("what is your target balance: ");


            do
            {
                targetBalance = ToDouble(Console.ReadLine());
                if (targetBalance <= balance)
                    Console.WriteLine("invalid input! \nplease enter an amout that is greater than current balance: ");
                
            }
            while (targetBalance <= balance);

            do
            {
                targetBalance = ToDouble(Console.ReadLine());
            }

            while (targetBalance > balance); 

            int totalYears = 0;

            while (balance < targetBalance) ;
            {
                balance *= rate;
                ++totalYears;
            }

            
            Console.WriteLine("in " + totalYears + " " + "year" + (totalYears == 1 ? "" : "s") + ", " + "you'll have a balance of " + balance);

            if (totalYears == 0)
                Console.WriteLine("you really don't need this calc, sucker, fuck you!"); 

            Console.ReadLine();



    


            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have?");

            
            do
            {
                targetBalance = ToDouble(Console.ReadLine());
                if (targetBalance <= balance)
                    Console.WriteLine("You must enter an amount greater than " +
                        "your current balance! \nPlease enter another value.");
            }

            while (targetBalance <= balance); 


            
    
            targetBalance = ToDouble(Console.ReadLine());
            

            int totalYears = 0;
            while (balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} you'll have a balance of {balance}.");
            if (totalYears == 0)
                Console.WriteLine(
                   "To be honest, you really didn't need to use this calculator.");
            Console.ReadKey();



    


            int i = 1;
            while (i<=10)

            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine($"{i++}"); 


    */
            /*
                    // Number Game 
                    int var1, var2;
                    var1 = 0; var2 = 0;       

                    bool numberOK = false;
                    while (!numberOK)
                    {
                        Console.WriteLine("please input the first number: ");
                        var1 = ToInt32(Console.ReadLine());
                        Console.WriteLine("please input another number: ");
                        var2 = ToInt32(Console.ReadLine());
                        Console.WriteLine($"you entered {var1} and {var2}");

                        if ((var1>10) && (var2>10))
                        {
                            numberOK = false;
                            Console.WriteLine("only one can be greater than 10! please try again: ");

                        }
                        else if ((var1<10)&&(var2<10))


                        {
                            numberOK = false;
                            Console.WriteLine("at least one number should be greater than 10, please try agian: "); 
                        }

                        else
                        {
                            numberOK = true;
                            Console.WriteLine("You won, press any key to exit application!");
                            Console.ReadLine(); 

                        }
                        // Console.ReadLine();

                    }


            */
            /*
            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have?");


            do
            {
                targetBalance = ToDouble(Console.ReadLine());
                if (targetBalance <= balance)
                    Console.WriteLine("You must enter an amount greater than " +
                        "your current balance! \nPlease enter another value.");
            }

            while (targetBalance <= balance);
            
            //targetBalance = ToDouble(Console.ReadLine());


            int totalYears = 0;
            while (balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} you'll have a balance of {balance}.");
            if (totalYears == 0)
            
                Console.WriteLine("To be honest, you really didn't need to use this calculator.");
                Console.ReadLine();
            */

            /*
            Console.WriteLine("\nInterest Calculator, Programmed by Jianqing in 5/4/2018\n \n \0");
            double balance, rate, targetBalance;
            Console.Write("what is your current balance:");
            balance = ToDouble(Console.ReadLine());

            Console.Write("What is your current interests rate in %: ");
            rate = 1 + ToDouble(Console.ReadLine()) / 100;

            Console.Write("what is your target balance: ");


            do
            {
                targetBalance = ToDouble(Console.ReadLine());
                if (targetBalance <= balance)
                    Console.WriteLine("invalid input! please enter an amout that is greater than current balance: ");

            } while (targetBalance <= balance);

            

            int totalYears = 0;

            while (balance < targetBalance) 
            {
                balance *= rate;
                ++totalYears;
            }


            Console.WriteLine("in " + totalYears + " " + "year" + (totalYears == 1 ? "" : "s") + ", " + "you'll have a balance of " + balance);

            if (totalYears == 0)
                Console.WriteLine("you really don't need this calc, sucker, fuck you!");

            Console.ReadLine();

    */

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

           


        }

        private static bool MainMenu()
        {
            Console.Clear(); 
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Option 1: ");
            Console.WriteLine("2) Option 2: ");
            Console.WriteLine("3) Exit.");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGames();
                return true;
            }

            else if (result == "3")
            {
                return false;
            }

            else
            {
                return true;
            }
        }
            private static void PrintNumbers()
            {
            Console.WriteLine("Print Numbers");
            Console.Write("Type a Number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <result+1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++; 
            }
            Console.ReadLine();

            }

        private static void GuessingGames()
        {
            Console.Clear();
            Console.WriteLine("Gussing Game");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();

                guesses++;
                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wring");
            } while (incorrect);

           Console.WriteLine("Correct ! it took you {0} guesses", guesses); 

            Console.ReadLine();

        }
        }




        
    
}
