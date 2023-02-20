using DependencyInjection.Services.Interfaces;

namespace DependencyInjection.Services
{
	public class ConsoleLog : ILog
	{
		public ConsoleLog(int value)
		{

		}
		public void Log()
		{
			Console.WriteLine("ConsoleLog success");
		}
	}
}
