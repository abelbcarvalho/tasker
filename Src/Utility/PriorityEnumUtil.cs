using Exceptions;
using Priority;

namespace PriorityEnumUtil
{
    public class PriorityUtil
    {
        public static bool IsUnknow(EnumPriority priority)
        {
            if (priority.Equals(EnumPriority.Unknown))
            {
                throw new PriorityUnknownException("Priority should not be Unknown");
            }

            return false;
        }
    }
}