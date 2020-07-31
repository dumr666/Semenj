using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SemenjAPI.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Homesteads",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PostCode = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    WebPageAddress = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homesteads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsSorts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSorts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsSorts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PostCode = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<float>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    HomesteadId = table.Column<Guid>(nullable: false),
                    HomesteadId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Homesteads_HomesteadId",
                        column: x => x.HomesteadId,
                        principalTable: "Homesteads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Homesteads_HomesteadId1",
                        column: x => x.HomesteadId1,
                        principalTable: "Homesteads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SellerId = table.Column<Guid>(nullable: true),
                    HomesteadId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProductSortId = table.Column<Guid>(nullable: true),
                    CultivationMethod = table.Column<string>(nullable: true),
                    Quantity = table.Column<float>(nullable: false),
                    Rating = table.Column<float>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    PriceFormat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Homesteads_HomesteadId",
                        column: x => x.HomesteadId,
                        principalTable: "Homesteads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductsSorts_ProductSortId",
                        column: x => x.ProductSortId,
                        principalTable: "ProductsSorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Users_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_HomesteadId",
                table: "Products",
                column: "HomesteadId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSortId",
                table: "Products",
                column: "ProductSortId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SellerId",
                table: "Products",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSorts_CategoryId",
                table: "ProductsSorts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_HomesteadId",
                table: "Users",
                column: "HomesteadId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_HomesteadId1",
                table: "Users",
                column: "HomesteadId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductsSorts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Homesteads");
        }
    }
}
