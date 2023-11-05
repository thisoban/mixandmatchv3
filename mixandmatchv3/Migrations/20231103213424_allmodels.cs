using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mixandmatchv3.Migrations
{
    /// <inheritdoc />
    public partial class allmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Company_companyidID",
                table: "Jobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "companies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_companies",
                table: "companies",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "hiring_Managers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phonenumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    companyidID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hiring_Managers", x => x.id);
                    table.ForeignKey(
                        name: "FK_hiring_Managers_companies_companyidID",
                        column: x => x.companyidID,
                        principalTable: "companies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "jobrequirements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobIdid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobrequirements", x => x.id);
                    table.ForeignKey(
                        name: "FK_jobrequirements_Jobs_jobIdid",
                        column: x => x.jobIdid,
                        principalTable: "Jobs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_hiring_Managers_companyidID",
                table: "hiring_Managers",
                column: "companyidID");

            migrationBuilder.CreateIndex(
                name: "IX_jobrequirements_jobIdid",
                table: "jobrequirements",
                column: "jobIdid");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_companies_companyidID",
                table: "Jobs",
                column: "companyidID",
                principalTable: "companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_companies_companyidID",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "hiring_Managers");

            migrationBuilder.DropTable(
                name: "jobrequirements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_companies",
                table: "companies");

            migrationBuilder.RenameTable(
                name: "companies",
                newName: "Company");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Company_companyidID",
                table: "Jobs",
                column: "companyidID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
