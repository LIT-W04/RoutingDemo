using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoutingDemo.Models;

namespace RoutingDemo.Controllers
{
    public class HomeController : Controller
    {
        [Route("foobar")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("search/{query?}")]
        public ActionResult Search(string query)
        {
            return View(new SearchViewModel { SearchQuery = query });
        }

        [Route("people/{personId}/view")]
        public void ViewPerson(int personId)
        {
            Response.Write($"<h1>Looking at person {personId}</h1>");
        }
    }
}