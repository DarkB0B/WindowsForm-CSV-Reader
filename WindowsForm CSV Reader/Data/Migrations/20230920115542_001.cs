using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindowsForm_CSV_Reader.Data.Migrations
{
    /// <inheritdoc />
    public partial class _001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Main_Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pictures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_KARTOTEKI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAZWA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRODUCENT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STAN_NA_MAGAZYNIE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WAGA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JEDNOSTKA_MIARY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OPIS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MIN_ZAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KOD_PRODUCENTA = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
