using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Sheet4.Models
{
    public class Meals
    {
        //sub type
        public enum subTypes {TheMichaelJackson = 0, ThePrince = 1, TheBackStreetBoys = 2, TheBeyonce = 3}
        public subTypes selectedSub { set; get; }

        //meal type
        public enum mealTypes {None = 0, DrinksAndChips = 1, DrinkAndCookies = 2}
        public mealTypes selectedMeal { get; set; }

        //size type
        public enum sizeTypes {onehitwonder = 0, blist = 1,  alist = 3,superstar = 4}
        public sizeTypes selectedSize { get; set; }


    }
}