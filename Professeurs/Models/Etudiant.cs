using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class Etudiant
    {
        [Key]
        public int apogee { get; set; }
        public string massar { get; set; }
        public string email { get; set; }
        public string cin { get; set; }
        public string firstname_fr { get; set; }
        public string firstname_ar { get; set; }
        public string lastname_fr { get; set; }
        public string lastname_ar { get; set; }
        public DateTime ddn { get; set; }
        public string ldn { get; set; }
        public string natio { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string father_name { get; set; }
        public string father_job { get; set; }
        public string mother_name { get; set; }
        public string mother_job { get; set; }
        public string parents_phone { get; set; }
        public string annee { get; set; }
        public int id_filiere { get; set; } 
        public Filiere filiere { get; set; }
        public string type_bac { get; set; }
        public string mention_bac { get; set; }
        public string annee_bac { get; set; }
        public string lycee { get; set; }
        public string delegation { get; set; }
        public string academie { get; set; }
        public string diplome { get; set; }
        public string ecole { get; set; }
        public string ville_diplome { get; set; }
        public string picture { get; set; }
        public int validated { get; set; }
        public int code_promo { get; set; }
        public string password { get; set; }
        public string sexe { get; set; }

       
    }
}
