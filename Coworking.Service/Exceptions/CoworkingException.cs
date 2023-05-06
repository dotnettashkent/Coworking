namespace Coworking.Service.Exceptions
{
    public class CoworkingException : Exception
    {
        public int Code { get; set; }

        public CoworkingException(int code, string message)
            : base(message)
        {
            this.Code = code;
        }
    }
}
