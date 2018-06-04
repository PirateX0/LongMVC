using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LongMVC.lib;

namespace LongMVC.Models
{
    public class Person
    {
        [Required(ErrorMessage = "{0}请输入用户名")]
        [StringLength(5)]
        public string Name { get; set; }
       
        [Range(5,100)]
        public int Age { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        [Compare("Password")]
        public string Password2 { get; set; }
        [EmailAddress]
        [StringLength(5)]
        [Required(ErrorMessage = "{0}请输入用户邮箱")]
        public string Email { get; set; }
        [QQNumber]
        public string QQ { get; set; }
        [CNPhoneNum]
        public string Phone { get; set; }
    }
}