using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace helsinki_city_bike_api.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drives",
                columns: table => new
                {
                    Departure = table.Column<string>(type: "text", nullable: false),
                    Return = table.Column<string>(type: "text", nullable: false),
                    DepartureStationId = table.Column<string>(type: "text", nullable: false),
                    DepartureStationName = table.Column<string>(type: "text", nullable: false),
                    ReturnStationId = table.Column<string>(type: "text", nullable: false),
                    ReturnStationName = table.Column<string>(type: "text", nullable: false),
                    CoveredDistance = table.Column<int>(type: "integer", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drives");
        }
    }
}
