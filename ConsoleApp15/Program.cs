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

        private static void PrintNumber()
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
                    PrintNumber();
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

            string P = "+++";
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
            Console.WriteLine("4)Back to MainMenu");
            Console.WriteLine("5)Exit");
            Console.Write("Please chose a Number to Start the Game : ");
            int result = int.Parse(Console.ReadLine());
            if (result == 1)
            {

                Console.Clear();
                PrintNumber();
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
                MainMenu();
                

            }

            while (result == 5)
            {
               
                Console.Clear();
                
            }


        }           
        private static void MathMenu()
        {
           
            Console.WriteLine("0)Quiz");
            Console.WriteLine("1)Calculator ");
            Console.WriteLine("2)The Area and Primeter  ");
            Console.WriteLine("3)Back to MainMenu ");
            Console.WriteLine("4)Exit  ");
            Console.Write("Choose The Number of the Tool : ");
          
            string result = Console.ReadLine();
            if (result == "0")
            {
                Console.Clear();
                Quiz();
            }
            if (result == "1")
            {
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine("The Calculator");
                Console.WriteLine("----------------------");
                Calculator();
            }
            if (result == "2")
            {
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine("Area & Primeter");
                Console.WriteLine("----------------------");
                AreaAndPrimeter();
            }
            if (result == "3")
            {
                Console.Clear();
               
                MainMenu();
            }
            if (result == "4")
            {
                Console.Clear();
               
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

        private static void Square()
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
                Square();


            }
            if (result == "4")
            {
                Console.Clear();

            }



        }

        private static void Rectangle()
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
                Rectangle();


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
                Square();
            }

            if (result == 2)
            {
                Console.Clear();
                Rectangle();
            }

        }

        private static void Quiz()
        {
            Random Generation = new Random();
           
               
            
            int N1 = Generation.Next(1, 1000);
            int N2 = Generation.Next(1, 1000);
        
                
                
            
            
                int result = (N1 + N2);
                Console.WriteLine("Abouras is my Name,I am a Robot ^_^ and i will test you... \nFind the Answer if you can ! :");
                Console.Write("Question : "+N1 + " + " + N2 + " =");
                int Answer = int.Parse(Console.ReadLine());
                int sub = result - Answer;
                int sub2 = Answer - result;
                if (Answer == result)
                    Console.WriteLine("Your Answer is correct");
                if (Answer < result)
                    Console.WriteLine("The Answer is " + sub + " more ! =>" + result);
                if (Answer > result)
                    Console.WriteLine("The answer is " + sub2 + " less ! =>" + result);
            SecondMathMenu();
            string Result = Console.ReadLine();
            if (Result == "1")
            {
                Console.Clear();
                MathMenu();


            }
            if (Result == "2")
            {
                Console.Clear();
                MainMenu();
            }
            if (Result == "3")
            {
                Console.Clear();
                Quiz();
            }

            if (Result == "4")
            {
                Console.Clear();

            }




        }
        private static void Calculator()
        {

            Console.Write("First Number:");
            var N1 = double.Parse(Console.ReadLine());
            Console.Write("The Opration(+,-,*,/) :");
            var Sign = Console.ReadLine();
            Console.Write("The Second Number :");
            var N2 = double.Parse(Console.ReadLine());
            var plus = N1 + N2;
            var Minus = N1 - N2;
            var Multi = N1 * N2;
            var Divide = N1 / N2;
            if (Sign == "+")
                Console.WriteLine(N1 + "+" + N2 + "=" + plus);
            if (Sign == "-")
                Console.WriteLine(N1 + "-" + N2 + "=" + Minus);
            if (Sign == "*")
                Console.WriteLine(N1 + "*" + N2 + "=" + Multi);
            if (Sign == "/")
                Console.WriteLine(N1 + "/" + N2 + "=" + Divide);
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
                Calculator();


            }
            if (result == "4")
            {
                Console.Clear();

            }

        }



       


    }  
    



}