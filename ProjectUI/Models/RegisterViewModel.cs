﻿using System.ComponentModel.DataAnnotations;

namespace ProjectUI.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz!!!")]
        [MinLength(3, ErrorMessage = "Bu Alana 3 Karakterden Az Girmeyiniz!!!")]
        public string NameSurname { get; set; }



        [Required(ErrorMessage = "Lütfen Şifre Giriniz!!!")]
        [MinLength(6, ErrorMessage = "Bu Alana 6 Karakterden Az Girmeyiniz!!!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz!!!")]
        [MinLength(6, ErrorMessage = "Bu Alana 6 Karakterden Az Girmeyiniz!!!")]

        [Compare(nameof(Password))]//Eşlesiyormu iki şifre eğer eşleşmiyorsa hata ver!!!
        public string RePassword { get; set; }
    }
}
