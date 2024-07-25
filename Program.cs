using System;

namespace Task_Tracker
{
    public class Program
    {
        static List<string> tasks = new List<string>();

        //static int taskIndex = 0;

        public static void Main(string[] args)
        {
            //Welcome User


            //1. Add task
            //2. View all tasks
            //3. Mark task complete
            //4. Remove task
            //5. Exit

            Console.WriteLine("Welcome to my task tracker!");

            while (true)
            {
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
                        ViewTasks();
                        break;
                    }
                    case "3":
                    {
                        //Mark task
                        MarkComplete();
                        break;
                    }
                    case "4":
                    {
                        //Remove task
                        RemoveTask();
                        break;
                    }
                    case "5":
                    {
                        //Exit
                        Environment.Exit(0);
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Please enter a number from 1 to 5");
                        break;
                    }
                }
            }
        }

        private static void AddTask()
        {
            Console.WriteLine("Enter task name");
            string newTask = Console.ReadLine();
            tasks.Add(newTask);
            //tasks[taskIndex] = newTask;
            Console.WriteLine("Task added");
            //taskIndex++;
        }

        private static void ViewTasks()
        {
            Console.WriteLine("Tasks:\n");
            // for (int i = 0; i < taskIndex; i++)
            // {
            //     Console.WriteLine($"Task {i + 1}: {tasks[i]}");
            // }
            foreach (var task in tasks)
            {
                Console.WriteLine($"Task {tasks.IndexOf(task) + 1}: {task}");
            }
        }

        private static void MarkComplete()
        {
            Console.WriteLine($"Enter task number");

            int taskNumber = Convert.ToInt32(Console.ReadLine());

            try
            {
                tasks[taskNumber - 1] += " --COMPLETED";
            }
            catch
            {
                Console.WriteLine("Please enter a valid task number");
            }
        }

        private static void RemoveTask()
        {
            Console.WriteLine($"Enter task number to delete");

            int taskNumber = Convert.ToInt32(Console.ReadLine());

            tasks.RemoveAt(taskNumber - 1);
        }
    }
}
