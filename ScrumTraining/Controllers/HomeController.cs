using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScrumTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Culture()
        {
            ViewBag.Message = "Culture";

            return View();
        }


        public ActionResult Geography()
        {
            ViewBag.Message = "Geography";

            return View();
        }


        public ActionResult HistoricPlaces()
        {
            ViewBag.Message = "HistoricPlaces";

            return View();
        }

        public ActionResult TopTouristLocations()
        {
            ViewBag.Message = "Top Tourist Locations";

            return View();
        }

        public ActionResult PictureGallery()
        {
            ViewBag.Message = "Picture Gallery";

            return View();
        }
        public ActionResult Weather()
        {
            ViewBag.Message = "Picture Gallery";

            return View();
        }


    }
}