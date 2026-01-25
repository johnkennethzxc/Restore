using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderEntityUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Item_ProductId",
                table: "OrderItem",
                newName: "ItemOrdered_ProductId");

            migrationBuilder.RenameColumn(
                name: "Item_PictureUrl",
                table: "OrderItem",
                newName: "ItemOrdered_PictureUrl");

            migrationBuilder.RenameColumn(
                name: "Item_Name",
                table: "OrderItem",
                newName: "ItemOrdered_Name");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentIntentId",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb6d65cd-252b-4ed6-8fa3-19db4f434000",
                column: "ConcurrencyStamp",
                value: "32877843-e7af-4e35-8a7a-331d96a93335");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd801f29-8bfa-42d3-8121-dda97150f288",
                column: "ConcurrencyStamp",
                value: "474a347b-2288-4842-ad17-9745e15f27da");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemOrdered_ProductId",
                table: "OrderItem",
                newName: "Item_ProductId");

            migrationBuilder.RenameColumn(
                name: "ItemOrdered_PictureUrl",
                table: "OrderItem",
                newName: "Item_PictureUrl");

            migrationBuilder.RenameColumn(
                name: "ItemOrdered_Name",
                table: "OrderItem",
                newName: "Item_Name");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentIntentId",
                table: "Orders",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb6d65cd-252b-4ed6-8fa3-19db4f434000",
                column: "ConcurrencyStamp",
                value: "bd6d5ead-7eb4-4cdb-9c6b-8b175fee9000");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd801f29-8bfa-42d3-8121-dda97150f288",
                column: "ConcurrencyStamp",
                value: "73be972f-1f55-474d-aa5b-2316b1c4a9fb");
        }
    }
}
