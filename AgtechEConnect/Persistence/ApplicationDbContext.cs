using AgtechEConnect.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AgtechEConnect.Persistence
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext()
			: base(Constants.APP_CONNECTIONSTRING_NAME, throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
	}
}