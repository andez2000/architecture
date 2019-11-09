using Acme.MicroServices.Foo.Models;
using Acme.MicroServices.Foo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Acme.MicroServices.Foo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlphaSummaryController : ControllerBase
    {
        private readonly IAlphaService _alphaService;
        private readonly ILogger<AlphaController> _logger;

        public AlphaSummaryController(ILogger<AlphaController> logger, IAlphaService alphaService)
        {
            _logger = logger;
            _alphaService = alphaService;
        }

        [HttpGet]
        public IActionResult GetTotals()
        {
            return Ok(_alphaService.GetTotal());
        }

		[HttpGet]
		public IEnumerable<AlphaSummary> Get()
		{
			return _alphaService.GetAll().Select(a => new AlphaSummary
			{
				Id = a.Id,
				Name = a.Name,
				Description = a.Description
			});
		}
	}
}
