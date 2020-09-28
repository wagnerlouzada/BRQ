using System.Collections.Generic;
using BRQ.Domain.Entities;
using BRQ.Domain.Interfaces.Repositories;
using BRQ.Domain.Interfaces.Services;
using System.Linq;

namespace BRQ.Domain.Services
{
    public class GruposDeRegraservice : ServiceBase<GrupoDeRegras>, IGrupoDeRegrasService, IRegraRepository, ITradeRecordRepository
    {
        private readonly IGrupoDeRegrasRepository _grupoDeRegrasRepository;
        private readonly IRegraRepository _regraRepository;
        private readonly ITradeRecordRepository _tradeRecordRepository;

        public GruposDeRegraservice(IGrupoDeRegrasRepository grupoDeRegrasRepository, IRegraRepository regraRepository, ITradeRecordRepository tradeRecordRepository) : base(grupoDeRegrasRepository)
        {
            _grupoDeRegrasRepository = grupoDeRegrasRepository;
            _regraRepository = regraRepository;
            _tradeRecordRepository = tradeRecordRepository;
        }

        #region regra

        public void Add(Regra obj)
        {
            _regraRepository.Add(obj);
        }

        public IEnumerable<Regra> BuscarPorGrupo(int id)
        {
            return _regraRepository.BuscarPorGrupo(id);
        }

        private string ProcessTrade(Trade trd, List<Regra> regras)
        {
            string result = "NONE";
            
            foreach(Regra regra in regras.OrderBy(p=>p.MinValue))
            {
                if (trd.Value >= regra.MinValue && trd.Value <= regra.MaxValue) result = regra.Risk;
            }

            return result;
        }

        //public IEnumerable<Regra> ClassificarTrades(int GrupoDeRegrasId)
        public List<string> ClassificarTrades(int GrupoDeRegrasId)
        {
            //var Regras = _regraRepository.GetAll();
            List<string> classificacoes = new List<string>();
            
            var Trades = _tradeRecordRepository.GetAll();
            List<Trade> TradesAProcessar = Trades.Select(p => new Trade
                                                {
                                                    ClientSector = p.ClientSector,
                                                    Value = p.Value
                                                }).ToList();

            var Regras = _regraRepository.GetAll();
      
            foreach (Trade trd in TradesAProcessar)
            {
                var regrasAUsar = Regras.Where(p => p.GrupoDeRegrasId == GrupoDeRegrasId && p.ClientSector.ToUpper() == trd.ClientSector.ToUpper()).Select(p => p).ToList();
                string TrdClassify = ProcessTrade(trd, regrasAUsar);
                classificacoes.Add(TrdClassify);
            }

            return classificacoes;

            //var result = Regras.Where(p=>p.GrupoDeRegrasId==GrupoDeRegrasId).Select(p=>p); //.Where(c => c.GrupoDeRegrasEspecial(c));


            //return result;
        }

        public void Remove(Regra obj)
        {
            _regraRepository.Remove(obj);
        }

        public void Update(Regra obj)
        {
            _regraRepository.Update(obj);
        }

        IEnumerable<Regra> IRepositoryBase<Regra>.GetAll()
        {
            return _regraRepository.GetAll();
        }

        Regra IRepositoryBase<Regra>.GetById(int id)
        {
            return _regraRepository.GetById(id);
        }

        #endregion

        #region traderecord

        public void Remove(TradeRecord obj)
        {
            _tradeRecordRepository.Remove(obj);
        }

        public void Update(TradeRecord obj)
        {
            _tradeRecordRepository.Update(obj);
        }

        public void Add(TradeRecord obj)
        {
            _tradeRecordRepository.Add(obj);
        }

        IEnumerable<TradeRecord> IRepositoryBase<TradeRecord>.GetAll()
        {
            return _tradeRecordRepository.GetAll();
        }

        TradeRecord IRepositoryBase<TradeRecord>.GetById(int id)
        {
            return _tradeRecordRepository.GetById(id);
        }

        #endregion

    }
}
