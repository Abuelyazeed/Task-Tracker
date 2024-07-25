using System;

namespace Task_Tracker
{
    public class Program
    {
        static string[] tasks = new string[100];
        static int taskIndex = 0;

        public static void Main(string[] args)
        {
            //Welcome User


            //1. Add task
            //2. View all tasks
            //3. Mark task complete
            //4. Remove task
            //5. Exit

            Console.WriteLine("Welcome to my task tracker!");
            Console.WriteLine("Please enter a number from 1 to 5");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                {
                    //Add task"
                    AddTask();
                    break;
                }
                case "2":
                {
                    //View all tasks
                    break;
                }
                case "3":
                {
                    //Mark task
                    break;
                }
                case "4":
                {
                    //Remove task
                    break;
                }
                case "5":
                {
                    //Exit
                    break;
                }
                default:
                {
                    Console.WriteLine("Please enter a number from 1 to 5");
                    break;
                }
            }
        }

        private static void AddTask()
        {
            Console.WriteLine("Enter task name");
            string newTask = Console.ReadLine();
            tasks[taskIndex] = newTask;
            Console.WriteLine("Task added");
            taskIndex++;
        }
    }
}
