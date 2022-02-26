using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using Core.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    
    public class ProductController : ControllerBase
    {
        private readonly IProduct IPro;
        public ProductController(IProduct _IPro)
        {
          IPro = _IPro;
        } 
        


    }
}
