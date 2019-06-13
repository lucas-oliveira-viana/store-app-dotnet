function getProdutoByCodigo(codigoProduto) {
    $.ajax({
        type: "GET",
        url: '/ProdutoCliente/GetProdutoByCodigo',
        contentType: "application/json; charset=utf-8",
        data: { codigo: codigoProduto },
        dataType: "json",
        async: false,
        success: function (data) {
            produto = data;
        },
        error: function (xhr) {
            console.log(xhr.responseText);

            produto = undefined;

            $(".btn-comprar").append("<p>Ocorreu um erro ao adicionar um produto no carrinho!</p>")
        }
    })
}
