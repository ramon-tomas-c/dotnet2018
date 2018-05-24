using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Infrastructure;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BeersController : Controller
    {
        private readonly BeersContext ctx;

        public BeersController(BeersContext ctx)
        {
            this.ctx = ctx;
        }

        // GET api/beers
        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return ctx.Beers.ToList();
        }        
    }
}
