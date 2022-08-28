using Microsoft.EntityFrameworkCore.Migrations;

namespace Compro_Intern.Migrations
{
    public partial class Simp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Desgs",
                columns: table => new
                {
                    DesgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesgRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desgs", x => x.DesgId);
                });

            migrationBuilder.CreateTable(
                name: "Hrs",
                columns: table => new
                {
                    HId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CHr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IHr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hrs", x => x.HId);
                });

            migrationBuilder.CreateTable(
                name: "Ls",
                columns: table => new
                {
                    LId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LReason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ls", x => x.LId);
                });

            migrationBuilder.CreateTable(
                name: "Recs",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecPhn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recs", x => x.RecId);
                });

            migrationBuilder.CreateTable(
                name: "Regs",
                columns: table => new
                {
                    RegIntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntPas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntNu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntAddr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs", x => x.RegIntId);
                });

            migrationBuilder.CreateTable(
                name: "Sts",
                columns: table => new
                {
                    SId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sts", x => x.SId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desgs");

            migrationBuilder.DropTable(
                name: "Hrs");

            migrationBuilder.DropTable(
                name: "Ls");

            migrationBuilder.DropTable(
                name: "Recs");

            migrationBuilder.DropTable(
                name: "Regs");

            migrationBuilder.DropTable(
                name: "Sts");
        }
    }
}
