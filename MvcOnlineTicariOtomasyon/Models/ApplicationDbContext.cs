using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace MvcOnlineTicariOtomasyon.Models
{
	public class ApplicationDbContext : IdentityDbContext<User>
    {
		public ApplicationDbContext() : base ("DefaultConnection") { }

		public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}