using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwitchPlayD.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ec464ea-75ef-4053-af32-07b19b8591c4", "AQAAAAIAAYagAAAAEDevsX3tgPf/quKviFMEjaAXiR5l8ADG4XENOfwqfFHRHtyINzLc/nVvondtnbVkzQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59fffee0-4528-4605-9935-c770559e028d", "AQAAAAIAAYagAAAAEPNIx9nbOK5noj09VRC5BF+g6iq8mc8G2ojcia/FJ8vNepoo5mpGulUoGoe8esWYOw==" });
        }
    }
}
