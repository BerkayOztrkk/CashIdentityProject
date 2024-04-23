using Microsoft.AspNetCore.Mvc;

namespace CashIdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartialView:ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
