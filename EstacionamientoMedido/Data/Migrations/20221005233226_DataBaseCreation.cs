using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacionamientoMedido.Data.Migrations
{
    public partial class DataBaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClientDocumentNumber = table.Column<string>(maxLength: 8, nullable: false),
                    ClientName = table.Column<string>(nullable: false),
                    Patent = table.Column<string>(nullable: false),
                    VehicleModel = table.Column<string>(nullable: true),
                    VehicleBrand = table.Column<string>(nullable: false),
                    CheckIn = table.Column<TimeSpan>(nullable: false),
                    CheckOut = table.Column<TimeSpan>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    StreetHeight = table.Column<string>(nullable: true),
                    ClientEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
