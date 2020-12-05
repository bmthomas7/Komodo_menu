using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_repo
{
    public enum IdentifyMenu
    {

    }
    
       public class DevMenu
        {
            public int MealNumber { get; set; }
            public string MealName { get; set; }
            public string Description { get; set; }
            public string Ingredients { get; set; }
            public double Price { get; set; }

            public DevMenu () { }

            public DevMenu(int mealnumber, string mealName, string description, string ingredients, double price)
            {
                MealNumber = mealnumber;
                MealName = mealName;
                Description = description;
                Ingredients = ingredients;
                Price = price;
            }
        }


  
}
