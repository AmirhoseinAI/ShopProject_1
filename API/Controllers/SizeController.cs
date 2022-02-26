using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using Core.Interface.Repository;
using Core.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    
    public class SizeController : ControllerBase
    {
        private readonly ISize Isize;
        public SizeController(ISize _Isize)
        {
          Isize = _Isize;
        } 
        [HttpPost]
        public IActionResult AddSize(MSize addsize)
        {
            var n = Isize.AddSize(addsize);
            return Ok(n);
        }
        


    }
}
