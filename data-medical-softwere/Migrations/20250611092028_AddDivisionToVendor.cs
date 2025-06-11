using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data_medical_softwere.Migrations
{
    /// <inheritdoc />
    public partial class AddDivisionToVendor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DivisionId",
                table: "Vendors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_DivisionId",
                table: "Vendors",
                column: "DivisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_Divisions_DivisionId",
                table: "Vendors",
                column: "DivisionId",
                principalTable: "Divisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_Divisions_DivisionId",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_DivisionId",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "DivisionId",
                table: "Vendors");
        }
    }
}