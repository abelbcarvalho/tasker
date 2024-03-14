using ModelTask;
using Priority;

namespace ViewTasker
{
    public class TaskerView
    {
        private int alternative = default(int);
        private TaskModel taskModel = new();

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