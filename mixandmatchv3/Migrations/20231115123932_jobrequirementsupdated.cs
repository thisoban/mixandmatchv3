using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mixandmatchv3.Migrations
{
    /// <inheritdoc />
    public partial class jobrequirementsupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "jobrequirements");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "jobrequirements",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "jobrequirements",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "jobrequirements",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "jobrequirements",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "jobrequirements",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "jobrequirements",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldMaxLength: 60)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "jobrequirements",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
