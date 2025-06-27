using Duannoithat.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Duannoithat.Data
{
    public class NoithatDbContext : IdentityDbContext<IdentityUser>
    {
        public NoithatDbContext(DbContextOptions<NoithatDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Bàn Ghế",
                Price = 2500,
                Detail = "Phong cách hiện đại phù hợp với nhiều không gian nội thất",
                ImageUrl = "https://shopdogothachthat.com/pic/Bo-ban-an-6-ghe-go-soi%20(2).jpg",
                IsTrendingProduct = true,
            },
            new Product
            {
                Id = 2,
                Name = "Ghế Sofa",
                Price = 2000,
                Detail = "Ngồi là êm ngủ là ngon",
                ImageUrl = "https://noithatdangkhoa.com/wp-content/uploads/2024/06/ghe-sofa-vang-da-phong-khach-sfdk124.jpg",
                IsTrendingProduct = true,
            },
            new Product
            {
                Id = 3,
                Name = "Giường",
                Price = 1500,
                Detail = "Cao su tự nhiên",
                ImageUrl = "https://nemhana.com/wp-content/uploads/2023/10/dem-thang-loi-cao-su-non-cao-cap.jpg",
                IsTrendingProduct = true,
            },
            new Product
            {
                Id = 4,
                Name = "Tủ đồ",
                Price = 1500,
                Detail = "Tủ đồ phong cách hiện đại",
                ImageUrl = "https://product.hstatic.net/1000075734/product/tu-quan-ao-canh-lua-cho-phong-ngu-hien-dai-2-1_546ad20e7ef54efa955fc6c5ed4af619_grande.jpg",
                IsTrendingProduct = true,
            },
            new Product
            {
                Id = 5,
                Name = "Kệ sách",
                Price = 2500,
                Detail = "kệ sách cổ điển",
                ImageUrl = "https://api.togihome.vn/storage/images/originals/ke-sach-go-tu-nhien-thiet-ke-nhieu-ngan-sd47-1-idbeaaw8w4zkkyz.webp",
                IsTrendingProduct = true,
            },
            new Product
            {
                Id = 6,
                Name = "Giường",
                Price = 3500,
                Detail = "Giường gỗ",
                ImageUrl = "https://dogomanhhung.com/uploads/images/634fc215dfc29f68d57258e0/z3812119525960_9d3fba21753fc64d873dc2fa3fbcece6.jpg",
                IsTrendingProduct = true,
            }
            );
        }
    }
}
