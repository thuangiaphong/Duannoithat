using Duannoithat.Data;
using Duannoithat.Models.Interface;
using Microsoft.EntityFrameworkCore;

namespace Duannoithat.Models.Services
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> GetAllOrdersWithDetails()
        {
            return DbContext.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .OrderByDescending(o => o.OrderPlaced)
                .ToList();
        }

        private NoithatDbContext DbContext;
        private IShoppingCartRepository shoppingCartRepository;

        public OrderRepository(NoithatDbContext DbContext, IShoppingCartRepository shoppingCartRepository)
        {
            this.DbContext = DbContext;
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public void PlaceOrder(Order Order)
        {
            var shoppingCartItems = shoppingCartRepository.GetAllShoppingCartItems();
            Order.OrderDetails = new List<OrderDetail>();

            foreach (var item in shoppingCartItems)
            {
                var OrderDetail = new OrderDetail
                {
                    Quantity = item.Qty,
                    ProductId = item.Product.Id,
                    Price = item.Product.Price
                };
                Order.OrderDetails.Add(OrderDetail);
            }

            Order.OrderPlaced = DateTime.Now;
            Order.OrderTotal = shoppingCartRepository.GetShoppingCartTotal();
            DbContext.Orders.Add(Order);
            DbContext.SaveChanges();
        }
    }
}
