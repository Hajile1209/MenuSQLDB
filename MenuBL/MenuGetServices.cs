using MenuDL;
using MenuModels;

namespace MenuBL
{
    public class MenuGetServices
    {
        public List<Menu> GetAllMenus()
        {
            MenuData menuData = new MenuData();

            return menuData.GetMenus();

        }

        public List<Menu> GetMeal(string Meal)
        {
            List<Menu> menus = new List<Menu>();

            foreach (var menu in GetAllMenus())
            {
                if (menu.Meal == Meal)
                {
                    menus.Add(menu);
                }
            }
            return menus;
        }

        public Menu GetMenus(string Meal, string Dish, string Code)
        {
            Menu foundMenu = new Menu();

            foreach (var menu in GetAllMenus())
            {
                if (menu.Meal == Meal && menu.Dish == Dish && menu.Code == Code)
                {
                    foundMenu = menu;
                }
            }
            return foundMenu;
        }
    }
}