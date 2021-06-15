using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(maxLength: 50, nullable: false),
                    CategoryName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<string>(maxLength: 50, nullable: false),
                    ItemName = table.Column<string>(maxLength: 20, nullable: false),
                    ItemDescription = table.Column<string>(maxLength: 200, nullable: false),
                    TotalQuantity = table.Column<int>(nullable: false),
                    CategoryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    StorageId = table.Column<string>(maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    PartialQuantity = table.Column<int>(nullable: false),
                    ItemId = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.StorageId);
                    table.ForeignKey(
                        name: "FK_Storages_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InOuts",
                columns: table => new
                {
                    InOutId = table.Column<string>(maxLength: 50, nullable: false),
                    InOutDate = table.Column<DateTime>(nullable: false),
                    AmountMoved = table.Column<int>(nullable: false),
                    IsInput = table.Column<bool>(nullable: false),
                    StorageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOuts", x => x.InOutId);
                    table.ForeignKey(
                        name: "FK_InOuts_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "StorageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<string>(maxLength: 50, nullable: false),
                    WarehouseName = table.Column<string>(maxLength: 100, nullable: false),
                    WarehouseAddress = table.Column<string>(maxLength: 200, nullable: false),
                    StorageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseId);
                    table.ForeignKey(
                        name: "FK_Warehouses_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "StorageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InOuts_StorageId",
                table: "InOuts",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_ItemId",
                table: "Storages",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_StorageId",
                table: "Warehouses",
                column: "StorageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InOuts");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
