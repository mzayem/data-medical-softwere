using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data_medical_softwere.Migrations
{
    /// <inheritdoc />
    public partial class AddVendorToGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_VendorId",
                table: "Groups",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Vendors_VendorId",
                table: "Groups",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Vendors_VendorId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_VendorId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Groups");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
