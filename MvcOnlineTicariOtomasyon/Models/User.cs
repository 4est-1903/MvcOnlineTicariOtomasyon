using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models
{
	public class User : IdentityUser
	{
		[Required]
		[StringLength(100)]
		public string FullName { get; set; }
    }
}