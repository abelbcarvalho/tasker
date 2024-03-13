namespace Exceptions
{
    public class StringException : Exception
    {
        public StringException()
        {}
        
        public StringException(string message): base(message)
        {}
    }

    public class DateTimeException : Exception
    {
        public DateTimeException()
        {}

        public DateTimeException(string message) : base(message)
        {}
    }
}