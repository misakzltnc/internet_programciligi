﻿using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMvc.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return Content("Hello World");
		}
	}
}