using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin!")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi  Girin!")]
        public string password { get; set; }
    }
}
