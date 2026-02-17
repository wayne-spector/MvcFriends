using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcFriends.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Email", "Mobile", "Name" },
                values: new object[,]
                {
                    { 1, "mary@gmail.com", "0912312312", "Mary" },
                    { 2, "david@gmail.com", "0945456456", "David" },
                    { 3, "jacob@gmail.com", "0978789789", "Jacob" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
