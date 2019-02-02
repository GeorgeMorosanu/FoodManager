using Microsoft.EntityFrameworkCore.Migrations;

namespace Nesti.Migrations
{
    public partial class AddMeasurements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenericProducts_Measurement_MeasurementId",
                table: "GenericProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measurement",
                table: "Measurement");

            migrationBuilder.RenameTable(
                name: "Measurement",
                newName: "Measurements");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProducts_Measurements_MeasurementId",
                table: "GenericProducts",
                column: "MeasurementId",
                principalTable: "Measurements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenericProducts_Measurements_MeasurementId",
                table: "GenericProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements");

            migrationBuilder.RenameTable(
                name: "Measurements",
                newName: "Measurement");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measurement",
                table: "Measurement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericProducts_Measurement_MeasurementId",
                table: "GenericProducts",
                column: "MeasurementId",
                principalTable: "Measurement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
