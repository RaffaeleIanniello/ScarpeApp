using ScarpeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScarpeApp.Controllers
{
    public class HomeController : Controller
    {
        public List<Prodotto> prodotti = DB.getProdotti();

        public ActionResult Index()
        {

            return View(prodotti);
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            ViewBag.Prodotti = prodotti;
            Prodotto selectedPrd = DB.getProdotto(id, prodotti);

            return View(selectedPrd);
        }

    }
}