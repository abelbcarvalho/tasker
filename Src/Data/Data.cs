using System.Numerics;
using Priority;

namespace Data
{
    public class GetterTasker
    {
        private BigInteger id = default(int);
        private string title = "";
        private string description = "";
        private EnumPriority priority = default(EnumPriority);
        private DateTime startAt = default(DateTime);
        private DateTime finishAt = default(DateTime);
        private bool complete = false;

        public BigInteger Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

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