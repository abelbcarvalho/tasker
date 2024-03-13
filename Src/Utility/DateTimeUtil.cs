using Exceptions;

namespace UtilDateTime
{
    public class DateTimeUtil
    {
        public static bool IsNotStartGreaterThanFinish(DateTime start, DateTime finish)
        {
            if (start > finish)
            {
                throw new DateTimeException("Start date time should not be greater than Finish date time.");
            }

            return true;
        }
    }
}