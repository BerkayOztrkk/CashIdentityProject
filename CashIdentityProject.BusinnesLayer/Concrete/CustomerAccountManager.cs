using CashIdentityProject.BusinnesLayer.Abstract;
using CashIdentityProject.DataAccesLayer.Abstract;
using CashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashIdentityProject.BusinnesLayer.Concrete
{
	public class CustomerAccountManager : ICustomerAccountService
	{
		private readonly ICustomerAccountDal customerAccountDal;

		public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
		{
			this.customerAccountDal=customerAccountDal;
		}

		public void TDelete(CustomerAccount t)
		{
			customerAccountDal.Delete(t);
		}

		public CustomerAccount TGetByID(int id)
		{
		 return customerAccountDal.GetByID(id);
		}

        public List<CustomerAccount> TGetCustomerAccountsList(int id)
        {
			return customerAccountDal.GetCustomerAccountsList(id);
        }

        public List<CustomerAccount> TGetList()
		{
			return customerAccountDal.GetList();
		}

		public void TInsert(CustomerAccount t)
		{
			customerAccountDal.Insert(t);
		}

		public void TUpdate(CustomerAccount t)
		{
			customerAccountDal.Update(t);
		}
	}
}
