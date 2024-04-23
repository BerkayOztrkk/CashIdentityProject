
using CashIdentityProject.DataAccesLayer.Abstract;
using CashIdentityProject.DataAccesLayer.Concrete;
using CashIdentityProject.DataAccesLayer.Repositories;
using CashIdentityProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashIdentityProject.DataAccesLayer.EntityFramework
{
	public class EfCustomerAccountProcessDal : GenericRepository<CustomerAccountProcess>, ICustomerAccountProcessDal
    {
		public List<CustomerAccountProcess> MyLastProcess(int id)
		{
			using var context = new Context();
			var values=context.CustomerAccountProccesses.Include(y=>y.SenderCustomer).ThenInclude(z=>z.AppUser).Where(x=>x.ReceiverID==id||x.SenderID==id).ToList();
			return values;
		}

	}
}
