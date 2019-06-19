function getConteudoListaParaTabela(lista) {
    var conteudo = "";

    lista.forEach(elemento => {
        conteudo += '<tr class="posicao-' + elemento.carrinhoSessionId + '">' +
            '<td>' +
            elemento.Nome +
            '</td>' +
            '<td>' +
            elemento.Quantidade +
            '</td>' +
            '<td>' +
            "R$ " + elemento.Preco.toString().replace(".", ",") +
            '</td>' +
            '</tr>'
    })

    return conteudo;
};