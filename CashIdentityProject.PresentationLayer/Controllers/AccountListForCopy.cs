using CashIdentityProject.BusinnesLayer.Abstract;
using CashIdentityProject.DataAccesLayer.Concrete;
using CashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CashIdentityProject.PresentationLayer.Controllers
{
	public class AccountListForCopy : Controller
	{
        private readonly UserManager<AppUser> _userManager;
		private readonly ICustomerAccountService _customerAccountService;

        public AccountListForCopy(UserManager<AppUser> userManager, ICustomerAccountService customerAccountService)
        {
            _userManager=userManager;
            _customerAccountService=customerAccountService;
        }

        public async Task<IActionResult> Index()
		{
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var context = new Context();
            var values = _customerAccountService.TGetCustomerAccountsList(user.Id);
            return View(values);
		}
	}
}
