using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class CircleApp
    {

        public List<Circle> Circles = new List<Circle>();

        public void Run()
        {

            


            bool tryAgain;
            tryAgain = true;

            while(tryAgain == true)
            {
                try
                {
                    Console.WriteLine("Please enter valid radius");
                    double radius = double.Parse(Console.ReadLine());

                    if(radius < 0)
                    {
                        throw new IndexOutOfRangeException("Pease enter valid positve number");
                    }

                    Circle c = new Circle(radius);
                    Circles.Add(c);

                    Console.WriteLine("Do you want to continue? Y/N");
                    string input = Console.ReadLine().ToLower();
                    if (input == "y")
                    {
                        tryAgain = true;
                    }
                    if (input == "n")
                    {
                        tryAgain = false;
                    }

                }
                catch (IndexOutOfRangeException e)
                {

                    Console.WriteLine("Student not found, please enter valid positive number.");
                }
               

                




            }

            

            foreach(Circle circle in Circles)
            {
                circle.PrintInfo();
                
            }

            


        }

        //public void PrintCircles()
        //{
        //    Circle a = new Circle();
        //    a.PrintInfo();

        //}





    }
}
