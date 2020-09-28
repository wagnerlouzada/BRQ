using System;
using System.Collections.Generic;
using BRQ.Application.Interface;
using BRQ.Domain.Entities;
using BRQ.Domain.Interfaces.Services;

namespace BRQ.Application
{
    public class RegraAppService : AppServiceBase<Regra>, IRegraAppService
    {
        private readonly IRegraService _Regraservice;

        public RegraAppService(IRegraService Regraservice) : base(Regraservice)
        {
            _Regraservice = Regraservice;
        }

        public IEnumerable<Regra> BuscarPorGrupo(int id)
        {
            return _Regraservice.BuscarPorGrupo(id);
        }
    }
}
