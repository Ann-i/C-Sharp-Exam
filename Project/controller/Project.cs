using System;
using Project.model;
using System.Text;
using Project.view;

namespace Project
{
    class Project
    {
        static void Main(string[] args)
        {
            //any conditions
            Output.Print("1. Inintialize by hardcode; \n" +
                         "2. Inintialize by random; \n");

            Output.Print("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadKey());
            //selecting the method of initialization array
            switch (choice)
            {
                case 1:
                    {
                        //any method
                        break;
                    }
                case 2:
                    {
                        //any method
                        break;
                    }
                    
                default:
                    {
                        Output.Print("Sorry, but there's no such thing here.");
                        return;
                    }
            }
            //Does the user want to print "salad"
            Output.Print("Did you want to print array?\n(YES - press \"y\", NO - press any key");
            string key = Convert.ToString(Console.ReadKey());
            if (key == "y")
            {
                //call any method which print array
            }

            //any conditions
            Output.Print("1. Find weight of salad;\n" +
                         "2. Fint count of calories in salad;\n" +
                         "3. Find the most-high calories product;\n");

            Output.Print("Your choice: ");
            choice = Convert.ToInt32(Console.ReadKey());
            switch (choice)
            {
                case 1:
                    { 
                        //any method
                    break;
                    }
                case 2:
                    { 
                        //any method
                    break;
                    }
                case 3:
                    { 
                        //any method
                    break;
                    }
                default:
                    {
                        Output.Print("Sorry, but there's no such thing here.");
                        return;
                    }
            }

            /*
            Output.Print("");
            Output.Print("");
            Output.Print("");
            Output.Print("");
            */

        }
    }
}
