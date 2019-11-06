using Acme.MicroServices.Foo.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Acme.MicroServices.Foo.Repositories
{
    public interface IAlphaRepository
    {
        Alpha[] GetAll();
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
    }
}
