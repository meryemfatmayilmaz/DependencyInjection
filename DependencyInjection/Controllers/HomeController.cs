using DependencyInjection.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers;
public class HomeController : Controller
{
	readonly ILog _log;
	public HomeController(ILog log)
	{
		_log = log;
	}
	public IActionResult Index()
	{
		_log.Log();
		return View();
	}
}
