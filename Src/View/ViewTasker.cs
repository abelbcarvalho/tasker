using System.Numerics;
using Controller;
using ModelTask;
using Priority;
using TaskModelUtil;

namespace ViewTasker
{
    public class TaskerView
    {
        private int alternative = default(int);
        private readonly TaskModel taskModel = new();
        private readonly ControllerTasker controller = new();
        private List<TaskModel> taskers = [];

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

        private void ListTaskersGotFromDB()
        {
            Console.WriteLine("Listing All Got Taskers !!\n---------------------------------");
            foreach (TaskModel task in this.taskers)
            {
                Console.WriteLine($"ID: {task.Id}");
                Console.WriteLine($"Title: {task.Title}");
                Console.WriteLine($"Description: {task.Description}");
                Console.WriteLine($"Priority: {task.Priority}");
                Console.WriteLine($"Complete: {task.Complete}");
                Console.WriteLine($"StartAt: {task.StartAt}");
                Console.WriteLine($"FinishAt: {task.FinishAt}\n---------------------------------");
            }
        }

        protected void FinishTaskView()
        {
            Console.Clear();
            Console.WriteLine("Finish A Specific Task");

            Console.WriteLine("\n\tPlease check the Option about Search before, to get ID\n");

            Console.Write("Type The Task ID ::> ");

            BigInteger idTask = BigInteger.Parse(Console.ReadLine() ?? "0");

            bool result = this.controller.FinishTasker(idTask);

            if (result)
            {
                Console.WriteLine("Success! This Task Was Finished!!");
            }
        }

        protected void DeleteTaskView()
        {
            Console.Clear();
            Console.WriteLine("Delete A Specific Task");

            Console.WriteLine("\n\tPlease check the Option about Search before, to get ID\n");

            Console.Write("Type The Task ID ::> ");

            BigInteger idTask = BigInteger.Parse(Console.ReadLine() ?? "0");

            bool result = this.controller.DeleteTasker(idTask);

            if (result)
            {
                Console.WriteLine("Success! This Task Was Deleted!!");
            }
        }

        protected void UpdateTaskView()
        {
            ModelTaskUtil.ModelToDefault(this.taskModel);
            
            Console.Clear();
            Console.WriteLine("Creating an Existing Tasker\nComplete The Params.\n");

            Console.Write("Tasker ID: ");
            BigInteger taskId = BigInteger.Parse(Console.ReadLine() ?? "0");

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

            controller.UpdateTasker(this.taskModel, taskId);

            Console.WriteLine("Success to Create a New Task!");
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

                    this.taskers = this.controller.GetTaskersByTitle(this.taskModel.Title);

                    this.ListTaskersGotFromDB();
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
                        break;
                    }

                    this.taskers = this.controller.GetTaskersByPriority(this.taskModel.Priority);

                    this.ListTaskersGotFromDB();
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

                            this.taskers = this.controller.GetTaskersByDateTimeStart(this.taskModel.StartAt);

                            this.ListTaskersGotFromDB();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Searching By Date Time\nFinish Date Time !!!\n");
                            this.taskModel.FinishAt = this.CreateDateTime();

                            this.taskers = this.controller.GetTaskersByDateTimeFinish(this.taskModel.FinishAt);

                            this.ListTaskersGotFromDB();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Searching by Date Gap\nStart At Date Time\n");
                            this.taskModel.StartAt = this.CreateDateTime();
                            Console.WriteLine("\nFinish At Date Time\n");
                            this.taskModel.FinishAt = this.CreateDateTime();

                            this.taskers = this.controller.GetTaskersByDateTimeStartAndFinish(
                                this.taskModel.StartAt, this.taskModel.FinishAt
                            );

                            this.ListTaskersGotFromDB();
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

            controller.CreateTask(this.taskModel);

            Console.WriteLine("Success to Create a New Task!");
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
                    case 3:
                        this.UpdateTaskView();
                        break;
                    case 4:
                        this.DeleteTaskView();
                        break;
                    case 5:
                        this.FinishTaskView();
                        break;
                    case 0:
                        Console.WriteLine("Thank You For Use Tasker!");
                        return;
                    default:
                        Console.WriteLine("Running Again! Press any key...");
                        break;
                }

                Console.ReadKey();
            }
        }

        public TaskerView()
        { }
    }
}