using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormSubmission.Migrations
{
    /// <inheritdoc />
    public partial class migrate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isUpdateneeded",
                table: "students",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isUpdateneeded",
                table: "students");
        }
    }
}
