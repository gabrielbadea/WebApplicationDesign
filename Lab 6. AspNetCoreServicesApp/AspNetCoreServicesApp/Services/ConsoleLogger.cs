using AspNetCoreServicesApp.Services.Interfaces;

namespace AspNetCoreServicesApp.Services
{
    public class ConsoleLogger : ILog
    {
        public void Info(string textToLog)
        {
            Console.WriteLine(textToLog);
        }
    }
}
