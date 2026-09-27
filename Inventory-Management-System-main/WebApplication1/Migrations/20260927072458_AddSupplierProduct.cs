using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddSupplierProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierProduct_Products_ProductID",
                table: "SupplierProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierProduct_Suppliers_SupplierID",
                table: "SupplierProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierProduct",
                table: "SupplierProduct");

            migrationBuilder.RenameTable(
                name: "SupplierProduct",
                newName: "SupplierProducts");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierProduct_SupplierID",
                table: "SupplierProducts",
                newName: "IX_SupplierProducts_SupplierID");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierProduct_ProductID",
                table: "SupplierProducts",
                newName: "IX_SupplierProducts_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierProducts",
                table: "SupplierProducts",
                column: "SupplierProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierProducts_Products_ProductID",
                table: "SupplierProducts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierProducts_Suppliers_SupplierID",
                table: "SupplierProducts",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierProducts_Products_ProductID",
                table: "SupplierProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierProducts_Suppliers_SupplierID",
                table: "SupplierProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierProducts",
                table: "SupplierProducts");

            migrationBuilder.RenameTable(
                name: "SupplierProducts",
                newName: "SupplierProduct");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierProducts_SupplierID",
                table: "SupplierProduct",
                newName: "IX_SupplierProduct_SupplierID");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierProducts_ProductID",
                table: "SupplierProduct",
                newName: "IX_SupplierProduct_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierProduct",
                table: "SupplierProduct",
                column: "SupplierProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierProduct_Products_ProductID",
                table: "SupplierProduct",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierProduct_Suppliers_SupplierID",
                table: "SupplierProduct",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
