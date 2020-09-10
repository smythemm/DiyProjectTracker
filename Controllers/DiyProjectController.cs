using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DiyProjectTracker.Data;

namespace DiyProjectTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiyProjectController : ControllerBase
    {
        private readonly ILogger<DiyProjectController> _logger;

        public DiyProjectController(ILogger<DiyProjectController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public DiyProject Get()
        {
            return new DiyProject
            {
                Name = "Remove Floor Paint",
                ClientName = "Matthew Smythe",
                EstimatedDaysToComplete = 10
            };
        }
    }
}
