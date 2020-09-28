using System.Collections.Generic;
using BRQ.Domain.Entities;
using BRQ.Domain.Interfaces.Repositories;
using BRQ.Domain.Interfaces.Services;

namespace BRQ.Domain.Services
{
    public class TradeRecordservice : ServiceBase<TradeRecord>, ITradeRecordService
    {
        private readonly ITradeRecordRepository _tradeRepository;

        public TradeRecordservice(ITradeRecordRepository tradeRepository) : base(tradeRepository)
        {
            _tradeRepository = tradeRepository;
        }
    }
}
