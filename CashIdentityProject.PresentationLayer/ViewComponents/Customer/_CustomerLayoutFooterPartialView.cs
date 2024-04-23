using Microsoft.AspNetCore.Mvc;

namespace CashIdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartialView:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
