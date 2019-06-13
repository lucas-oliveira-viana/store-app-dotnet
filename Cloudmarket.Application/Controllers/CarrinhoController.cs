using Cloudmarket.Service;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Domain.Entities;

namespace Cloudmarket.Controllers
{
    public class CarrinhoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private CarrinhoSessionService service = new CarrinhoSessionService();

        // GET: Carrinho
        public ActionResult Index()
        {
            return View();
        }

        //POST: Carrinho/AdicionarNoCarrinho
        [HttpPost]
        public int AdicionarNoCarrinhoDaSessao([Bind(Include = "Id,UsuarioId,CodigoProduto,Quantidade")] CarrinhoSession carrinhoSession)
        {
            if (ModelState.IsValid)
            {
                db.CarrinhoSessions.Add(carrinhoSession);
                db.SaveChanges();
                return carrinhoSession.Id;
            }
            return 0;
        }

        //GET: Carrinho/GetCarrinhoSessionByUsuarioId
        public string GetCarrinhoSessionByUsuarioId(string usuarioId)
        {
            var list = service.GetCarrinhoSessionByUsuarioId(usuarioId);
            var jsonSerializer = new JavaScriptSerializer();
            return jsonSerializer.Serialize(list);
        }

        //POST: Carrinho/Delete/5
        [HttpPost]
        public void Delete(int? id)
        {
            if (ModelState.IsValid)
            {
                CarrinhoSession carrinhoSession = db.CarrinhoSessions.Find(id);
                db.CarrinhoSessions.Remove(carrinhoSession);
                db.SaveChanges();
            }
        }
    }
}
