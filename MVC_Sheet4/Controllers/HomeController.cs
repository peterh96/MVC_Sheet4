using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Sheet4.Models;


namespace MVC_Sheet4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Meals order)
        {
            //sub type
            double[] subPrices = { 2.0, 2.50, 3.0, 3.50 };

            //meal type;
            double[] mealPrices = {0, 2.0, 2.50 };

            //size type
            double[] sizePrices = { 1.50, 2.00, 2.50, 3.0 };

            //getting the prices for each part
            double price_sub = subPrices[(int)order.selectedSub];

            double price_meal = mealPrices[(int)order.selectedMeal];

            double price_size = sizePrices[(int)order.selectedSize];

            //calculate total
            double total = (price_sub * price_size) + price_meal;
            double tax = 0.15 * total;
            double total_final = total + tax;

            //quantity
            double final_result = total_final * order.quantity;

            //ViewData stuff for results page
            ViewData["sub_type"] = order.selectedSub;
            ViewData["sub_size"] = order.selectedSize;
            ViewData["meal_type"] = order.selectedMeal;
            ViewData["sub_price"] = price_sub * price_size;
            ViewData["meal_price"] = price_meal;

            ViewData["cost"] = total;
            ViewData["tax"] = tax;
            ViewData["total"] = total_final;

            ViewData["final_result"] = final_result;

            return View("Result");
        }
    }
}