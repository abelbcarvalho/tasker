using Exceptions;

namespace UtilString
{
    public class StringUtil
    {
        public static bool IsNotEmptyString(string value, string field = "field")
        {
            if (IsEmpty(value))
            {
                throw new StringException($"Attribute {field} should not be empty.");
            }

            return true;
        }

        public static bool IsNotGreaterThan(string value, int size, string field = "field")
        {
            if (value.Length > size)
            {
                throw new StringException($"Attribute {field} length should not be greater than {size}.");
            }

            return true;
        }

        public static bool IsEmpty(string value)
        {
            return value.Length == 0;
        }
    }
}