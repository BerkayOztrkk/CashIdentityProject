using Microsoft.AspNetCore.Mvc;

namespace CashIdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartialView:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
