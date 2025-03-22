using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MvcOnlineTicariOtomasyon.Models
{
	public class LoginViewModel
	{
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}