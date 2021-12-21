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
    [Route("/buyer")]
    public class BuyerController : ControllerBase
    {

        [HttpPut("Create")]
        public Buyer Create(Buyer buyer)
        {
            Storage.BuyerStorage.Create(buyer);
            return Storage.BuyerStorage.Read(buyer.Id);
        }

        [HttpGet("Read")]
        public Buyer Read(int Id)
        {
            return Storage.BuyerStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Buyer Update(int Id, Buyer newBuyer)
        {
            return Storage.BuyerStorage.Update(Id, newBuyer);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.BuyerStorage.Delete(Id);
        }
    }
}