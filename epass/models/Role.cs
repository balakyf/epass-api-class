using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class Role
    {
        [Key]
        public Guid Id { set; get; }
        public string Libelle { set; get; }
    }
}