using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OfferManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 13, 0, 0, 0, DateTimeKind.Local), "Supplier A" },
                    { 2, new DateTime(2023, 2, 1, 13, 0, 0, 0, DateTimeKind.Local), "Supplier B" },
                    { 3, new DateTime(2023, 3, 1, 13, 0, 0, 0, DateTimeKind.Local), "Supplier C" },
                    { 4, new DateTime(2023, 4, 1, 13, 0, 0, 0, DateTimeKind.Local), "Supplier D" },
                    { 5, new DateTime(2023, 5, 1, 13, 0, 0, 0, DateTimeKind.Local), "Supplier E" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Brand", "Model", "RegisteredAt", "SupplierId" },
                values: new object[,]
                {
                    { 1, "Samsung", "Galaxy S21", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 2, "Apple", "iPhone 13", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 3, "Xiaomi", "Mi 11", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 4, "OnePlus", "9 Pro", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 5, "Google", "Pixel 6", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 6, "Sony", "Xperia 1", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 7, "Huawei", "P50", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 8, "Motorola", "Edge", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 9, "Nokia", "8.3", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 10, "Realme", "GT", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 11, "Asus", "ROG Phone 5", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 12, "ZTE", "Axon 30", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 13, "LG", "Wing", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 14, "Vivo", "X60", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 15, "Oppo", "Find X3", new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_SupplierId",
                table: "Offers",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
