using BRQ.Domain.Entities;
using System.Collections.Generic;

namespace BRQ.Domain.Interfaces.Repositories
{
    public interface IRegraRepository : IRepositoryBase<Regra>
    {
        IEnumerable<Regra> BuscarPorGrupo(int id);
    }
}
