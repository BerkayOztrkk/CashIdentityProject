using Microsoft.AspNetCore.Mvc;

namespace CashIdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartialView:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
