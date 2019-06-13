function ajaxCadastroPagamento(token, pagamentoToModel) {
    $.ajax({
        url: '/Pagamento/Create',
        type: 'POST',
        async: false,
        data: {
            __RequestVerificationToken: token,
            pagamento: pagamentoToModel
        },
        success: function (data) {
            compraToModel.pagamentoId = data
        },
        error: function () {
            alert("Erro ao cadastrar pagamento")
        }
    })
}