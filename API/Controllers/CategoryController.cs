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
    
    public class CategoryController : ControllerBase
    {
        private readonly ICategory ICat;
        public CategoryController(ICategory _ICat)
        {
          ICat = _ICat;
        } 
        [HttpGet]
        public bool AddCategory(MCategory addCat)
        {
            // RCategory RC = new RCategory();
            return true;
        }
        
    }
}
