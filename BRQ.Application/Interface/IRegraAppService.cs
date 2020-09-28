using BRQ.Domain.Entities;
using System.Collections.Generic;

namespace BRQ.Application.Interface
{
    public interface IRegraAppService : IAppServiceBase<Regra>
    {
        IEnumerable<Regra> BuscarPorGrupo(int id);
    }
}
