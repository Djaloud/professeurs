using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class Module
    {
        [Key]
        public int id_module { get; set; }
        public string nom_module { get; set; }
        [ForeignKey("Professeur")]
        public Professeur responsable { get; set; }
        public int id_filiere { get; set; }
        public Filiere filiere { get; set; }

    }
}
