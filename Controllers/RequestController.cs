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
    [Route("/request")]
    public class RequestController : ControllerBase
    {

        [HttpPut("Create")]
        public Request Create(Request request)
        {
            Storage.RequestStorage.Create(request);
            return Storage.RequestStorage.Read(request.RequestId);
        }

        [HttpGet("Read")]
        public Request Read(int Id)
        {
            return Storage.RequestStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Request Update(int Id, Request newRequest)
        {
            return Storage.RequestStorage.Update(Id, newRequest);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.RequestStorage.Delete(Id);
        }
    }
}