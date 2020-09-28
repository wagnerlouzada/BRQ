using System.Collections.Generic;
using BRQ.Domain.Entities;
using System.Linq;
using BRQ.Domain.Interfaces.Repositories;

namespace BRQ.Infra.Data.Repositories
{
    public class RegraRepository : RepositoryBase<Regra>, IRegraRepository
    {
        public IEnumerable<Regra> BuscarPorGrupo(int id)
        {
            return Db.Regras.Where(p => p.GrupoDeRegrasId == id);
        }
    }
}
