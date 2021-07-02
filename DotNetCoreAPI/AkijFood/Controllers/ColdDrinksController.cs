using CRUDoperation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColdDrinksController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly dbAkijFoodDbContext _context;

        public ColdDrinksController(IConfiguration configuration, dbAkijFoodDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<tblColdDrinks>> Index()
        {
            return _context.tblColdDrinks.ToArray();
        }

        [Route("API01")]
        [HttpGet]
        public ActionResult API01()
        {
            tblColdDrinks drinks = new tblColdDrinks();
            drinks.strColdDrinksName = "Mojo";
            drinks.numQuantity = 575;
            drinks.numUnitPrice = 15;
            _context.Add(drinks);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("API02")]
        [HttpGet]
        public ActionResult API02()
        {
            tblColdDrinks coldDrinks = new tblColdDrinks();
            coldDrinks = _context.tblColdDrinks.Where(c => c.strColdDrinksName == "Frutika").FirstOrDefault();
            coldDrinks.numUnitPrice = 35;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("API03")]
        [HttpGet]
        public ActionResult API03()
        {
            var Drinks = _context.tblColdDrinks.Where(c => c.strColdDrinksName == "Speed").FirstOrDefault();
            _context.tblColdDrinks.Remove(Drinks);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("API04")]
        [HttpGet]
        public string[] API04()
        {
            var DrinksName = _context.tblColdDrinks.Select(c => c.strColdDrinksName).ToArray();
            return DrinksName;
        }


        [Route("API05")]
        [HttpGet]
        public ActionResult API05()
        {
            var Drinks = _context.tblColdDrinks.Where(c => c.numQuantity < 500).ToArray();
            for(var i = 0; i < Drinks.Length; i++)
            {
                _context.tblColdDrinks.Remove(Drinks[i]);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [Route("API06")]
        [HttpGet]
        public List<decimal> API06()
        {
            var Drinks = _context.tblColdDrinks.ToArray();

            List<decimal> totalPrice = new List<decimal>();
            decimal Sum = 0;
            for (var i =0; i< Drinks.Length; i++)
            {
                var price = Drinks[i].numQuantity * Drinks[i].numUnitPrice;
                totalPrice.Add(price);
                Sum =+ price;
            }
            totalPrice.Add(Sum);
            return totalPrice;
        }
    }
}
