using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoixResto.Controllers
{
    public class ResultatController : Controller
    {

        private IDal dal;

        public ResultatController() : this(new Dal())
        {
        }

        public ResultatController(IDal dalIoc)
        {
            dal = dalIoc;
        }

        // GET: Resultat
        public ActionResult Index()
        {
            return View();
        }
    }
}