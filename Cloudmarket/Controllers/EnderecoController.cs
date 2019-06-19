using AutoMapper;
using Cloudmarket.Application.Interface;
using Cloudmarket.Domain.Entities;
using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Web.Models;
using System.Net;
using System.Web.Mvc;

namespace Cloudmarket.Web.Controllers
{
    public class EnderecoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private readonly IEnderecoAppService _app;

        public EnderecoController(IEnderecoAppService app)
        {
            _app = app;
        }

        // GET: Endereco
        public ActionResult Index()
        {
            return View(_app.GetAll());
        }

        // GET: Endereco/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endereco endereco = _app.GetById(id);
            if (endereco == null)
            {
                return HttpNotFound();
            }
            return View(endereco);
        }

        // GET: Endereco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Endereco/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public int Create([Bind(Include = "Id,Cep,Estado,Cidade,Bairro,Rua,Numero,UsuarioId")] EnderecoViewModel endereco)
        {
            new MapperConfiguration(map => { map.CreateMap<EnderecoViewModel, Endereco>(); });

            var model = Mapper.Map<EnderecoViewModel, Endereco>(endereco);

            if (ModelState.IsValid)
            {
                _app.Add(model);
                db.SaveChanges();
                return model.Id;
            }

            return 0;
        }

        // GET: Endereco/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endereco endereco = _app.GetById(id);
            if (endereco == null)
            {
                return HttpNotFound();
            }
            return View(endereco);
        }

        // POST: Endereco/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Cep,Estado,Cidade,Bairro,Rua,Numero")] EnderecoViewModel endereco)
        {

            new MapperConfiguration(map => { map.CreateMap<EnderecoViewModel, Endereco>(); });

            var model = Mapper.Map<EnderecoViewModel, Endereco>(endereco);

            if (ModelState.IsValid)
            {
                _app.Update(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(endereco);
        }

        // GET: Endereco/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endereco endereco = _app.GetById(id);
            if (endereco == null)
            {
                return HttpNotFound();
            }
            return View(endereco);
        }

        // POST: Endereco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            Endereco endereco = _app.GetById(id);
            _app.Remove(endereco);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Endereco/GetUltimoEnderecoCadastrado
        public JsonResult GetUltimoEnderecoCadastrado(string usuarioId)
        {
            var endereco = _app.GetUltimoEnderecoCadastrado(usuarioId);
            return Json(endereco, JsonRequestBehavior.AllowGet);
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
