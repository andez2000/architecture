using Acme.MicroServices.Foo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Acme.MicroServices.Foo.Repositories
{
    public interface IAlphaRepository
    {
        Alpha[] GetAll();

		Alpha Get(Guid id);

		void Update(Alpha alpha);
    }

    public class AlphaRepository : IAlphaRepository
    {
        private readonly List<Alpha> _alphas;

        public AlphaRepository()
        {
            _alphas = new List<Alpha>();
        }

        public Alpha[] GetAll()
        {
            return _alphas.ToArray();
        }

		public Alpha Get(Guid id)
		{
			return _alphas.Single(a => a.Id == id);
		}

		public void Update(Alpha alpha)
		{
			int index = _alphas.IndexOf(_alphas.Single(a => a.Id == alpha.Id));
			_alphas[index] = alpha;
		}

	}
}
