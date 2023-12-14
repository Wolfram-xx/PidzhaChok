using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PidzhaWEB.Migrations
{
    public partial class InicialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTypes", x => x.ID);
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
                name: "Disciplines",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExamTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Disciplines_ExamTypes_ExamTypeID",
                        column: x => x.ExamTypeID,
                        principalTable: "ExamTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Disciplines_Teachers_TeacherName",
                        column: x => x.TeacherName,
                        principalTable: "Teachers",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_ExamTypeID",
                table: "Disciplines",
                column: "ExamTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_TeacherName",
                table: "Disciplines",
                column: "TeacherName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "ExamTypes");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
