using AutoMapper;
using Cloudmarket.Web.Models;
using Cloudmarket.Domain.Entities;
using Cloudmarket.Models;

namespace Cloudmarket.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public void Configure()
        {
            var configProduto = new MapperConfiguration(cfg => {
                cfg.CreateMap<ProdutoViewModel, Produto>();
            });

            IMapper mapperProduto = configProduto.CreateMapper();
            ProdutoViewModel sourceProduto = new ProdutoViewModel();
            var destProduto = mapperProduto.Map<ProdutoViewModel, Produto>(sourceProduto);

            var configEndereco = new MapperConfiguration(cfg => {
                cfg.CreateMap<EnderecoViewModel, Endereco>();
            });

            IMapper mapperEndereco = configEndereco.CreateMapper();
            EnderecoViewModel sourceEndereco = new EnderecoViewModel();
            var destEndereco = mapperEndereco.Map<EnderecoViewModel, Endereco>(sourceEndereco);

            var configPagamento = new MapperConfiguration(cfg => {
                cfg.CreateMap<PagamentoViewModel, Pagamento>();
            });

            IMapper mapperPagamento = configPagamento.CreateMapper();
            PagamentoViewModel sourcePagamento = new PagamentoViewModel();
            var destPagamento = mapperPagamento.Map<PagamentoViewModel, Pagamento>(sourcePagamento);

            var configCompra = new MapperConfiguration(cfg => {
                cfg.CreateMap<CompraViewModel, Compra>();
            });

            IMapper mapperCompra = configCompra.CreateMapper();
            CompraViewModel sourceCompra = new CompraViewModel();
            var destCompra = mapperCompra.Map<CompraViewModel, Compra>(sourceCompra);

            var configCarrinhoSession = new MapperConfiguration(cfg => {
                cfg.CreateMap<CarrinhoSessionViewModel, CarrinhoSession>();
            });

            IMapper mapperCarrinhoSession = configCarrinhoSession.CreateMapper();
            CarrinhoSessionViewModel sourceCarrinhoSession = new CarrinhoSessionViewModel();
            var destCarrinhoSession = mapperCarrinhoSession.Map<CarrinhoSessionViewModel, CarrinhoSession>(sourceCarrinhoSession);
        }
    }
}