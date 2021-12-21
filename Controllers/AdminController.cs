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
    [Route("/admin")]
    public class AdminController : ControllerBase
    {

        [HttpPut("Create")]
        public Admin Create(Admin admin)
        {
            Storage.AdminStorage.Create(admin);
            return Storage.AdminStorage.Read(admin.Id);
        }

        [HttpGet("Read")]
        public Admin Read(int Id)
        {
            return Storage.AdminStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Admin Update(int Id, Admin newAdmin)
        {
            return Storage.AdminStorage.Update(Id, newAdmin);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.AdminStorage.Delete(Id);
        }
    }
}