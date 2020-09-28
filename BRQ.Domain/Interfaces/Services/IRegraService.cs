using BRQ.Domain.Entities;
using System.Collections.Generic;

namespace BRQ.Domain.Interfaces.Services
{
    public interface IRegraService : IServiceBase<Regra>
    {
        IEnumerable<Regra> BuscarPorGrupo(int id);
    }
}
