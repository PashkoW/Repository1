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
    [Route("/order")]
    public class OrderController : ControllerBase
    {

        [HttpPut("Create")]
        public Order Create(Order order)
        {
            Storage.OrderStorage.Create(order);
            return Storage.OrderStorage.Read(order.Id);
        }

        [HttpGet("Read")]
        public Order Read(int Id)
        {
            return Storage.OrderStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Order Update(int Id, Order newOrder)
        {
            return Storage.OrderStorage.Update(Id, newOrder);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.OrderStorage.Delete(Id);
        }
    }
}