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
    [Route("/answer")]
    public class AnswerController : ControllerBase
    {

        [HttpPut("Create")]
        public Answer Create(Answer answer)
        {
            Storage.AnswerStorage.Create(answer);
            return Storage.AnswerStorage.Read(answer.Id);
        }

        [HttpGet("Read")]
        public Answer Read(int Id)
        {
            return Storage.AnswerStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Answer Update(int Id, Answer newAnswer)
        {
            return Storage.AnswerStorage.Update(Id, newAnswer);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.AnswerStorage.Delete(Id);
        }
    }
}