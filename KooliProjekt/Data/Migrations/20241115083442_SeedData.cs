using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "Oraganizer",
                table: "Event",
                newName: "Organizer");

            migrationBuilder.RenameColumn(
                name: "Desscription",
                table: "Event",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Organizer",
                table: "Event",
                newName: "Oraganizer");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Event",
                newName: "Desscription");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "Event",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
