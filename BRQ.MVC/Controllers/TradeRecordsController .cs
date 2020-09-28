using AutoMapper;
using BRQ.Application.Interface;
using BRQ.Domain.Entities;
using BRQ.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BRQ.MVC.Controllers
{
    public class TradeRecordsController : Controller
    {
        private readonly ITradeRecordAppService _tradeApp;

        public TradeRecordsController(ITradeRecordAppService tradeApp)
        {
            _tradeApp = tradeApp;

        }

        // GET: TradeRecords
        public ActionResult Index()
        {
            var tradeViewModel = Mapper.Map<IEnumerable<TradeRecord>, IEnumerable<TradeRecordViewModel>>(_tradeApp.GetAll());
            return View(tradeViewModel);
        }

        // GET: TradeRecords/Details/5
        public ActionResult Details(int id)
        {
            var trade = _tradeApp.GetById(id);
            var tradeViewModel = Mapper.Map<TradeRecord, TradeRecordViewModel>(trade);
            return View();
        }

        // GET: TradeRecords/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TradeRecords/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TradeRecordViewModel trade)
        {
            if (ModelState.IsValid)
            {
                var tradeDomain = Mapper.Map<TradeRecordViewModel, TradeRecord>(trade);
                _tradeApp.Add(tradeDomain);
                return RedirectToAction("Index");
            }

            return View(trade);
        }

        // GET: TradeRecords/Edit/5
        public ActionResult Edit(int id)
        {
            var trade = _tradeApp.GetById(id);
            var tradeViewModel = Mapper.Map<TradeRecord, TradeRecordViewModel>(trade);

            return View(tradeViewModel);
        }

        // POST: TradeRecords/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TradeRecordViewModel trade)
        {
            if (ModelState.IsValid)
            {
                var tradeDomain = Mapper.Map<TradeRecordViewModel, TradeRecord>(trade);
                _tradeApp.Update(tradeDomain);

                return RedirectToAction("Index");
            }

            return View(trade);
        }

        // GET: TradeRecords/Delete/5
        public ActionResult Delete(int id)
        {
            var trade = _tradeApp.GetById(id);
            var TradeRecordViewModel = Mapper.Map<TradeRecord, TradeRecordViewModel>(trade);
            return View(TradeRecordViewModel);
        }

        // POST: TradeRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var trade = _tradeApp.GetById(id);
            _tradeApp.Remove(trade);

            return RedirectToAction("Index");
        }
     
    }
}
