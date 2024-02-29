using Priority;

namespace ModelTask
{
    public class TaskModel
    {
        private string title = "";
        private string description = "";
        private EnumPriority priority;
        private DateTime startAt;
        private DateTime finishAt;
        private bool complete;

        public string Title
        {
            set
            {
                title = value;
            }
            get
            {
                return title;
            }
        }

        public string Description
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }

        public EnumPriority Priority
        {
            set
            {
                priority = value;
            }
            get
            {
                return priority;
            }
        }

        public DateTime StartAt
        {
            set
            {
                startAt = value;
            }
            get
            {
                return startAt;
            }
        }

        public DateTime FinishAt
        {
            set
            {
                finishAt = value;
            }
            get
            {
                return finishAt;
            }
        }

        public bool Complete
        {
            set
            {
                complete = value;
            }
            get
            {
                return complete;
            }
        }
    }
}