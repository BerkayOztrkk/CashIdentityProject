using CashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashIdentityProject.DataAccesLayer.Abstract
{
	public interface ICustomerAccountDal:IGenericDal<CustomerAccount>
	{
		List<CustomerAccount> GetCustomerAccountsList(int id);
	}
}
