using System;

namespace Task_Tracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Welcome User


            //1. Add task
            //2. View all tasks
            //3. Mark task complete
            //4. Remove task
            //5. Exit

            Console.WriteLine("Welcome to my task tracker!");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                {
                    Console.WriteLine("Add task");
                    break;
                }
                case "2":
                {
                    Console.WriteLine("View all");
                    break;
                }
                case "3":
                {
                    Console.WriteLine("Mark task");
                    break;
                }
                case "4":
                {
                    Console.WriteLine("Remove task");
                    break;
                }
                case "5":
                {
                    Console.WriteLine("Exit");
                    break;
                }
            }
        }
    }
}
