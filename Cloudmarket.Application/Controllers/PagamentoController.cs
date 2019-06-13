using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using Cloudmarket.Domain.Entities;
using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Web.Models;

namespace Cloudmarket.Controllers
{
    public class PagamentoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Pagamento
        public ActionResult Index()
        {
            return View(db.Pagamentos.ToList());
        }

        // GET: Pagamento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagamento pagamento = db.Pagamentos.Find(id);
            if (pagamento == null)
            {
                return HttpNotFound();
            }
            return View(pagamento);
        }

        // GET: Pagamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pagamento/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public int Create([Bind(Include = "Id,UsuarioId,Tipo,InformacoesPagamento")] PagamentoViewModel pagamento)
        {

            new MapperConfiguration(map => { map.CreateMap<PagamentoViewModel, Pagamento>(); });

            var model = Mapper.Map<PagamentoViewModel, Pagamento>(pagamento);

            if (ModelState.IsValid)
            {
                db.Pagamentos.Add(model);
                db.SaveChanges();
                return model.Id;
            }

            return 0;
        }

        // GET: Pagamento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagamento pagamento = db.Pagamentos.Find(id);
            if (pagamento == null)
            {
                return HttpNotFound();
            }
            return View(pagamento);
        }

        // POST: Pagamento/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UsuarioId,Tipo,InformacoesPagamento")] PagamentoViewModel pagamento)
        {

            new MapperConfiguration(map => { map.CreateMap<PagamentoViewModel, Pagamento>(); });

            var model = Mapper.Map<PagamentoViewModel, Pagamento>(pagamento);

            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pagamento);
        }

        // GET: Pagamento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagamento pagamento = db.Pagamentos.Find(id);
            if (pagamento == null)
            {
                return HttpNotFound();
            }
            return View(pagamento);
        }

        // POST: Pagamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pagamento pagamento = db.Pagamentos.Find(id);
            db.Pagamentos.Remove(pagamento);
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
