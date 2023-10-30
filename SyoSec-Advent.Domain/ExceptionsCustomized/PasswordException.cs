namespace SyosecAdvent.Domain.ExceptionsCustomized
{
    public class PasswordException : Exception
    {
        public PasswordException(string message) 
            :base(message) 
        {
                
        }
    }
}
