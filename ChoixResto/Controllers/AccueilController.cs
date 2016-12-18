using ChoixResto.Models;
using ChoixResto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoixResto.Controllers
{
    public class AccueilController : Controller
    {
        private IDal dal;

        public AccueilController() : this(new Dal())
        {
        }

        public AccueilController(IDal dalIoc)
        {
            dal = dalIoc;
        }
        // GET: Accueil
        public ActionResult Index()
        {
            
            AccueilViewModel vm = new AccueilViewModel
            {
                Message = "Bonjour depuis le contrôleur",
                Date = DateTime.Now,
                Resto = new Resto { Nom = "La bonne fourchette", Telephone = "1234" },
                Login = "issa"
              
            };

            List<Resto> listeDesRestos = new List<Resto>
{
    new Resto { Id = 1, Nom = "Resto pinambour", Telephone = "1234" },
    new Resto { Id = 2, Nom = "Resto tologie", Telephone = "1234" },
    new Resto { Id = 5, Nom = "Resto ride", Telephone = "5678" },
    new Resto { Id = 9, Nom = "Resto toro", Telephone = "555" },
};

            ViewBag.ListeDesRestos = new SelectList(listeDesRestos, "Id", "Nom");
            
            return View(vm);
        }

        [ChildActionOnly]
        public ActionResult AfficheListeRestaurant()
        {
            List<Models.Resto> listeDesRestos = new List<Resto>
    {
        new Resto { Id = 1, Nom = "Resto pinambour", Telephone = "1234" },
        new Resto { Id = 2, Nom = "Resto tologie", Telephone = "1234" },
        new Resto { Id = 5, Nom = "Resto ride", Telephone = "5678" },
        new Resto { Id = 9, Nom = "Resto toro", Telephone = "555" },
    };
            return PartialView(listeDesRestos);
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexPost()
        {
            int idSondage = dal.CreerUnSondage();
            return RedirectToAction("Index", "Vote", new { id = idSondage });
        }
    }
}