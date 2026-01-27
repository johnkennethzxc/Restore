using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class PublicIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Orders_Orderid",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Orderid",
                table: "OrderItem",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_Orderid",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderId");

            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb6d65cd-252b-4ed6-8fa3-19db4f434000",
                column: "ConcurrencyStamp",
                value: "d3aa8203-1279-4780-b404-a99de3994093");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd801f29-8bfa-42d3-8121-dda97150f288",
                column: "ConcurrencyStamp",
                value: "05034506-2b5d-4148-8d08-08cf2dc3d6d1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Orders_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Orders_OrderId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItem",
                newName: "Orderid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_Orderid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Orders_Orderid",
                table: "OrderItem",
                column: "Orderid",
                principalTable: "Orders",
                principalColumn: "id");
        }
    }
}
