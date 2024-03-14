namespace ViewTasker
{
    public class TaskerView
    {
        private int alternative = default(int);

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
                
                switch (this.alternative) {
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