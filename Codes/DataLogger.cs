
namespace Middleware
{
    public class DataLogger 
    {
        private readonly RequestDelegate _next;

        string _filePath = "Logs/logger.txt";
        public DataLogger(RequestDelegate _next)
        {
            this._next = _next;

        }
        public Task Invoke(HttpContext context)
        {
            var directory = Path.GetDirectoryName(_filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var logInfo = $"[{DateTime.Now}] {context.Request.Method} {context.Request.Path}{Environment.NewLine}";

            File.AppendAllText(_filePath, logInfo);
            return _next(context);
        }
    }
}
