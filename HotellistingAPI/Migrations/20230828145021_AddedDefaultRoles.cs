using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotellistingAPI.Migrations
{
    public partial class AddedDefaultRoles : Migration 
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63461b41-625a-40a6-90c2-78d1afde657f", "d21bf3d5-d941-41ad-915f-1a480352d726", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "788ff4e4-14ff-424a-8730-18955b26b6ac", "2f727584-f8c8-43bb-8f38-62f06aa1776e", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63461b41-625a-40a6-90c2-78d1afde657f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "788ff4e4-14ff-424a-8730-18955b26b6ac");
        }
    }
}
