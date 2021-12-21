using Repository1.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Repository1.Repository
{
    public class OrderStorage
    {
        private readonly Dictionary<int, Order> _Orders = new();

        public Order Create(Order order)
        {

            _Orders.Add(order.Id, order);
            return order;

        }

        public Order Read(int Id)
        {
            return _Orders[Id];
        }

        public Order Update(int Id, Order newOrder)
        {
            _Orders[Id] = newOrder;
            return _Orders[Id];
        }

        public bool Delete(int Id)
        {
            return _Orders.Remove(Id);
        }
    }
}