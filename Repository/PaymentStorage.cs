using Repository1.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Repository1.Repository
{
    public class PaymentStorage
    {
        private readonly Dictionary<int, Payment> _payments = new();

        public Payment Create(Payment payment)
        {

            _payments.Add(payment.PaymentId, payment);
            return payment;

        }

        public Payment Read(int paymentId)
        {
            return _payments[paymentId];
        }

        public Payment Update(int paymentId, Payment newPayment)
        {
            _payments[paymentId] = newPayment;
            return _payments[paymentId];
        }

        public bool Delete(int paymentId)
        {
            return _payments.Remove(paymentId);
        }
    }
}