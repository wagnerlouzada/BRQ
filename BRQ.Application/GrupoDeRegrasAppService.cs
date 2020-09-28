using System.Collections.Generic;
using BRQ.Application.Interface;
using BRQ.Domain.Entities;
using BRQ.Domain.Interfaces.Services;

namespace BRQ.Application
{
    public class GrupoDeRegrasAppService : AppServiceBase<GrupoDeRegras>, IGrupoDeRegrasAppService
    {
        private readonly IGrupoDeRegrasService _grupoDeRegrasService;


        public GrupoDeRegrasAppService(IGrupoDeRegrasService grupoDeRegrasService ) : base(grupoDeRegrasService)
        {
            _grupoDeRegrasService = grupoDeRegrasService;

        }

        //public IEnumerable<Regra> ClassificarTrades(int GrupoDeRegrasId)
        public List<string> ClassificarTrades(int GrupoDeRegrasId)
        {
            var result = _grupoDeRegrasService.ClassificarTrades(GrupoDeRegrasId);
            return result;
        }


    }
}
