namespace MenuBL
{
    public class MenuValidationServices
    {
        MenuGetServices mgetServices = new MenuGetServices();

        public bool CheckIfMealExists(string Meal)
        {
            bool result = mgetServices.GetMeal(Meal) != null;
            return result;
        }

        public bool CheckIfMealExists(string Meal, string Dish, string Code)
        {
            bool result = mgetServices.GetMenus(Meal, Dish, Code) != null;
            return result;
        }
    }
}