using Acme.MicroServices.Foo.Entities;
using Acme.MicroServices.Foo.Repositories;
using Acme.MicroServices.Foo.Services;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using System;

namespace Acme.MicroServices.Foo.Tests
{
	[TestFixture]
    public class AlphaServiceTests
	{
		private AlphaService _service;
		private Mock<IAlphaRepository> _alphaRepository;

		[SetUp]
		public void Setup()
		{
			_alphaRepository = new Mock<IAlphaRepository>();
			_service = new AlphaService(_alphaRepository.Object);
		}

		[Test]
        public void SumReturnsCorrectTotal()
        {
			var alphas = new[]
			{
				new Alpha { Id = Guid.Empty, Name = "1",  Number = 3 },
				new Alpha { Id = Guid.Empty, Name = "2",  Number = 2 },
			};

			_alphaRepository.Setup(m => m.GetAll()).Returns(alphas);

			var result = _service.GetTotal();

			result.Should().Be(5);

		}
    }
}
