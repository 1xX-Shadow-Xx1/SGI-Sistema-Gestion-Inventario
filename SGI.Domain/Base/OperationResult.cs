namespace SGI.Domain.Base
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public dynamic? Data { get; set; }

        public static OperationResult Ok(string message, dynamic? data = null) => new OperationResult
        {
            Success = true,
            Message = message,
            Data = data
        };

        public static OperationResult Fail(string message) => new OperationResult
        {
            Success = false,
            Message = message,
            Data = null
        };
    }
}
