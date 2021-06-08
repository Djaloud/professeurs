using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class myDataContext : DbContext
    {
        public myDataContext(DbContextOptions option):base(option)
        {
        }
        DbSet<Etudiant> etudiants { get; set; }
        DbSet<Filiere> filieres { get; set; }
        DbSet<Module> modules { get; set; }
        DbSet<Professeur> professeurs { get; set; }

    }
}
