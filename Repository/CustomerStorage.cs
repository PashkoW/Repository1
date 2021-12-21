using Repository1.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Repository1.Repository
{
    public class CustomerStorage
    {
        private readonly Dictionary<int, Customer> _Customers = new();

        public Customer Create(Customer customer)
        {

            _Customers.Add(customer.CustomerId, customer);
            return customer;

        }

        public Customer Read(int CustomerId)
        {
            return _Customers[CustomerId];
        }

        public Customer Update(int CustomerId, Customer newCustomer)
        {
            _Customers[CustomerId] = newCustomer;
            return _Customers[CustomerId];
        }

        public bool Delete(int CustomerId)
        {
            return _Customers.Remove(CustomerId);
        }
    }
}