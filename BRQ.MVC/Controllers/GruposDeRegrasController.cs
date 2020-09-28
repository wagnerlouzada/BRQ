using AutoMapper;
using BRQ.Application.Interface;
using BRQ.Domain.Entities;
using BRQ.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BRQ.MVC.Controllers
{
    public class GruposDeRegrasController : Controller
    {
        private readonly IGrupoDeRegrasAppService _grupoDeRegrasApp;

        public GruposDeRegrasController(IGrupoDeRegrasAppService grupoDeRegrasApp)
        {
            _grupoDeRegrasApp = grupoDeRegrasApp;
        
        }

        // GET: GruposDeRegras
        public ActionResult Index()
        {
            var grupoDeRegrasViewModel = Mapper.Map<IEnumerable<GrupoDeRegras>, IEnumerable<GrupoDeRegrasViewModel>>(_grupoDeRegrasApp.GetAll());
            return View(grupoDeRegrasViewModel);
        }

        // GET: GruposDeRegras/Details/5
        public ActionResult Details(int id)
        {
            var grupoDeRegras = _grupoDeRegrasApp.GetById(id);
            var grupoDeRegrasViewModel = Mapper.Map<GrupoDeRegras, GrupoDeRegrasViewModel>(grupoDeRegras);
            return View();
        }

        // GET: GruposDeRegras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GruposDeRegras/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GrupoDeRegrasViewModel grupoDeRegras)
        {
            if (ModelState.IsValid)
            {
                var grupoDeRegrasDomain = Mapper.Map<GrupoDeRegrasViewModel, GrupoDeRegras>(grupoDeRegras);
                _grupoDeRegrasApp.Add(grupoDeRegrasDomain);
                return RedirectToAction("Index");
            }

            return View(grupoDeRegras);
        }

        // GET: GruposDeRegras/Edit/5
        public ActionResult Edit(int id)
        {
            var grupoDeRegras = _grupoDeRegrasApp.GetById(id);
            var grupoDeRegrasViewModel = Mapper.Map<GrupoDeRegras, GrupoDeRegrasViewModel>(grupoDeRegras);

            return View(grupoDeRegrasViewModel);
        }

        // POST: GruposDeRegras/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GrupoDeRegrasViewModel grupoDeRegras)
        {
            if (ModelState.IsValid)
            {
                var grupoDeRegrasDomain = Mapper.Map<GrupoDeRegrasViewModel, GrupoDeRegras>(grupoDeRegras);
                _grupoDeRegrasApp.Update(grupoDeRegrasDomain);

                return RedirectToAction("Index");
            }

            return View(grupoDeRegras);
        }

        // GET: GruposDeRegras/Delete/5
        public ActionResult Delete(int id)
        {
            var grupoDeRegras = _grupoDeRegrasApp.GetById(id);
            var GrupoDeRegrasViewModel = Mapper.Map<GrupoDeRegras, GrupoDeRegrasViewModel>(grupoDeRegras);
            return View(GrupoDeRegrasViewModel);
        }

        // POST: GruposDeRegras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var grupoDeRegras = _grupoDeRegrasApp.GetById(id);
            _grupoDeRegrasApp.Remove(grupoDeRegras);

            return RedirectToAction("Index");
        }

        // GET: GruposDeRegras/Process/5
        public ActionResult Process(int id)
        {
            var classificacoes = _grupoDeRegrasApp.ClassificarTrades(id);

            // atualiza os dados no modelo...
            var grupoDeRegras = _grupoDeRegrasApp.GetById(id);
            grupoDeRegras.Classificacoes = classificacoes;

            var grupoDeRegrasViewModel = Mapper.Map<GrupoDeRegras, GrupoDeRegrasViewModel>(grupoDeRegras);
            return View(grupoDeRegrasViewModel);
            return null;
        }

        // POST: GruposDeRegras/Process/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Process(GrupoDeRegrasViewModel grupoDeRegras)
        {
            //if (ModelState.IsValid)
            //{
            //    var grupoDeRegrasDomain = Mapper.Map<GrupoDeRegrasViewModel, GrupoDeRegras>(grupoDeRegras);
            //    _grupoDeRegrasApp.Update(grupoDeRegrasDomain);

            //    return RedirectToAction("Index");
            //}

            return View(grupoDeRegras);
        }
    }
}
