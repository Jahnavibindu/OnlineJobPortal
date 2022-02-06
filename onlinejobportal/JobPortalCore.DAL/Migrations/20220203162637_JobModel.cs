using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalCore.DAL.Migrations
{
    public partial class JobModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    jobid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jobtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    joblocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    technicalskills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    companyname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactid = table.Column<int>(type: "int", nullable: false),
                    contactperson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactnumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.jobid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jobs");
        }
    }
}
