using DependencyInjection.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILog _log;
		public IndexModel(ILog log)
		{
			_log = log;
		}

		public void OnGet()
		{
			_log.Log();
		}
	}
}