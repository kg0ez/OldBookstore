using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookstore.Migrations
{
    public partial class AddTableBasket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name", "Patronymic", "Phone", "Surname" },
                values: new object[] { 3, "Anat", "Anat", "+23423425", "Bob" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name", "Patronymic", "Phone", "Surname" },
                values: new object[] { 4, "Kol", "Anat", "+37529928292", "Pah" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name", "Patronymic", "Phone", "Surname" },
                values: new object[] { 5, "Gen", "Anat", "+375333423425", "Fok" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
