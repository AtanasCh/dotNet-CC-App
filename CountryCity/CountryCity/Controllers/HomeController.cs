using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using PagedList;
using PagedList.Mvc;

namespace CountryCity.Controllers
{
    public class HomeController : Controller
    {
        
        private CSDBEntities _db = new CSDBEntities();

        public ActionResult Index(int? page)
        {
            return View(_db.Cities.ToList().ToPagedList(page ?? 1, 10));
        }



        /*
         *
         *
         public ActionResult Index()

        {

            return View(_db.Cities.ToList());

        }

             public ActionResult Index(string searchBy, string search, int? page)
        {
            if (searchBy == "City")
            {
                return View(_db.Cities.Where(x => x.City1 == search || search == null)
                    .ToList().ToPagedList(page ?? 1, 10));
            }
            else
            {
                return View(_db.Cities.Where(x=> x.City1.StartsWith(search) || search = null).toList().toPagedList(page ?? 1, 10))
            }



        }
         * 
         * 
         */


        public ActionResult Create()

        {

            return View();

        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Create(City CityToCreate)

        {

            if (!ModelState.IsValid)

                return View();

            _db.Cities.Add(CityToCreate);

            _db.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult CreateCountry()

        {

            return View();

        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult CreateCountry(Country CountryToCreate)

        {

            if (!ModelState.IsValid)

                return View();

            _db.Countries.Add(CountryToCreate);

            _db.SaveChanges();

            return RedirectToAction("Index");

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
    }
}