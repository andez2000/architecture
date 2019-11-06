﻿using Acme.MicroServices.Foo.Models;
using Acme.MicroServices.Foo.Repositories;
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
    }

    public interface IAlphaService
    {
        public int GetTotal();

        public AlphaModel[] GetAll();
    }
}
