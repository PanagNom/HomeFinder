using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HomeFinder.Migrations
{
    /// <inheritdoc />
    public partial class FirstPostgreSQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QueryFields",
                columns: table => new
                {
                    QueryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Geo_lat_from = table.Column<string>(type: "text", nullable: false),
                    Geo_lat_to = table.Column<string>(type: "text", nullable: false),
                    Geo_lng_from = table.Column<string>(type: "text", nullable: false),
                    Geo_lng_to = table.Column<string>(type: "text", nullable: false),
                    MinPrice = table.Column<int>(type: "integer", nullable: false),
                    MaxPrice = table.Column<int>(type: "integer", nullable: false),
                    MinLevel = table.Column<int>(type: "integer", nullable: false),
                    MaxLevel = table.Column<int>(type: "integer", nullable: false),
                    MinSize = table.Column<int>(type: "integer", nullable: false),
                    MaxSize = table.Column<int>(type: "integer", nullable: false),
                    MinBedrooms = table.Column<int>(type: "integer", nullable: false),
                    MaxBedrooms = table.Column<int>(type: "integer", nullable: false),
                    MinBathrooms = table.Column<int>(type: "integer", nullable: false),
                    MaxBathrooms = table.Column<int>(type: "integer", nullable: false),
                    MinConstruction_year = table.Column<int>(type: "integer", nullable: false),
                    MaxConstruction_year = table.Column<int>(type: "integer", nullable: false),
                    MinPricePerUnitArea = table.Column<int>(type: "integer", nullable: false),
                    MaxPricePerUnitArea = table.Column<int>(type: "integer", nullable: false),
                    MinEnergyClass = table.Column<string>(type: "text", nullable: false),
                    MaxEnergyClass = table.Column<string>(type: "text", nullable: false),
                    Availability = table.Column<string[]>(type: "text[]", nullable: true)
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
