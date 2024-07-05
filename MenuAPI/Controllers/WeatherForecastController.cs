using Microsoft.AspNetCore.Mvc;
using MenuBL;


namespace MenuAPI.Controllers
{
    [ApiController]
    [Route("api/Menu")]
    public class MenuServiceController : ControllerBase
    {
        MenuGetServices menuServices;
        MenuTransactionServices menuTransactionServices;

        public MenuServiceController()
        {
            menuServices = new MenuGetServices();
            menuTransactionServices = new MenuTransactionServices();
        }

        [HttpGet]
        public IEnumerable<MenuAPI.Menu> GetMenus()
        {
            var menus = menuServices.GetAllMenus();

            List<MenuAPI.Menu> cont = new List<MenuAPI.Menu>();

            foreach (var menu in menus)
            {
                cont.Add(new MenuAPI.Menu { Meal = menu.Meal, Dish = menu.Dish, Code = menu.Code });
            }
            return cont;

        }
        [HttpPost]
        public JsonResult AddMenu(Menu request)
        {
            var result = menuTransactionServices.CreateMenu(request.Meal, request.Dish, request.Code);

            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateMenu(Menu request)
        {
            var result = menuTransactionServices.UpdateMenu(request.Meal, request.Dish, request.Code);

            return new JsonResult(result);
        }

    }
}
