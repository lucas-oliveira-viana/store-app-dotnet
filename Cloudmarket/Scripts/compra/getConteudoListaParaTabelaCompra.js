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
            elemento.Preco +
            '</td>' +
            '</tr>'
    })

    return conteudo;
};