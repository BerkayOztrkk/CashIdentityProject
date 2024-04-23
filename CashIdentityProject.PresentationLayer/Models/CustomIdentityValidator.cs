using Microsoft.AspNetCore.Identity;

namespace CashIdentityProject.PresentationLayer.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return base.PasswordTooShort(length);
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return base.PasswordRequiresUpper();
		}
		public override IdentityError PasswordRequiresLower()
		{
			return base.PasswordRequiresLower();
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return base.PasswordRequiresDigit();
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return base.PasswordRequiresNonAlphanumeric();
		}

	}
}
