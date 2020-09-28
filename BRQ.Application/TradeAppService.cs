using System;
using System.Collections.Generic;
using BRQ.Application.Interface;
using BRQ.Domain.Entities;
using BRQ.Domain.Interfaces.Services;

namespace BRQ.Application
{
    public class TradeRecordAppService : AppServiceBase<TradeRecord>, ITradeRecordAppService
    {
        private readonly ITradeRecordService _TradeRecordservice;

        public TradeRecordAppService(ITradeRecordService TradeRecordservice) : base(TradeRecordservice)
        {
            _TradeRecordservice = TradeRecordservice;
        }

    }
}
