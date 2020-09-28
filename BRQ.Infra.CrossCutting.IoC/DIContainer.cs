using BRQ.Application;
using BRQ.Application.Interface;
using BRQ.Domain.Interfaces.Repositories;
using BRQ.Domain.Interfaces.Services;
using BRQ.Domain.Services;
using BRQ.Infra.Data.Repositories;
using SimpleInjector;

namespace BRQ.Infra.CrossCutting.IoC
{
    public static class DIContainer
    {
        public static Container RegisterDependencies()
        {
            var container = new Container();

            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.Register<IGrupoDeRegrasRepository, GrupoDeRegrasRepository>();
            container.Register<IRegraRepository, RegraRepository>();
            container.Register<ITradeRecordRepository, TradeRecordRepository>();

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IGrupoDeRegrasService, GruposDeRegraservice>();
            container.Register<IRegraService, Regraservice>();
            container.Register<ITradeRecordService, TradeRecordservice>();

            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            container.Register<IGrupoDeRegrasAppService, GrupoDeRegrasAppService>();
            container.Register<IRegraAppService, RegraAppService>();
            container.Register<ITradeRecordAppService, TradeRecordAppService>();

            return container;
        }
    }
}
