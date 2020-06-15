using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EndangeredAnimalsAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaxonId = table.Column<int>(nullable: false),
                    SciName = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    CommonName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Population_Trend = table.Column<string>(nullable: true),
                    Population = table.Column<string>(nullable: true),
                    GeographicRange = table.Column<string>(nullable: true),
                    Habitat = table.Column<string>(nullable: true),
                    Threats = table.Column<string>(nullable: true),
                    Conservation = table.Column<string>(nullable: true),
                    Countries = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
