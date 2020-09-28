using BRQ.Domain.Entities;
using System.Collections.Generic;

namespace BRQ.Application.Interface
{
    public interface IGrupoDeRegrasAppService : IAppServiceBase<GrupoDeRegras>
    {
        //IEnumerable<Regra> ObterRegras(int GrupoRegrasId);
        List<string> ClassificarTrades(int GrupoRegrasId);
    }
}
