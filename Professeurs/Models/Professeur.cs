using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class Professeur
    {
        [Key]
        public string prof_id { get; set; }
        public string nom { get; set; }
        public string prenom {get;set;}
        public string email { get; set; }
    }
}
