using System.Web.Mvc;
using System.Web.Script.Serialization;
using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Domain.Entities;
using Cloudmarket.Models;
using AutoMapper;
using Cloudmarket.Application.Interface;

namespace Cloudmarket.Web.Controllers
{
    public class CarrinhoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private readonly ICarrinhoSessionAppService _app;

        public CarrinhoController(ICarrinhoSessionAppService app)
        {
            _app = app;
        }

        // GET: Carrinho
        public ActionResult Index()
        {
            return View();
        }

        //POST: Carrinho/AdicionarNoCarrinho
        [HttpPost]
        public int AdicionarNoCarrinhoDaSessao([Bind(Include = "Id,UsuarioId,CodigoProduto,Quantidade")] CarrinhoSessionViewModel carrinhoSessionVm)
        {
            if (ModelState.IsValid)
            {
                new MapperConfiguration(map => { map.CreateMap<CarrinhoSessionViewModel, CarrinhoSession>(); });

                var carrinhoSession = Mapper.Map<CarrinhoSessionViewModel, CarrinhoSession>(carrinhoSessionVm);

                _app.Add(carrinhoSession);
                db.SaveChanges();
                return carrinhoSession.Id;
            }
            return 0;
        }

        //GET: Carrinho/GetCarrinhoSessionByUsuarioId
        public string GetCarrinhoSessionByUsuarioId(string usuarioId)
        {
            var list = _app.GetCarrinhoSessionByUsuarioId(usuarioId);
            var jsonSerializer = new JavaScriptSerializer();
            return jsonSerializer.Serialize(list);
        }

        //POST: Carrinho/Delete/5
        [HttpPost]
        public void Delete(int? id)
        {
            if (ModelState.IsValid)
            {
                CarrinhoSession carrinhoSession = _app.GetById(id);
                _app.Remove(carrinhoSession);
                db.SaveChanges();
            }
        }
    }
}
