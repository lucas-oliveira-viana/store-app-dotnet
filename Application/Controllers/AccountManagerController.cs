using Cloudmarket.Domain.Entities;
using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Cloudmarket.Controllers
{
    public class AccountManagerController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        private static ManageUserViewModel ToUserViewModel(ApplicationUser usuario)
        {
            return new ManageUserViewModel() { Id = usuario.Id, Nome = usuario.Nome, Email = usuario.Email, CPF = usuario.CPF, Rg = usuario.Rg, DataNascimento = usuario.DataNascimento };
        }

        // GET: AccountManager
        public ActionResult Index()
        {
            var usuariosVm = new List<ManageUserViewModel>();

            var usuariosDoBanco = db.Users.ToList();

            foreach (var usuario in usuariosDoBanco)
            {
                usuariosVm.Add(ToUserViewModel(usuario));
            }

            return View(usuariosVm);
        }

        //GET: AccountManager/Details/5
        public ActionResult Details(string id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var usuario = db.Users.Find(id);

            var usuarioVm = ToUserViewModel(usuario);

            if (usuarioVm == null)
            {
                return HttpNotFound();
            }

            return View(usuarioVm);
        }

        // GET: AccountManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var usuario = db.Users.Find(id);

            var usuarioVm = ToUserViewModel(usuario);

            if (usuarioVm == null)
            {
                return HttpNotFound();
            }
            return View(usuarioVm);
        }

        // POST: AccountManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var usuario = db.Users.Find(id);
            db.Users.Remove(usuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}