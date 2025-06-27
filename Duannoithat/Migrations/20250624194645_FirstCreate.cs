using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duannoithat.Migrations
{
    /// <inheritdoc />
    public partial class FirstCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsTrendingProduct = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Phong cách hiện đại phù hợp với nhiều không gian nội thất", "https://shopdogothachthat.com/pic/Bo-ban-an-6-ghe-go-soi%20(2).jpg", true, "Bàn Ghế", 2500m },
                    { 2, "Ngồi là êm ngủ là ngon", "https://noithatdangkhoa.com/wp-content/uploads/2024/06/ghe-sofa-vang-da-phong-khach-sfdk124.jpg", true, "Ghế Sofa", 2000m },
                    { 3, "Cao su tự nhiên", "https://nemhana.com/wp-content/uploads/2023/10/dem-thang-loi-cao-su-non-cao-cap.jpg", true, "Giường", 1500m },
                    { 4, "Tủ đồ phong cách hiện đại", "https://product.hstatic.net/1000075734/product/tu-quan-ao-canh-lua-cho-phong-ngu-hien-dai-2-1_546ad20e7ef54efa955fc6c5ed4af619_grande.jpg", true, "Tủ đồ", 1500m },
                    { 5, "kệ sách cổ điển", "https://api.togihome.vn/storage/images/originals/ke-sach-go-tu-nhien-thiet-ke-nhieu-ngan-sd47-1-idbeaaw8w4zkkyz.webp", true, "Kệ sách", 2500m },
                    { 6, "Giường gỗ", "https://dogomanhhung.com/uploads/images/634fc215dfc29f68d57258e0/z3812119525960_9d3fba21753fc64d873dc2fa3fbcece6.jpg", true, "Giường", 3500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
