let carrinhoDoBanco = [];
let carrinhoExibido = [];
let produtoExibido = {};

$(document).ready(function () {

    getCarrinhoSessionByUsuarioId(usuarioId);

    carrinhoDoBanco.forEach(prod => {
        if (prod.CodigoProduto !== "0") {

            produtoExibido = {};

            getProdutoByCodigo(prod.CodigoProduto);

            produtoExibido.Nome = produto.Nome;
            produtoExibido.Quantidade = prod.Quantidade;
            produtoExibido.Preco = produto.Preco;
            produtoExibido.Id = prod.Id;

            carrinhoExibido.push(produtoExibido);
        }

        gerarTabelaCarrinho();
    })

    if (carrinhoExibido.length == 0) {
        $("#tabela-carrinho-compra").append(`<p class="carrinho-vazio"> Você ainda não possui nenhum produto no carrinho! :(</p>`)
        $("#comprar").hide();
    }

    $(".btn-remover").click(function () {
        const trDesseBotao = $(this).parent().parent()[0];

        trDesseBotao.remove();

        const posicaoDoElemento = trDesseBotao.className.substring(8);

        $.ajax({
            type: 'POST',
            url: `/Carrinho/Delete/${posicaoDoElemento}`,
            contentType: "application/json; charset=utf-8",
            async: false,
            success: function () {
                alert("Produto removido do carrinho com sucesso!")
            },
            error: function (xhr, err) {
                alert("Ocorreu um erro ao remover o produto do carrinho!")
            }
        })
    })

    $("#comprar").click(function () {
        window.location.href="Compra/Create"
    })
})
