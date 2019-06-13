function ajaxCadastroCompra(token, compraToModel) {
    $.ajax({
        url: '/Compra/Create',
        type: 'POST',
        data: {
            __RequestVerificationToken: token,
            compra: compraToModel
        },
        success: function () {
            alert("Compra efetuada com sucesso!")

            let produtosDoCarrinhoParaDeletar = [];

            $("tbody").find('> tr').each(function (e) {
                const nomeTr = $(this).attr('class')
                if (nomeTr !== undefined) {
                    produtosDoCarrinhoParaDeletar.push(nomeTr.substring(8));
                }
            })

            console.log(produtosDoCarrinhoParaDeletar);

            produtosDoCarrinhoParaDeletar.forEach(produto => {
                $.ajax({
                    type: 'POST',
                    url: `/Carrinho/Delete/${produto}`,
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

            console.log(produtosDoCarrinhoParaDeletar);

        },
        error: function () {
            alert("Erro ao comprar, tente novamente")
        }
    })
}