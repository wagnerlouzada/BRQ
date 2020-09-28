using BRQ.Domain.Entities;
using System.Collections.Generic;

namespace BRQ.Domain.Interfaces.Services
{
    public interface IGrupoDeRegrasService : IServiceBase<GrupoDeRegras>
    {
        //IEnumerable<Regra> ClassificarTrades(int GrupoDeRegrasId);
        List<string> ClassificarTrades(int GrupoDeRegrasId);
    }
}
