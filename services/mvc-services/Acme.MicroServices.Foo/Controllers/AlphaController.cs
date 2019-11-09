using Acme.MicroServices.Foo.Models;
using Acme.MicroServices.Foo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Acme.MicroServices.Foo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlphaController : ControllerBase
    {
        private readonly IAlphaService _alphaService;
        private readonly ILogger<AlphaController> _logger;

        public AlphaController(ILogger<AlphaController> logger, IAlphaService alphaService)
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
		public IEnumerable<AlphaModel> Get()
		{
			return _alphaService.GetAll();
		}

		[HttpPatch]
		public IActionResult Update(AlphaModel request)
		{
			_alphaService.Update(request);
			return Ok();
		}

		[HttpDelete]
		public IActionResult Delete(Guid id)
		{
			_alphaService.Delete(id);
			return Ok();
		}
	}
}
