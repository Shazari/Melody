using DataLayer.Tools.Infrastructure;
using Melody.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melody.Controllers
{
    public class HomeController : BaseUnitOfWorkController
    {
        public ActionResult Index()
        {
            List<Course> oCourse = 
                UnitOfWork.CourseRepository.Get().ToList();

            Course entity = new Course()
            {
                Name = "dsdsdsd"
            };
            UnitOfWork.CourseRepository.Insert(entity);
            UnitOfWork.Save();

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
    }
}