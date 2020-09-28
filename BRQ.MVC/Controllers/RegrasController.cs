using AutoMapper;
using BRQ.MVC.ViewModels;
using BRQ.Application.Interface;
using BRQ.Domain.Entities;
using System.Web.Mvc;
using System.Collections.Generic;

namespace BRQ.MVC.Controllers
{
    public class RegrasController : Controller
    {
        private readonly IGrupoDeRegrasAppService _grupoDeRegrasAppService;
        private readonly IRegraAppService _regraAppService;

        public RegrasController(IGrupoDeRegrasAppService grupoDeRegrasAppService, IRegraAppService regraAppService)
        {
            _grupoDeRegrasAppService = grupoDeRegrasAppService;
            _regraAppService = regraAppService;
        }

        // GET: Regras
        public ActionResult Index()
        {
            var gruposDeRegrasViewModel = Mapper.Map<IEnumerable<Regra>, IEnumerable<RegraViewModel>>(_regraAppService.GetAll());
            return View(gruposDeRegrasViewModel);
        }

        // GET: Regras/Details/5
        public ActionResult Details(int id)
        {
            var regraViewModel = Mapper.Map<Regra, RegraViewModel>(_regraAppService.GetById(id));
            return View(regraViewModel);
        }

        // GET: Regras/Create
        public ActionResult Create()
        {
            ViewBag.GrupoDeRegrasId = new SelectList(_grupoDeRegrasAppService.GetAll(), "GrupoDeRegrasId", "Descricao");
            return View();
        }

        // POST: Regras/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegraViewModel regra)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<RegraViewModel, Regra>(regra);
                _regraAppService.Add(produtoDomain);
                return RedirectToAction("Index");
            }

            return View(regra);
        }

        // GET: Regras/Edit/5
        public ActionResult Edit(int id)
        {
            var regraViewModel = Mapper.Map<Regra, RegraViewModel>(_regraAppService.GetById(id));
            ViewBag.GrupoDeRegrasId = new SelectList(_grupoDeRegrasAppService.GetAll(), "GrupoDeRegrasId", "Descricao", regraViewModel.GrupoDeRegrasId);

            return View(regraViewModel);
        }

        // POST: Regras/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RegraViewModel regra)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<RegraViewModel, Regra>(regra);
                _regraAppService.Update(produtoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.GrupoDeRegrasId = new SelectList(_grupoDeRegrasAppService.GetAll(), "GrupoDeRegrasId", "Descricao", regra.GrupoDeRegrasId);
            return View(regra);
        }

        // GET: Regras/Delete/5
        public ActionResult Delete(int id)
        {
            var regra = _regraAppService.GetById(id);
            var regraViewModel = Mapper.Map<Regra, RegraViewModel>(regra);
            return View(regraViewModel);
        }

        // POST: Regras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var regra = _regraAppService.GetById(id);
            _regraAppService.Remove(regra);
            return RedirectToAction("Index");
        }
    }
}
