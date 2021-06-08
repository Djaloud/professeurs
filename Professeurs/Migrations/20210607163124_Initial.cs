 using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Professeurs.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "etudiants",
                columns: table => new
                {
                    apogee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    massar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname_fr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname_ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname_fr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname_ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ddn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ldn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    natio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    father_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    father_job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mother_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mother_job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parents_phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    annee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filiere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type_bac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mention_bac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    annee_bac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lycee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delegation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    academie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diplome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ecole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ville_diplome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    validated = table.Column<int>(type: "int", nullable: false),
                    code_promo = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etudiants", x => x.apogee);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "etudiants");
        }
    }
}
