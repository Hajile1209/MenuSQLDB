using MenuDL;
using MenuModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBL
{
    public class MenuTransactionServices
    {

        MenuValidationServices ValidationServices = new MenuValidationServices();
        MenuData menuData = new MenuData();

        public bool CreateMenu(Menu menu)
        {
            bool result = false;

            if (ValidationServices.CheckIfMealExists(menu.Meal))
            {
                result = menuData.AddMenu(menu) > 0;
            }

            return result;
        }

        public bool CreateMenu(string Meal, string Dish, string Code)
        {
            Menu menu = new Menu { Meal = Meal, Dish = Dish, Code = Code };

            return CreateMenu(menu);
        }

        public bool UpdateMenu(Menu menu)
        {
            bool result = false;

            if (ValidationServices.CheckIfMealExists(menu.Meal))
            {
                result = menuData.UpdateMenu(menu) > 0;
            }

            return result;
        }

        public bool UpdateMenu(string Meal, string Dish, string Code)
        {
            Menu menu = new Menu { Meal = Meal, Dish = Dish, Code = Code };

            return UpdateMenu(menu);
        }
        public bool DeleteMenu(Menu menu)
        {
            bool result = false;

            if (ValidationServices.CheckIfMealExists(menu.Meal))
            {
                result = menuData.DeleteMenu(menu) > 0;
            }

            return result;
        }
        public bool DeleteMenu(string Meal, string Dish, string Code)
        {
            Menu menu = new Menu { Meal = Meal, Dish = Dish, Code = Code };

            return DeleteMenu(menu);
        }
    }
}