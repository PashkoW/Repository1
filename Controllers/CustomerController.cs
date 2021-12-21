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
    [Route("/customer")]
    public class CustomerController : ControllerBase
    {

        [HttpPut("Create")]
        public Customer Create(Customer customer)
        {
            Storage.CustomerStorage.Create(customer);
            return Storage.CustomerStorage.Read(customer.CustomerId);
        }

        [HttpGet("Read")]
        public Customer Read(int Id)
        {
            return Storage.CustomerStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Customer Update(int Id, Customer newCustomer)
        {
            return Storage.CustomerStorage.Update(Id, newCustomer);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.CustomerStorage.Delete(Id);
        }
    }
}