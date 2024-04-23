using CashIdentityProject.BusinnesLayer.Abstract;
using CashIdentityProject.DataAccesLayer.Concrete;
using CashIdentityProject.DtoLayer.Dtos.CustomerAccountProcessDtos;
using CashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CashIdentityProject.PresentationLayer.Controllers
{
    public class SendMoneyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

		public SendMoneyController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
		{
			_userManager=userManager;
			_customerAccountProcessService=customerAccountProcessService;
		}

		[HttpGet]
		public IActionResult Index(string mycurrency)
		{
			ViewBag.currency = mycurrency;
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
		{
			var context = new Context();

			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			var receiverAccountNumberID = context.CustomerAccounts.Where(x => x.CustomerAccountNumber == sendMoneyForCustomerAccountProcessDto.ReceiverAccountNumber).Select(y => y.CustomerAccountID).FirstOrDefault();

			var senderAccountNumberID = context.CustomerAccounts.Where(x => x.AppUserID == user.Id).Where(y => y.CustomerAccountCurrency == "TL").Select(z => z.CustomerAccountID).FirstOrDefault();

			var values = new CustomerAccountProcess();
			values.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			values.SenderID = senderAccountNumberID;
			values.ProcessType = "SendMoney";
			values.ReceiverID = receiverAccountNumberID;
			values.Amount = sendMoneyForCustomerAccountProcessDto.Amount;
			values.Description = sendMoneyForCustomerAccountProcessDto.Description;

			_customerAccountProcessService.TInsert(values);


			return RedirectToAction("Index", "Deneme");
		}
    }
}
