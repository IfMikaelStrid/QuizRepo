using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class QuizController
    {
        [HttpGet]
        public IEnumerable<Quiz> Get()
        {
            return null;
        }
    }
}
