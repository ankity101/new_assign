using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<int>(type: "int", nullable: false),
                    MfgDate = table.Column<DateTime>(type: "date", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "MfgDate", "ProductCategory", "ProductName", "ProductPrice", "ProductSize" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 2, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9019), "Standard", "Large", 100, "Large" },
                    { 2, new DateTime(2023, 11, 1, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9059), "Premium", "Medium", 500, "Medium" },
                    { 3, new DateTime(2023, 10, 31, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9062), "Economy", "Small", 275, "Small" },
                    { 4, new DateTime(2023, 10, 30, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9065), "Standard", "Large", 100, "Large" },
                    { 5, new DateTime(2023, 10, 29, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9067), "Premium", "Medium", 500, "Medium" },
                    { 6, new DateTime(2023, 10, 28, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9071), "Economy", "Small", 275, "Small" },
                    { 7, new DateTime(2023, 10, 27, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9073), "Standard", "Large", 100, "Large" },
                    { 8, new DateTime(2023, 10, 26, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9075), "Premium", "Medium", 500, "Medium" },
                    { 9, new DateTime(2023, 10, 25, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9077), "Economy", "Small", 275, "Small" },
                    { 10, new DateTime(2023, 10, 24, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9081), "Standard", "Large", 100, "Large" },
                    { 11, new DateTime(2023, 10, 23, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9083), "Premium", "Medium", 500, "Medium" },
                    { 12, new DateTime(2023, 10, 22, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9085), "Economy", "Small", 275, "Small" },
                    { 13, new DateTime(2023, 10, 21, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9087), "Standard", "Large", 100, "Large" },
                    { 14, new DateTime(2023, 10, 20, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9089), "Premium", "Medium", 500, "Medium" },
                    { 15, new DateTime(2023, 10, 19, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9091), "Economy", "Small", 275, "Small" },
                    { 16, new DateTime(2023, 10, 18, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9093), "Standard", "Large", 100, "Large" },
                    { 17, new DateTime(2023, 10, 17, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9095), "Premium", "Medium", 500, "Medium" },
                    { 18, new DateTime(2023, 10, 16, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9099), "Economy", "Small", 275, "Small" },
                    { 19, new DateTime(2023, 10, 15, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9101), "Standard", "Large", 100, "Large" },
                    { 20, new DateTime(2023, 10, 14, 20, 16, 28, 878, DateTimeKind.Local).AddTicks(9103), "Premium", "Medium", 500, "Medium" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
