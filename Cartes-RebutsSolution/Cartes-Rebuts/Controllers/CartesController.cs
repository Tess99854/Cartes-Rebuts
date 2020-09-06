using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cartes_Rebuts.Models;
using Cartes_Rebuts.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cartes_Rebuts.Controllers
{
    public class CartesController : Controller
    {

        private readonly CardRepository __CardRepository = null; 

        public CartesController()
        {
            __CardRepository = new CardRepository(); 

        }

        //public List<CardModel> Index()
        //{
        //    return __CardRepository.getAllCards();
        //}
        public ViewResult Index()
        {
            return View(__CardRepository.getAllCards());
        }

        [HttpGet]
        [Route("Ajouter_Rebut")]
        public IActionResult addcard()
        {
            ViewBag.Posted = false; 
            return View() ;
        }

        [HttpPost]
        [Route("Ajouter_Rebut")]
        public IActionResult addcard(CardModel Card)
        {
            int line = __CardRepository.getCountCards(); 
            Card.Id = line +1; 
            Card.Valeur = Card.PMP * Card.Qte;

            __CardRepository.addCard(Card, line); 
            return RedirectToAction("Index");
        }


        public IActionResult Generer_fichier()
        {
            return View(); 
        }

        public string getDesignation(int id)
        {
              return __CardRepository.getDesign(id); 
           
        }

        //u can use an id in the path by passing an int id as a param to the action method
        //u can also pass string parms and use query string in the url 
    }
}
