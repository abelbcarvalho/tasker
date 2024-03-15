using System.Net.WebSockets;
using ModelTask;
using Priority;

namespace ViewTasker
{
    public class TaskerView
    {
        private int alternative = default(int);
        private readonly TaskModel taskModel = new();

        private DateTime CreateDateTime()
        {
            Console.Write("Year :> ");
            int year = int.Parse(Console.ReadLine() ?? "1");

            Console.Write("Month :> ");
            int month = int.Parse(Console.ReadLine() ?? "1");

            Console.Write("Day :> ");
            int day = int.Parse(Console.ReadLine() ?? "1");

            Console.Write("Hour :> ");
            int hour = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Minute :> ");
            int minute = int.Parse(Console.ReadLine() ?? "0");

            return new DateTime(year, month, day, hour, minute, 0);
        }

        protected void SearchForTasksView()
        {
            int option = 0;

            Console.Clear();
            Console.WriteLine("Choose Your Alternative for Search");
            Console.Write("[1] - Search by Title\n[2] - Search by Priority\n[3] - Search by Date\nYour Alternative ::> ");
            this.alternative = int.Parse(Console.ReadLine() ?? "0");

            switch (this.alternative)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Searching by Title\nType Title Here ::> ");
                    this.taskModel.Title = Console.ReadLine() ?? "";
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Searching by Priority");
                    Console.Write("[1] - High\n[2] - Medium\n[3] - Low\nYour Priority ::> ");
                    option = int.Parse(Console.ReadLine() ?? "0");

                    if (option == 1)
                    {
                        this.taskModel.Priority = EnumPriority.High;
                    }
                    else if (option < 3)
                    {
                        this.taskModel.Priority = EnumPriority.Medium;
                    }
                    else if (option < 4)
                    {
                        this.taskModel.Priority = EnumPriority.Low;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Value For Priority");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Searching by Date");
                    Console.WriteLine("[1] - Search by Start At\n[2] - Search by Finish At\n[3] - Search by Date Gap");
                    Console.Write("Your Alternative ::> ");
                    option = int.Parse(Console.ReadLine() ?? "0");

                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Searching By Date Time\nStart Date Time !!!\n");
                            this.taskModel.StartAt = this.CreateDateTime();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Searching By Date Time\nFinish Date Time !!!\n");
                            this.taskModel.FinishAt = this.CreateDateTime();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Searching by Date Gap\nStart At Date Time\n");
                            this.taskModel.StartAt = this.CreateDateTime();
                            Console.WriteLine("\nFinish At Date Time\n");
                            this.taskModel.FinishAt = this.CreateDateTime();
                            break;
                        default:
                            Console.WriteLine("Invalid Alternative!");
                            Console.ReadKey();
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Invalid Alternative!");
                    Console.ReadKey();
                    break;
            }
        }

        protected void CreateNewTaskView()
        {
            Console.Clear();
            Console.WriteLine("Creating a New Tasker\nComplete The Params.\n");

            Console.Write("Title: ");
            this.taskModel.Title = Console.ReadLine() ?? "";

            Console.Write("Description: ");
            this.taskModel.Description = Console.ReadLine() ?? "";

            Console.Write(":: Choose Your Priority\n[1] - High\n[2] - Medium\n[3] - Low\n:=:> ");
            this.alternative = int.Parse(Console.ReadLine() ?? "0");

            this.taskModel.Priority = this.alternative switch
            {
                1 => EnumPriority.High,
                2 => EnumPriority.Medium,
                3 => EnumPriority.Low,
                _ => EnumPriority.Unknown,
            };

            Console.WriteLine(":: Define The Start At Time");
            this.taskModel.StartAt = this.CreateDateTime();

            Console.WriteLine(":: Define The Finish At Time");
            this.taskModel.FinishAt = this.CreateDateTime();
        }

        protected void MenuText()
        {
            try
            {
                Console.WriteLine("Welcome to Tasker View!!!");
                Console.WriteLine("Choose an alternative:");
                Console.WriteLine("[1] - Create New Task");
                Console.WriteLine("[2] - Search For Task(s)");
                Console.WriteLine("[3] - Update a Task");
                Console.WriteLine("[4] - Delete a Task");
                Console.WriteLine("[5] - Finish a Task");
                Console.WriteLine("[0] - Exit from Tasker View");
                Console.Write("Your Alternative: > ");
                this.alternative = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (FormatException)
            {
                this.alternative = 6;
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                this.MenuText();

                switch (this.alternative)
                {
                    case 1:
                        this.CreateNewTaskView();
                        break;
                    case 2:
                        this.SearchForTasksView();
                        break;
                    case 0:
                        Console.WriteLine("Thank You For Use Tasker!");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Running Again! Press any key...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public TaskerView()
        { }
    }
}