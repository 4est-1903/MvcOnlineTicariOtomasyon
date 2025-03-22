using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcOnlineTicariOtomasyon.Models
{
	public class ApplicationUserManager : UserManager<User>
    {
		public ApplicationUserManager(IUserStore<User> store) : base(store) { }

        public static ApplicationUserManager Create()
        {
            var manager = new ApplicationUserManager(new UserStore<User>(new ApplicationDbContext()));
            return manager;
        }
    }
}