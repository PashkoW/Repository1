using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository1.Domain;
using Repository1.Repository;

namespace FirstRepository.Controllers
{
    [ApiController]
    [Route("/payment")]
    public class PaymentController : ControllerBase
    {

        [HttpPut("Create")]
        public Payment Create(Payment payment)
        {
            Storage.PaymentStorage.Create(payment);
            return Storage.PaymentStorage.Read(payment.PaymentId);
        }

        [HttpGet("Read")]
        public Payment Read(int Id)
        {
            return Storage.PaymentStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Payment Update(int Id, Payment newPayment)
        {
            return Storage.PaymentStorage.Update(Id, newPayment);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.PaymentStorage.Delete(Id);
        }
    }
}