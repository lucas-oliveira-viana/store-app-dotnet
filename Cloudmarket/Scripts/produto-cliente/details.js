var carrinho = [];
var produto = {};

function colocaInformacoesDoProdutoNoBancoTemporariamente(codigoProduto) {
    $("#adicionar-carrinho").click(function () {

        if (usuarioId == "") window.location.href = "../../Account/Login"

        getProdutoByCodigo(codigoProduto);

        if (produto !== undefined) {

            produto.quantidade = quantidadeToInt;

            carrinho.push(produto);

            inserirNoCarrinhoTemporario(carrinho);

            $(".btn-comprar").append("<p>Produto adicionado ao carrinho!</p>")
        }
    })
}

function inserirNoCarrinhoTemporario(carrinho) {
    carrinho.forEach(produto => {
        carrinhoSession = {
            usuarioId: usuarioId,
            codigoProduto: produto.Codigo,
            quantidade: produto.quantidade
        }

        $.ajax({
            type: "POST",
            url: '/Carrinho/AdicionarNoCarrinhoDaSessao',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(carrinhoSession),
            dataType: "json",
            async: false,
            success: function (data) {
                carrinhoSession.id = data;
            },
            error: function (xhr) {
                console.log(xhr.responseText);
            }
        })
    })
}

colocaInformacoesDoProdutoNoBancoTemporariamente($(".codigo-produto").text().trim());

(function aplicarMascaraDePreco() {
    var precoProduto = $('.preco').text();
    var numerosSeparadosPorPonto = precoProduto.split(".");
    var antesDoPonto = numerosSeparadosPorPonto[0];
    var depoisDoPonto = numerosSeparadosPorPonto[1];

    if (antesDoPonto.trim().length >= 4) {
        antesDoPonto = antesDoPonto.trim().substring(0, 1) + "." + antesDoPonto.trim().substring(1);
    }

    $('.preco').text("R$ " + antesDoPonto + "," + depoisDoPonto);
}());

var quantidadeProdutoText = $(".quantidade-view").text();
var quantidadeToInt = parseInt(quantidadeProdutoText);

(function escolherQuantidadeProduto() {
    var quantidadeEstoqueText = $(".estoque-qtd").text();
    var quantidadeEstoqueToInt = parseInt(quantidadeEstoqueText);

    $(".btn-quantidade-add").click(function () {
        if (quantidadeToInt < quantidadeEstoqueToInt) {
            quantidadeToInt++;
            $(".quantidade-view").text(quantidadeToInt.toString());
        }
    })

    $(".btn-quantidade-subtr").click(function () {
        if (quantidadeToInt > 0) {
            quantidadeToInt--;
            $(".quantidade-view").text(quantidadeToInt.toString());
        }
    })
}());