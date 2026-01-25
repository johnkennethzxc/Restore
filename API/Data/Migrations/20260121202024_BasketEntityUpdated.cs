using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class BasketEntityUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "Baskets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentIntentId",
                table: "Baskets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb6d65cd-252b-4ed6-8fa3-19db4f434000",
                column: "ConcurrencyStamp",
                value: "bc261890-1de6-4bc9-9ae7-43c56c54c8fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd801f29-8bfa-42d3-8121-dda97150f288",
                column: "ConcurrencyStamp",
                value: "15a76742-9d5b-463a-86cd-282a63d6df79");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "PaymentIntentId",
                table: "Baskets");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb6d65cd-252b-4ed6-8fa3-19db4f434000",
                column: "ConcurrencyStamp",
                value: "83569b52-7f9d-4b22-afcd-36e2a80a39bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd801f29-8bfa-42d3-8121-dda97150f288",
                column: "ConcurrencyStamp",
                value: "bc1a0604-a2ac-4bb9-859d-aaaa77ff0860");
        }
    }
}
