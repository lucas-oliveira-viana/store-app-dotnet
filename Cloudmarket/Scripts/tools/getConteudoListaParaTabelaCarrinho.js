function getConteudoListaParaTabela(lista) {
    var conteudo = "";
    lista.forEach(elemento => {
        conteudo += '<tr class="posicao-' + elemento.Id + '">' +
            '<td>' +
            elemento.Nome +
            '</td>' +
            '<td class="quantidade-carrinho">' +
            elemento.Quantidade +
            '</td>' +
            '<td class="preco-carrinho">' +
            "R$ " + elemento.Preco.toString().replace(".", ",") +
            '</td>' +
            '<td>' +
            '<button class="btn-remover"> Remover </button>' + 
            '</td>' +
            '</tr>'
    })

    return conteudo;
};