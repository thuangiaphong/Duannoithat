namespace Duannoithat.Models.Interface
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
        IEnumerable<Order> GetAllOrdersWithDetails();
    }
}
