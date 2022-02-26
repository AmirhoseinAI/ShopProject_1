using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using Core.Interface.Repository;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    
    public class ColorController : ControllerBase
    {
        private readonly IColor ICo;
        public ColorController(IColor _ICo)
        {
          ICo = _ICo;
        }
        [HttpPost]
        public IActionResult AddColor(MColor addcolor)
        {
          var r = ICo.AddColor(addcolor);
          return Ok(r);
        }
        
    }
}
