using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeFinder.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QueryFields",
                columns: table => new
                {
                    QueryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Geo_lat_from = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geo_lat_to = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geo_lng_from = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geo_lng_to = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinPrice = table.Column<int>(type: "int", nullable: false),
                    MaxPrice = table.Column<int>(type: "int", nullable: false),
                    MinLevel = table.Column<int>(type: "int", nullable: false),
                    MaxLevel = table.Column<int>(type: "int", nullable: false),
                    MinSize = table.Column<int>(type: "int", nullable: false),
                    MaxSize = table.Column<int>(type: "int", nullable: false),
                    MinBedrooms = table.Column<int>(type: "int", nullable: false),
                    MaxBedrooms = table.Column<int>(type: "int", nullable: false),
                    MinConstruction_year = table.Column<int>(type: "int", nullable: false),
                    MaxConstruction_year = table.Column<int>(type: "int", nullable: false),
                    MinPricePerUnitArea = table.Column<int>(type: "int", nullable: false),
                    MaxPricePerUnitArea = table.Column<int>(type: "int", nullable: false),
                    MinEnergyClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxEnergyClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryFields", x => x.QueryId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QueryFields");
        }
    }
}
