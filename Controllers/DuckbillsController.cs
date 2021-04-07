using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;


namespace Project1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DuckbillsControllers : ControllerBase
    {
        private readonly ILogger<DuckbillsControllers> _logger;

        public DuckbillsControllers(ILogger<DuckbillsControllers> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<AngularProject.Models.Duckbill> Get()
        { 
            return new AngularProject.Models.Duckbill[2]
            {
                new AngularProject.Models.Duckbill() { ID = Guid.NewGuid(), Name = "Duckbill 1" },
                new AngularProject.Models.Duckbill() { ID = Guid.NewGuid(), Name = "Duckbill 2" }
            };
        }
    }
}