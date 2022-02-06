using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalCore.DAL.Migrations
{
    public partial class Candidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_candidateRegister",
                table: "candidateRegister");

            migrationBuilder.AlterColumn<string>(
                name: "EmailId",
                table: "candidateRegister",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Candidate_Id",
                table: "candidateRegister",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_candidateRegister",
                table: "candidateRegister",
                column: "Candidate_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_candidateRegister",
                table: "candidateRegister");

            migrationBuilder.DropColumn(
                name: "Candidate_Id",
                table: "candidateRegister");

            migrationBuilder.AlterColumn<string>(
                name: "EmailId",
                table: "candidateRegister",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_candidateRegister",
                table: "candidateRegister",
                column: "EmailId");
        }
    }
}
