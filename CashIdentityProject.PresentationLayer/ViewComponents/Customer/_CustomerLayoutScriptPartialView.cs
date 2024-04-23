using Microsoft.AspNetCore.Mvc;

namespace CashIdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartialView:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
