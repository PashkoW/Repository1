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
    [Route("/review")]
    public class ReviewController : ControllerBase
    {

        [HttpPut("Create")]
        public Review Create(Review request)
        {
            Storage.ReviewStorage.Create(request);
            return Storage.ReviewStorage.Read(request.Id);
        }

        [HttpGet("Read")]
        public Review Read(int Id)
        {
            return Storage.ReviewStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Review Update(int Id, Review newReview)
        {
            return Storage.ReviewStorage.Update(Id, newReview);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.ReviewStorage.Delete(Id);
        }
    }
}