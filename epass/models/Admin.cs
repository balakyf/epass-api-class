using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class Admin
    {
        [Key]
        public Guid Id { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Hash {set;get;}
        public string Stamp { set; get; }
        public bool Locked { set; get; }
        public bool Enable { set; get; }
        public string Otp { set; get; }
        public string Indicatif { set; get; }
    }
}