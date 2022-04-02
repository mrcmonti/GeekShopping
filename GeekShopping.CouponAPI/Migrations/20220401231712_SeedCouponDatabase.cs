using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.CouponAPI.Migrations
{
    public partial class SeedCouponDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "coupon",
                columns: new[] { "id", "name", "discount_amount" },
                values: new object[] { 1L, "CUPOM22", 10m });

            migrationBuilder.InsertData(
                table: "coupon",
                columns: new[] { "id", "name", "discount_amount" },
                values: new object[] { 2L, "CUPOM_DOTNET", 15m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "coupon",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "coupon",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
