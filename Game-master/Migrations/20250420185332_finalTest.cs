using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwitchPlayD.Migrations
{
    /// <inheritdoc />
    public partial class finalTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43d12e98-2673-40d2-874c-2dc9c0a54018", "AQAAAAIAAYagAAAAEG2F86URB7jZ8R6gTlGVtWgcbRzpl/WudNIYQiIIPte2++Ew0apJ0nqF+xrL7HDJAw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ec464ea-75ef-4053-af32-07b19b8591c4", "AQAAAAIAAYagAAAAEDevsX3tgPf/quKviFMEjaAXiR5l8ADG4XENOfwqfFHRHtyINzLc/nVvondtnbVkzQ==" });
        }
    }
}
