using AutoMapper;
using Cloudmarket.Web.Models;
using Cloudmarket.Domain.Entities;
using Cloudmarket.Models;

namespace Cloudmarket.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public void Configure()
        {
            var configProduto = new MapperConfiguration(cfg => {
                cfg.CreateMap<Produto, ProdutoViewModel>();
            });

            IMapper mapperProduto = configProduto.CreateMapper();
            Produto sourceProduto = new Produto();
            var destProduto = mapperProduto.Map<Produto, ProdutoViewModel>(sourceProduto);

            var configEndereco = new MapperConfiguration(cfg => {
                cfg.CreateMap<Endereco, EnderecoViewModel>();
            });

            IMapper mapperEndereco = configEndereco.CreateMapper();
            Endereco sourceEndereco = new Endereco();
            var destEndereco = mapperEndereco.Map<Endereco, EnderecoViewModel>(sourceEndereco);

            var configPagamento = new MapperConfiguration(cfg => {
                cfg.CreateMap<Pagamento, PagamentoViewModel>();
            });

            IMapper mapperPagamento = configPagamento.CreateMapper();
            Pagamento sourcePagamento = new Pagamento();
            var destPagamento = mapperEndereco.Map<Pagamento, PagamentoViewModel>(sourcePagamento);

            var configCompra = new MapperConfiguration(cfg => {
                cfg.CreateMap<Compra, CompraViewModel>();
            });

            IMapper mapperCompra = configCompra.CreateMapper();
            Compra sourceCompra = new Compra();
            var destCompra = mapperEndereco.Map<Compra, CompraViewModel>(sourceCompra);

            var configCarrinhoSession = new MapperConfiguration(cfg => {
                cfg.CreateMap<CarrinhoSession, CarrinhoSessionViewModel>();
            });

            IMapper mapperCarrinhoSession = configCarrinhoSession.CreateMapper();
            CarrinhoSession sourceCarrinhoSession = new CarrinhoSession();
            var destCarrinhoSession = mapperEndereco.Map<CarrinhoSession, CarrinhoSessionViewModel>(sourceCarrinhoSession);
        }
        
    }
}