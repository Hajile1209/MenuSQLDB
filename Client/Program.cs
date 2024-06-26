using MenuBL;

namespace MenuModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuGetServices mgetServices = new MenuGetServices();
            var menus = mgetServices.GetAllMenus();
            foreach (var item in menus)
            {
                Console.WriteLine(item.Meal);
                Console.WriteLine(item.Dish);
                Console.WriteLine(item.Code);
            }

        }
    }
}