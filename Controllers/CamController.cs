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
    [Route("/cam")]
    public class CamController : ControllerBase
    {

        [HttpPut("Create")]
        public Cam Create(Cam cam)
        {
            Storage.CamStorage.Create(cam);
            return Storage.CamStorage.Read(cam.Id);
        }

        [HttpGet("Read")]
        public Cam Read(int Id)
        {
            return Storage.CamStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Cam Update(int Id, Cam newCam)
        {
            return Storage.CamStorage.Update(Id, newCam);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.CamStorage.Delete(Id);
        }
    }
}