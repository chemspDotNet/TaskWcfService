using MVCTaskClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTaskClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<QuoteViewModel> list = new List<QuoteViewModel>();
            var tasks = new TaskServiceReference.Service1Client().GetQuotes();
            foreach (var item in tasks)
            {
                list.Add(new QuoteViewModel(item.QuoteID, item.QuoteName, item.QuoteType));
            }

            return View(list);
        }


    }
}
