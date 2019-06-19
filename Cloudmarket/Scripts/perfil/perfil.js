$.ajax({
    type: 'GET',
    url: '/Account/FindNomeById',
    contentType: "application/javascript; charset=utf-8",
    async: false,
    dataType: "json",
    data: {
        usuarioId: usuarioId
    },
    success: function (data) {
        $(".nome-completo-conteudo").append("<span>" + data + "<span>");

        var nome = data.split(" ");

        $(".msg").append(`<span class="hello-msg"> Olá, ${nome[0]}! :) </span>`);
    },
    error: function (xhr) {
        console.log(xhr.responseText);
    }
})

$.ajax({
    type: 'GET',
    url: '/Account/FindCpfById',
    contentType: "application/javascript; charset=utf-8",
    async: false,
    dataType: "json",
    data: {
        usuarioId: usuarioId
    },
    success: function (data) {
        $(".cpf-conteudo").append("<span>" + data + "<span>");
    },
    error: function (xhr) {
        console.log(xhr.responseText);
    }
})

$.ajax({
    type: 'GET',
    url: '/Account/FindRgById',
    contentType: "application/javascript; charset=utf-8",
    async: false,
    dataType: "json",
    data: {
        usuarioId: usuarioId
    },
    success: function (data) {
        $(".rg-conteudo").append("<span>" + data + "<span>");
    },
    error: function (xhr) {
        console.log(xhr.responseText);
    }
})

$.ajax({
    type: 'GET',
    url: '/Pagamento/GetUltimoCartaoCadastrado',
    contentType: "application/javascript; charset=utf-8",
    async: false,
    dataType: "json",
    data: {
        usuarioId: usuarioId
    },
    success: function (data) {
        $(".cartao-conteudo").append("<span>" + JSON.parse(data.InformacoesPagamento).numeroCartao + "<span>");
    },
    error: function (xhr) {
        console.log(xhr.responseText);
        $(".cartao-conteudo").append("<span> Erro ao encontrar cartão <span>");
    }
})

$.ajax({
    type: 'GET',
    url: '/Endereco/GetUltimoEnderecoCadastrado',
    contentType: "application/javascript; charset=utf-8",
    async: false,
    dataType: "json",
    data: {
        usuarioId: usuarioId
    },
    success: function (data) {
        $(".endereco-conteudo").append("<span>" + data.Rua + ", " + data.Numero + "<span>");
    },
    error: function (xhr) {
        console.log(xhr.responseText);
        $(".endereco-conteudo").append("<span> Erro ao encontrar endereço <span>");
    }
})

$.ajax({
    type: 'GET',
    url: '/Compra/GetCincoPrimeirasComprasIdByUsuarioId',
    contentType: "application/javascript; charset=utf-8",
    async: false,
    dataType: "json",
    data: {
        usuarioId: usuarioId
    },
    success: function (data) {
        data.forEach(data => $(".numeros").append(`<a class="numero-pedido pedido${data}" style="cursor:pointer"> N°` + data + `</a>`))
    },
    error: function (xhr) {
        console.log(xhr.responseText);
    }
})