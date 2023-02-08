using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunningApp.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "Id", "Age", "Firstname", "Lastname", "TotalTime" },
                values: new object[] { 2, 38, "Pappa Wozze", "Löhr", "13:40" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Time",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
