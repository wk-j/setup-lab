using FluentScheduler;

namespace MyWeb.Jobs
{
    public class HelloJob : IJob
    {
        public void Execute()
        {
            Console.WriteLine($"Hello from FluentScheduler! Current time: {DateTime.Now}");
        }
    }
}
