﻿using System.Web.Mvc;

namespace CloudScale.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {

			return View();
		}

		public ActionResult Blitz() {
			return Content("42");
		}
	}
}
