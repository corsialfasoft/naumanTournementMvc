using GeTorneo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeTorneo.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult addtorneo(){
			return View();
		}
		IDomainModel model = new DomainModel();
		[HttpPost]
		public ActionResult addtorneo(Torneo torneo) {
			model.Save(torneo);
			return View();
		}
	}
}