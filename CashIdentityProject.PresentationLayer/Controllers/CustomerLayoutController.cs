using Microsoft.AspNetCore.Mvc;

namespace CashIdentityProject.PresentationLayer.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
