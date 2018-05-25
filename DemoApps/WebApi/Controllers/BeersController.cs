using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApi.Infrastructure;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BeersController : Controller
    {
        private readonly BeersContext ctx;
        private readonly IOptionsSnapshot<Settings> settings;

        public BeersController(BeersContext ctx, IOptionsSnapshot<Settings> settings)
        {
            this.ctx = ctx;
            this.settings = settings;
        }

        // GET api/beers
        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return ctx.Beers.AsQueryable().Select(s =>
                new Beer()
                {
                    Id = s.Id,
                    Code = s.Code,
                    Country = s.Country,
                    Name = s.Name,
                    ImageUrl = $"{settings.Value.BlobStorageUrl}{s.Code}.jpg"

                }).ToList();
        }   
    }
}
