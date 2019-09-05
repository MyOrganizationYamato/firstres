using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace firstres
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Displayname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Muie { get; set; }
    }
}
