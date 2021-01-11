using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TCYDC_MVC.Migrations
{
    public partial class ApplicanMoel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullnames = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    HighestGrade = table.Column<string>(nullable: true),
                    hasQualification = table.Column<bool>(nullable: false),
                    Age = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateAccepted = table.Column<DateTime>(nullable: false),
                    ID_Document = table.Column<byte[]>(nullable: true),
                    Qualification = table.Column<byte[]>(nullable: true),
                    CV = table.Column<byte[]>(nullable: true),
                    OtherQualification = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilesDts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    DataFiles = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesDts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "FilesDts");
        }
    }
}
