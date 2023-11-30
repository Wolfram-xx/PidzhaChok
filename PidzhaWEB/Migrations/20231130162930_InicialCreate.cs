using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PidzhaWEB.Migrations
{
    public partial class InicialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationalInstitutions",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalInstitutions", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "EducationalPrograms",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationalInstitutionName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalPrograms", x => x.Name);
                    table.ForeignKey(
                        name: "FK_EducationalPrograms_EducationalInstitutions_EducationalInstitutionName",
                        column: x => x.EducationalInstitutionName,
                        principalTable: "EducationalInstitutions",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "EducationalPlans",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    EndYear = table.Column<int>(type: "int", nullable: false),
                    EducationalProgramName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EducationalInstitutionName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalPlans", x => x.Name);
                    table.ForeignKey(
                        name: "FK_EducationalPlans_EducationalInstitutions_EducationalInstitutionName",
                        column: x => x.EducationalInstitutionName,
                        principalTable: "EducationalInstitutions",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_EducationalPlans_EducationalPrograms_EducationalProgramName",
                        column: x => x.EducationalProgramName,
                        principalTable: "EducationalPrograms",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicHours = table.Column<int>(type: "int", nullable: false),
                    Prerequisites = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EducationalPlanName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Disciplines_EducationalPlans_EducationalPlanName",
                        column: x => x.EducationalPlanName,
                        principalTable: "EducationalPlans",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplines_Teachers_TeacherName",
                        column: x => x.TeacherName,
                        principalTable: "Teachers",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EducationalPlanName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Students_EducationalPlans_EducationalPlanName",
                        column: x => x.EducationalPlanName,
                        principalTable: "EducationalPlans",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_EducationalPlanName",
                table: "Disciplines",
                column: "EducationalPlanName");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_TeacherName",
                table: "Disciplines",
                column: "TeacherName");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalPlans_EducationalInstitutionName",
                table: "EducationalPlans",
                column: "EducationalInstitutionName");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalPlans_EducationalProgramName",
                table: "EducationalPlans",
                column: "EducationalProgramName");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalPrograms_EducationalInstitutionName",
                table: "EducationalPrograms",
                column: "EducationalInstitutionName");

            migrationBuilder.CreateIndex(
                name: "IX_Students_EducationalPlanName",
                table: "Students",
                column: "EducationalPlanName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "EducationalPlans");

            migrationBuilder.DropTable(
                name: "EducationalPrograms");

            migrationBuilder.DropTable(
                name: "EducationalInstitutions");
        }
    }
}
