using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollectionSortEmpty.Controllers
{
    public class CollectionSortController : Controller
    {
        // GET: CollectionSort
        public ActionResult Index()
        {
            List<int> list = new List<int>();
            Random rand = new Random();

            for (int ctr = 0; ctr <= 4; ctr++)
            {
                list.Add(rand.Next(0, 100));
                list.Sort();

                ViewBag.List = list;
            }
            return View();

        }
    }
}