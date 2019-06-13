function getCarrinhoSessionByUsuarioId(usuarioId) {
    $.ajax({
        type: 'GET',
        url: '/Carrinho/GetCarrinhoSessionByUsuarioId',
        contentType: "application/json; charset=utf-8",
        async: false,
        dataType: "json",
        data: {
            usuarioId: usuarioId
        },
        success: function (data) {
            carrinhoDoBanco = data;
        },
        error: function (xhr) {
            console.log(xhr.responseText);
        }
    })
}