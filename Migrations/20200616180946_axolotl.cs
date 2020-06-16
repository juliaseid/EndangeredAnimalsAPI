using Microsoft.EntityFrameworkCore.Migrations;

namespace EndangeredAnimalsAPI.Migrations
{
    public partial class axolotl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "Countries",
                value: "MX, US");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Category", "CommonName", "Conservation", "Countries", "GeographicRange", "Habitat", "ImageURL", "Population", "Population_Trend", "SciName", "Summary", "TaxonId", "Threats" },
                values: new object[] { 2, "CR", "axolotl", "Conservation action is focusing on raising the profile of Lake Xochimilco through conservation education and a nature tourism initiative, coupled with work on habitat restoration and bioremediation. A species action plan has been drafted. There are several captive colonies around the world, since the species is used in physiological and biomedical research, as well as in the pet trade, but the re-introduction of captive-bred axolotls is not recommended until threats can be mitigated, and disease and genetic risks to the wild populations assessed. This species is protected under the category Pr (Special protection) by the Government of Mexico and is in process of being amended to a higher risk category. Although this species is currently on CITES Appendix II, it is currently under the process of \"Periodic Review of species included in CITES Appendices\".", "MX", "This species is known only from central Mexico, on the southern edge of Mexico City, in canals and wetlands in the general vicinity of Xochimilco (including outside the Xochimilco city limits, around the Chalco wetland). The animals are not homogeneously distributed through their range, and congregate in particular places. Records from close to downtown Mexico City in the Chapultepec Lake could refer to either this species or <em>Ambystoma velasci</em>, and require confirmation. It was originally found in Lakes Xochimilco and Chalco (and presumably in the connecting lakes Texcoco and Zumpango), but it has disappeared from most of its range.", "This species is native to the ancient system of water channels and lakes in Mexico City. It requires deep-water lakes (both natural and artificial canals) with abundant aquatic vegetation. Structures such as plants are needed to lay eggs. It is a paedomorphic species, living permanently in water, and does not undergo complete metamorphosis.", null, "The surviving wild population is very small. Although populations are difficult to assess, recent surveys covering almost all of its known distribution range have usually captured fewer than 100 individuals (e.g., during 2002 and 2003, more than 1,800 net casts were made along Xochimilco canals covering 39,173m² and this resulted in a catch of only 42 specimens). In a study covering a span of six years (from 1998 to 2004), axolotl density had reduced from 0.006-org/ m2 to 0.001-org/ m2, although it is thought that this reduction could also be due to its own population dynamics (Zambrano 2006). A recent scientific survey revealed no axolotls, although wild-caught animals are still found in the local market, which indicates that fishermen still know where to find them. There has not been a density study of the Chalco population, but evidence suggests that the population there is small and, furthermore, Chalco is a highly unstable system that runs the risk of disappearing in the near future.", "decreasing", "Ambystoma mexicanum", "Listed as Critically Endangered because its Area of Occupancy is less than 10km2, its distribution is severely fragmented, and there is a continuing decline in the extent and quality of its habitat and in the number of mature individuals.", 1095, "The desiccation and pollution of the canal system and lakes in Xochimilco and Chalco, as a result of urbanization, as well as the traditional consumption of the species by local people, is threatening the survival of this species. Increased tourist activity is poorly regulated and adds further pollution (Zambrano, 2006). The species is also captured for medicinal purposes. The harvesting is targeted at animals that are less than one year old. It was formerly also captured for the international pet trade, although probably all animals in the international trade are now of captive origin. Introduced fishes (tilapia and carp) have increased to high abundances (a recent study collected 600kg of tilapia in one small channel using a 100m net) and have also impacted axolotls through competition and predation. The animals are also being affected by disease, probably spread by invasive species, and as a result of poor water quality. Although the water regime has changed in the last 10 years, and it is reported that pollution levels are decreasing, factors such as very high levels of bacterial contamination could still pose a serious threat." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "Countries",
                value: null);
        }
    }
}
