using System.Collections.Generic;
using BRQ.Domain.Entities;
using BRQ.Domain.Interfaces.Repositories;
using BRQ.Domain.Interfaces.Services;

namespace BRQ.Domain.Services
{
    public class Regraservice : ServiceBase<Regra>, IRegraService
    {
        private readonly IRegraRepository _regraRepository;

        public Regraservice(IRegraRepository regraRepository) : base(regraRepository)
        {
            _regraRepository = regraRepository;
        }

        public IEnumerable<Regra> BuscarPorGrupo(int id)
        {
            return _regraRepository.BuscarPorGrupo(id);
        }
    }
}
