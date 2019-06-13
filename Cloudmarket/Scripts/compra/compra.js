$(document).ready(function () {
    ocultarOutrasFases();
})

let carrinhoDoBanco = [];
getCarrinhoSessionByUsuarioId(usuarioId);
carrinhoExibido = [];
produtoExibido = {};

carrinhoDoBanco.forEach(prod => {
    if (prod.CodigoProduto !== "0") {
        produtoExibido = {};
        getProdutoByCodigo(prod.CodigoProduto);
        produtoExibido.Quantidade = prod.Quantidade;
        produtoExibido.Nome = produto.Nome;
        produtoExibido.Preco = produto.Preco;
        produtoExibido.Id = produto.Id;
        produtoExibido.carrinhoSessionId = prod.Id;
        carrinhoExibido.push(produtoExibido);
    }
})

gerarTabelaCompra();

const endereco = {
    usuarioId: usuarioId
};
const pagamento = {};
const compra = {
    produtos: carrinhoExibido
};

let carrinhoArray = [];
let carrinhoToModel = {};


carrinhoExibido.forEach(prod => {
    carrinhoToModel = {};
    carrinhoToModel.produtoId = prod.Id;
    carrinhoToModel.quantidade = prod.Quantidade;
    carrinhoArray.push(carrinhoToModel);
})

const informacoesPagamentoToModel = {};

const compraToModel = {
    usuarioId: usuarioId,
    produtosCarrinho: carrinhoArray
};

const token = $('input[name="__RequestVerificationToken"]').val();

$(".btn-endereco").click(function () {

    if (!permissaoCadastrarEndereco) executaApiCorreios();
    
    mapearValoresEntradaEndereco();

    compra.endereco = endereco;

    const enderecoToModel = endereco;

    if (permissaoCadastrarEndereco) {
        ajaxCadastroEndereco(token, enderecoToModel);
        transicaoEntreItens(".form-endereco", ".form-pagamento");
    }
})

$(".btn-finalizar-compra").click(function () {

    pagamento.tipo = $("#Tipo :selected").text();

    if (pagamento.tipo == "Cartao") mapearValoresCartao();

    compra.pagamento = pagamento;

    const pagamentoToModel = {
        usuarioId: usuarioId,
        tipo: pagamento.tipo,
        informacoesPagamento: JSON.stringify(informacoesPagamentoToModel)
    }

    ajaxCadastroPagamento(token, pagamentoToModel);

    ajaxCadastroCompra(token, compraToModel);

    transicaoEntreItens(".form-pagamento", ".compra-finalizada");

    $(".detalhes-compra").append("<p>" + JSON.stringify(compra) + "</p>")
})