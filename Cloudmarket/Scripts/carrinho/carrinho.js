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
    })

    gerarTabelaCarrinho();

    if (carrinhoExibido.length == 0) {
        pendurarMensagemCarrinhoVazio();
        $("#comprar").hide();
    }

    function pendurarMensagemCarrinhoVazio() {
        return $("#tabela-carrinho-compra").append(`<p class="carrinho-vazio"> Você ainda não possui nenhum produto no carrinho! :(</p>`);
    }

    $(".btn-remover").click(function () {

        const trDesseBotao = $(this).parent().parent()[0];
        
        const posicaoDoElemento = trDesseBotao.className.substring(8);

        function getAllPrecosDaTd() {
            let todosValoresDePreco = [];
            $(".preco-carrinho").each(function (e) {
                const conteudoQuantidadeTd = $(this).parent().children();
                const conteudoQuantidade = conteudoQuantidadeTd[1].innerHTML;
                const conteudoPrecoTd = $(this).text().replace(",", ".").split(" ")[1];
                todosValoresDePreco.push(parseInt(conteudoQuantidade) * parseFloat(conteudoPrecoTd));
            })
            return todosValoresDePreco;
        }

        if (getAllPrecosDaTd().length == 1) {
            $("#table-produto").remove();
            $(".valor-total-conteudo").remove();
            $("#comprar").remove();
            pendurarMensagemCarrinhoVazio();
        }

        function getValorProduto() {
            const quantidadeComprada = parseInt(trDesseBotao.childNodes[1].innerHTML);
            const valorDoProduto = trDesseBotao.childNodes[2].innerHTML.replace(",", ".").split(" ")[1];
            return quantidadeComprada * valorDoProduto;
        }

        let somaTodosProdutos = getAllPrecosDaTd().reduce((a, b) => a + b, 0);
        let novoValor = parseFloat(somaTodosProdutos) - getValorProduto();

        $(".valor-total-bruto").html(novoValor.toFixed(2).toString());

        trDesseBotao.remove();
    
        $.ajax({
            type: 'POST',
            url: `/Carrinho/Delete/${posicaoDoElemento}`,
            contentType: "application/json; charset=utf-8",
            async: false,
            success: function () {
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
