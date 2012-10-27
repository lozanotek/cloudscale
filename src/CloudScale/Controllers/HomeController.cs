using System.Web.Mvc;

namespace CloudScale.Controllers {
	using System.Web.Security;

	public class HomeController : Controller {
		public ActionResult Index() {
			return View();
		}

		[HttpPost]
		public ActionResult Auth(string username, string password) {
			var result = FormsAuthentication.Authenticate(username, password);

			if(result) {
				FormsAuthentication.SetAuthCookie(username, false);
			}

			return Index();
		}

		public ActionResult Blitz() {
			return Content("42");
		}
	}
}
