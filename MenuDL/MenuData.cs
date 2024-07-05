using MenuDL;
using MenuModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDL
{
    public class MenuData
    {
        List<Menu> menus;
        public SqlDbData sqlData;

        public MenuData()
        {
            menus = new List<Menu>();
            sqlData = new SqlDbData();
        }

        public List<Menu> GetMenus()
        {
            menus = sqlData.GetMenus();
            return menus;
        }

        public int AddMenu(Menu menu)
        {
            return sqlData.AddMenu(menu.Meal, menu.Dish, menu.Code);

        }

        public int UpdateMenu(Menu menu)
        {
            return sqlData.UpdateMenu(menu.Meal, menu.Dish, menu.Code);
        }

        public int DeleteMenu(Menu menu)
        {
            return sqlData.DeleteMenu(menu.Meal, menu.Dish, menu.Code);
        }

    }
}

