function ajaxCadastroEndereco(token, enderecoToModel) {
    $.ajax({
        url: '/Endereco/Create',
        type: 'POST',
        data: {
            __RequestVerificationToken: token,
            endereco: enderecoToModel
        },
        success: function (data) {
            alert("Endereço cadastrado com sucesso!")
            compraToModel.enderecoId = data
        },
        error: function () {
            alert("Erro ao cadastrar endereço, tente novamente")
        }
    })
}