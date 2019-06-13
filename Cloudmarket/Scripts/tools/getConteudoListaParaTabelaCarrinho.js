function getConteudoListaParaTabela(lista) {
    var conteudo = "";
    lista.forEach(elemento => {
        conteudo += '<tr class="posicao-' + elemento.Id + '">' +
            '<td>' +
            elemento.Nome +
            '</td>' +
            '<td>' +
            elemento.Quantidade +
            '</td>' +
            '<td>' +
            elemento.Preco +
            '</td>' +
            '<td>' +
            '<button class="btn-remover"> Remover </button>' + 
            '</td>' +
            '</tr>'
    })

    return conteudo;
};