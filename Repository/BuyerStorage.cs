using Repository1.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Repository1.Repository
{
    public class BuyerStorage
    {
        private readonly Dictionary<int, Buyer> _Buyers = new();

        public Buyer Create(Buyer buyer)
        {

            _Buyers.Add(buyer.Id, buyer);
            return buyer;

        }

        public Buyer Read(int Id)
        {
            return _Buyers[Id];
        }

        public Buyer Update(int Id, Buyer newBuyer)
        {
            _Buyers[Id] = newBuyer;
            return _Buyers[Id];
        }

        public bool Delete(int Id)
        {
            return _Buyers.Remove(Id);
        }
    }
}