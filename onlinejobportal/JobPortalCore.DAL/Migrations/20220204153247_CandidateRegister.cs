using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalCore.DAL.Migrations
{
    public partial class CandidateRegister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.CreateTable(
                name: "candidateRegister",
                columns: table => new
                {
                    EmailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobNumber = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidateRegister", x => x.EmailId);
                });

            migrationBuilder.CreateTable(
                name: "job",
                columns: table => new
                {
                    Jobid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jobtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Joblocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technicalskills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Companyname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contactperson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contactnumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job", x => x.Jobid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidateRegister");

            migrationBuilder.DropTable(
                name: "job");

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    jobid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactid = table.Column<int>(type: "int", nullable: false),
                    contactnumber = table.Column<int>(type: "int", nullable: false),
                    contactperson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    joblocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    technicalskills = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.jobid);
                });
        }
    }
}
