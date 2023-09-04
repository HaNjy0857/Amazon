using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amazon.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addSessionIdToHeader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "\\images\\product\\f64c40f6-9576-4868-b8b7-a490d45d8f97.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "OrderHeaders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "\\images\\product\\c5c27ada-4049-473c-a2af-83ab87c4fe5f.jpg");
        }
    }
}
