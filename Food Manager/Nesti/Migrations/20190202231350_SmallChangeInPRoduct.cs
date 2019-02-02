using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nesti.Migrations
{
    public partial class SmallChangeInPRoduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Meals_MealId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_MealId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "Ingredients");

            migrationBuilder.AddColumn<Guid>(
                name: "MealId",
                table: "GenericProducts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenericProducts_MealId",
                table: "GenericProducts",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProducts_Meals_MealId",
                table: "GenericProducts",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenericProducts_Meals_MealId",
                table: "GenericProducts");

            migrationBuilder.DropIndex(
                name: "IX_GenericProducts_MealId",
                table: "GenericProducts");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "GenericProducts");

            migrationBuilder.AddColumn<Guid>(
                name: "MealId",
                table: "Ingredients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MealId",
                table: "Ingredients",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Meals_MealId",
                table: "Ingredients",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
