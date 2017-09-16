using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
       
        

        static void Main(string[] args)
        {




            Date();

            Entering();

            Console.ReadKey();
        }
        private static void MainMenu()
        {

            Welcome();

            Console.WriteLine("1)Game");
            Console.WriteLine("2)Math");
            Console.WriteLine("3)Exit");
            Console.Write("Choose one of the Options :");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.Clear();
                GameMenu();
            }
            if (result == "2")
            {
                Console.Clear();
                MathMenu();
            }
            while (result == "3")
            {
                Console.Clear();
            }

        }
        private static void printNumber()
        {



            Console.Write("Enter a Number : ");
            int j = int.Parse(Console.ReadLine());
            for (int i = 0; i <= j; i++)
            {
                Console.Write(i);

                Console.Write("/");

            }
            Console.WriteLine();
            GameSecondMenu();
            for (; ; )
            {
                int result = int.Parse(Console.ReadLine());
                if (result == 1)
                {
                    Console.Clear();
                    MainMenu();
                }

                if (result == 2)
                {
                    Console.Clear();
                    GameMenu();
                }
                if (result == 3)
                {
                    Console.Clear();
                    printNumber();
                }

                if (result == 4)
                {
                    Console.Clear();

                }


            }
        }

        private static void GussingGame()
        {
            int counter = 1;
            bool repeat = true;
            while (repeat)
            {

                Console.Write("Guss a Number betwen 1  and 6 : ");
                Random randomNumber = new Random();
                int myrandomNumber = randomNumber.Next(1, 6);

                int result = int.Parse(Console.ReadLine());

                if (result == myrandomNumber)
                {

                    Console.WriteLine("Correct !");
                    Console.WriteLine("it took(" + (counter) + ")Times from you to guss it");
                    repeat = false;
                }
                else
                    Console.WriteLine("Wrong !");
                counter = counter + 1;

            }
            GameSecondMenu();
            for (; ; )
            {
                int result = int.Parse(Console.ReadLine());
                if (result == 1)
                {
                    Console.Clear();
                    MainMenu();
                }

                if (result == 2)
                {
                    Console.Clear();
                    GameMenu();
                }
                        
                if (result == 3)
                {
                    Console.Clear();
                    GussingGame();
                }

                if (result == 4)
                {
                    Console.Clear();

                }


            }

        }

        private static void SecondMathMenu()
        {


            Console.WriteLine("1)back to ToolsMenu ");
            Console.WriteLine("2)back to MainMenu ");
            Console.WriteLine("3)Try Again !");
            Console.WriteLine("4)Exit");


        }
        private static void Entering()
        {

            string P = "0001";
            string U = "Mohamad";
            string User;
            string Pass;
            bool all = true;
            while (all)
            {
                Console.Write("Enter The Username :");
                User = Console.ReadLine();
                if (User != U)
                {
                    Console.WriteLine("Username is not exist in any DataBase,Try again");
                    continue;
                }

                else
                {
                    Console.Write("Enter The Password :");
                    Pass = Console.ReadLine();
                }
                if (Pass != P)
                {
                    Console.WriteLine("Tha Password is incorrect");

                    continue;

                }
                else if (Pass == P)
                {
                    all = false;
                    Console.Clear();
                    MainMenu();
                }




            }


        }
        private static void Welcome()
        {

            Console.WriteLine(":::::::::::::::::::::::::Eng.Mohamad Abouras Project::::::::::::::::::::::");
            Console.WriteLine("--------------------------------------------------------------------------");


        }

        private static void GameMenu()
        {
            Console.WriteLine("1)Print Numbers");
            Console.WriteLine("2)Gussing Game ");
            Console.WriteLine("3)Age Game ");
            Console.WriteLine("4)Exit");
            Console.Write("Please chose a Number to Start the Game : ");
            int result = int.Parse(Console.ReadLine());
            if (result == 1)
            {

                Console.Clear();
                printNumber();
                GameSecondMenu();

            }

            if (result == 2)
            {
                Console.Clear();
                GussingGame();
                GameSecondMenu();
            }

            while (result == 3)
            {
                Console.Clear();
                AgeGame();
                GameSecondMenu();
            }
            while (result == 4)
            {
                Console.Clear();

            }




        }
        private static void Sumeln()
        {
            int x, y, S;
            Console.Write("Enter The First Number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter The Second Number: ");
            y = int.Parse(Console.ReadLine());
            S = x + y;
            Console.WriteLine(x + "+" + y + "=" + S);
            Console.WriteLine("1)back to ToolsMenu ");
            Console.WriteLine("2)back to MainMenu ");
            Console.WriteLine("3)Try Again !");
            Console.WriteLine("4)Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.Clear();
                MathMenu();


            }
            if (result == "2")
                Console.Clear();
            MainMenu();
            if (result == "3")
            {
                Console.Clear();
                Sumeln();
            }

            if (result == "4")
            {
                Console.Clear();

            }


        }

        private static void multiplication()

        {
            int x, y, S;
            Console.Write("Enter The First Number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter The Second Number: ");
            y = int.Parse(Console.ReadLine());
            S = x * y;
            Console.WriteLine(x + "*" + y + "=" + S);
            Console.WriteLine("1)back to ToolsMenu ");
            Console.WriteLine("2)back to MainMenu ");
            Console.WriteLine("3)Try Again !");
            Console.WriteLine("4)Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.Clear();
                MathMenu();


            }
            if (result == "2")
            {
                Console.Clear();
                MainMenu();
            }
            if (result == "3")
            {
                Console.Clear();
                multiplication();
            }

            if (result == "4")
            {
                Console.Clear();

            }

        }
        private static void Divide()
        {

            double x, y, S;
            Console.Write("Enter The First Number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter The Second Number: ");
            y = int.Parse(Console.ReadLine());
            S = x / y;
            Console.WriteLine(x + "/" + y + "=" + S);
            SecondMathMenu();
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.Clear();
                MathMenu();
            }
            if (result == "2")
            {
                Console.Clear();
                MainMenu();
            }
            if (result == "3")
            {
                Console.Clear();
                Divide();


            }
            if (result == "4")
            {
                Console.Clear();

            }

        }
        private static void MathMenu()
        {

            Console.WriteLine("1)Sumeln Tool ");
            Console.WriteLine("2)Multiplication Tool  ");
            Console.WriteLine("3)Divide Tool  ");
            Console.WriteLine("4)The Area and Primeter  ");
            Console.WriteLine("5)Back to MainMenu");
            Console.WriteLine("6)Exit");
            Console.Write("Choose The Number of the Tool : ");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine("Sumeln Tool");
                Console.WriteLine("----------------------");
                Sumeln();
            }
            if (result == "2")
            {
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine("Multiplication Tool");
                Console.WriteLine("----------------------");
                multiplication();
            }
            if (result == "3")
            {
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine("Divide Tool");
                Console.WriteLine("----------------------");
                Divide();
            }
            if (result == "4")
            {
                Console.Clear();
               AreaAndPrimeter();
            }
            while (result == "5")
            {
                Console.Clear();
                MainMenu();

            }
        }
        private static void Date ()
        {
            DateTime UserAge = DateTime.Now;


            Console.WriteLine("                \t\t\t\t\t\t" + UserAge.ToShortDateString());



        }
        private static void AgeGame()
        {

            Console.Write("Enter your birthday in (DD-MM-YYYY) :");
            DateTime Now = DateTime.Now;
            DateTime User = DateTime.Parse(Console.ReadLine());
            int Year = Convert.ToInt32(DateTime.Now.Subtract(User).TotalDays) / 360;
            int Month = Convert.ToInt32(DateTime.Now.Subtract(User).TotalDays) / 30;
            int Week = Convert.ToInt32(DateTime.Now.Subtract(User).TotalDays) / 7;
            int Day = Convert.ToInt32(DateTime.Now.Subtract(User).TotalHours) / 24;
            int Minutes = Convert.ToInt32(DateTime.Now.Subtract(User).TotalSeconds) / 60;

            Console.WriteLine("You have lived for " + Year + " Year");
            Console.WriteLine("OR " + Month + " Month");
            Console.WriteLine("OR " + Week + " Week");
            Console.WriteLine("OR " + Day + " Day");
            Console.WriteLine("OR " + Minutes + " Minutes");
            GameSecondMenu();
            for (; ; )
            {
                int result = int.Parse(Console.ReadLine());
                if (result == 1)
                {
                    Console.Clear();
                    MainMenu();
                }

                if (result == 2)
                {
                    Console.Clear();
                    GameMenu();
                }
                if (result == 3)
                {
                    Console.Clear();
                    AgeGame();
                }

                if (result == 4)
                {
                    Console.Clear();

                }


            }






        }
        private static void GameSecondMenu()
        {

            Console.WriteLine("1)back to MainMenu ");
            Console.WriteLine("2)back to GameMenu");
            Console.WriteLine("3)Try Again !");
            Console.WriteLine("4)Exit");
           
        }
        private static void square()
        {

            Square mySquare = new Square();
            
            Console.WriteLine("Enter The Length of one of the square lines :");
            mySquare.LengthA = int.Parse(Console.ReadLine());
            Console.WriteLine("The square Area is "+mySquare.Area());
            Console.WriteLine("And the square Primeter is :" + mySquare.Primeter());
            SecondMathMenu();
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.Clear();
                MathMenu();
            }
            if (result == "2")
            {
                Console.Clear();
                MainMenu();
            }
            if (result == "3")
            {
                Console.Clear();
                square();


            }
            if (result == "4")
            {
                Console.Clear();

            }



        }
        private static void rechtangle()
        {
            Rectangle myrectangel = new Rectangle();
            Console.Write("Enter the Length of one of the Rectangle Lines : ");
            myrectangel.length = int.Parse(Console.ReadLine());
            Console.Write("Enter the Width of the Rectangle  : ");
            myrectangel.width = int.Parse(Console.ReadLine());
            Console.WriteLine("The Area  of the Rectangle is : "+myrectangel.Area());
            Console.WriteLine("The Primeter  of the Rectangle is : " + myrectangel.Primeter());
            SecondMathMenu();
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.Clear();
                MathMenu();
            }
            if (result == "2")
            {
                Console.Clear();
                MainMenu();
            }
            if (result == "3")
            {
                Console.Clear();
                square();


            }
            if (result == "4")
            {
                Console.Clear();

            }





        }
        private static void AreaAndPrimeter()
        {
            Console.WriteLine("1) Square");
            Console.WriteLine("2) Rectangle");
            Console.Write("Choose a object:");
          int result = int.Parse(Console.ReadLine());
            if (result==1)
            {
                Console.Clear();
                square();
            }

            if (result == 2)
            {
                Console.Clear();
                rechtangle();
            }

        }





    }
}