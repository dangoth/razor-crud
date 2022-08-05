using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonDB.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { 1, 32, "peter.johns@gmail.com", "Peter", 0, "Johns", "00312642236" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { 2, 28, "joe23@gmail.com", "Joe", 0, "Walsh", "0048125629349" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { 3, 44, "Presidentpressoffice@apu.gov.ua", "Volodymyr", 0, "Zelensky", "00380442841915" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
