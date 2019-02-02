using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nesti.Migrations
{
    public partial class AdditionalTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GenericProductId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Measurement",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weeks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weeks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenericProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MeasurementId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericProducts_Measurement_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "Measurement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PreparationTime = table.Column<int>(nullable: false),
                    Instructions = table.Column<string>(nullable: true),
                    WeekId = table.Column<Guid>(nullable: true),
                    WeekId1 = table.Column<Guid>(nullable: true),
                    WeekId2 = table.Column<Guid>(nullable: true),
                    WeekId3 = table.Column<Guid>(nullable: true),
                    WeekId4 = table.Column<Guid>(nullable: true),
                    WeekId5 = table.Column<Guid>(nullable: true),
                    WeekId6 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_Weeks_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Weeks_WeekId1",
                        column: x => x.WeekId1,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Weeks_WeekId2",
                        column: x => x.WeekId2,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Weeks_WeekId3",
                        column: x => x.WeekId3,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Weeks_WeekId4",
                        column: x => x.WeekId4,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Weeks_WeekId5",
                        column: x => x.WeekId5,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meals_Weeks_WeekId6",
                        column: x => x.WeekId6,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GenericProductId = table.Column<Guid>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    MealId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_GenericProducts_GenericProductId",
                        column: x => x.GenericProductId,
                        principalTable: "GenericProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ingredients_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenericProductId",
                table: "Products",
                column: "GenericProductId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericProducts_MeasurementId",
                table: "GenericProducts",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_GenericProductId",
                table: "Ingredients",
                column: "GenericProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MealId",
                table: "Ingredients",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_WeekId",
                table: "Meals",
                column: "WeekId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_WeekId1",
                table: "Meals",
                column: "WeekId1");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_WeekId2",
                table: "Meals",
                column: "WeekId2");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_WeekId3",
                table: "Meals",
                column: "WeekId3");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_WeekId4",
                table: "Meals",
                column: "WeekId4");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_WeekId5",
                table: "Meals",
                column: "WeekId5");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_WeekId6",
                table: "Meals",
                column: "WeekId6");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_GenericProducts_GenericProductId",
                table: "Products",
                column: "GenericProductId",
                principalTable: "GenericProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_GenericProducts_GenericProductId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "GenericProducts");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Measurement");

            migrationBuilder.DropTable(
                name: "Weeks");

            migrationBuilder.DropIndex(
                name: "IX_Products_GenericProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GenericProductId",
                table: "Products");
        }
    }
}
