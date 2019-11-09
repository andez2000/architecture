using Acme.MicroServices.Foo.Models;
using Acme.MicroServices.Foo.Repositories;
using System;
using System.Linq;

namespace Acme.MicroServices.Foo.Services
{
    public class AlphaService : IAlphaService
    {
        public AlphaService(IAlphaRepository alphaRepository)
        {
            _alphaRepository = alphaRepository;
        }

        private readonly IAlphaRepository _alphaRepository;

        public int GetTotal()
        {
            return _alphaRepository.GetAll().Sum(a => a.Number);
        }

        public AlphaModel[] GetAll()
        {
            return _alphaRepository.GetAll().Select(a => new AlphaModel
            {
                Id = a.Id,
                Name = a.Name
            }).ToArray();
        }

		public void Update(AlphaModel model)
		{
			var alpha = _alphaRepository.Get(model.Id);

			alpha.Name = model.Name;
			alpha.Number = model.Number;

			_alphaRepository.Update(alpha);
		}

		public void Delete(Guid id)
		{
			_alphaRepository.Delete(id);
		}
	}

    public interface IAlphaService
    {
        public int GetTotal();

        public AlphaModel[] GetAll();

		public void Update(AlphaModel model);
		public void Delete(Guid id);
	}
}
