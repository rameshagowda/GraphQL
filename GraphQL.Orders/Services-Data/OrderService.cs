using System;
using System.Collections.Generic;
using GraphQL.Orders.Models;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Orders.Services
{
    public class OrderService : IOrderService
    {
        private readonly IList<Order> _orders;

        public OrderService()
        {
            _orders = new List<Order>();
            _orders.Add(new Order("101", "100 Conference brochures", DateTime.Now, 1, "7777-8888-6666-ABCD"));
            _orders.Add(new Order("201", "200 Sports T-shirts", DateTime.Now.AddHours(1), 2, "ABCD-XYZZ-PQRS-7777"));
            _orders.Add(new Order("301", "300 Sports Stickers", DateTime.Now.AddHours(2), 3, "8888-ABCD-PQRS-7777"));
            _orders.Add(new Order("401", "400 Sports Posters", DateTime.Now.AddHours(2), 4, "9999-XYZD-ABCD-8888"));
        }

        public Task<Order> GetOrderByIdAsync(string id)
        {
            return Task.FromResult(_orders.Single(o => Equals(o.Id, id)));
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return Task.FromResult(_orders.AsEnumerable());
        }
    }
    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(string id);
        Task<IEnumerable<Order>> GetOrdersAsync();
    }
}
