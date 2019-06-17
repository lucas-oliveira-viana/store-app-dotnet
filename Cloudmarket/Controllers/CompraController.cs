using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using Cloudmarket.Application.Interface;
using Cloudmarket.Domain.Entities;
using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Web.Models;

namespace Cloudmarket.Web.Controllers
{
    [Authorize(Roles = "Administrador, Cliente")]
    public class CompraController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private readonly ICompraAppService _app;

        public CompraController(ICompraAppService app)
        {
            _app = app;
        }

        // GET: Compra
        public ActionResult Index()
        {
            return View(db.Compras.ToList());
        }

        // GET: Compra/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Compra compra = _app.GetById(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            return View(compra);
        }

        // GET: Compra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Compra/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Create([Bind(Include = "Id,EnderecoId,PagamentoId,UsuarioId,ProdutosCarrinho")] CompraViewModel compra)
        {

            if (ModelState.IsValid)
            {
                new MapperConfiguration(map => { map.CreateMap<CompraViewModel, Compra>(); });
                var model = Mapper.Map<CompraViewModel, Compra>(compra);

                _app.Add(model);
                db.SaveChanges();
            }
        }

        // GET: Compra/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compra compra = _app.GetById(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            return View(compra);
        }

        // POST: Compra/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] Compra compra)
        {
            if (ModelState.IsValid)
            {
                _app.Update(compra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(compra);
        }

        // GET: Compra/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compra compra = _app.GetById(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            return View(compra);
        }

        // POST: Compra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Compra compra = _app.GetById(id);
            _app.Remove(compra);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
