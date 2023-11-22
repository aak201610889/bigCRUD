using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bigCRUD.EndPoints.Migrations
{
    /// <inheritdoc />
    public partial class update_product_details_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductDetails");
        }
    }
}
