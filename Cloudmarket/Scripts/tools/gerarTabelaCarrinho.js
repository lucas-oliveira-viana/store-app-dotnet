let gerarTabelaCarrinho = () => {
    if (carrinhoExibido.length > 0) {
        let tabela = ' <table class="table" id="table-produto">' +
            '<thead>' +
            '<tr>' +
            '<th>' +
            'Nome' +
            '</th> ' +
            '<th>' +
            'Quantidade' +
            '</th> ' +
            '<th>' +
            'Preco' +
            '</th> ' +
            '<th>' +
            '</th> ' +
            '</tr>' +
            '</thead>' +
            '<tbody>' +
            '<tr>' +
            getConteudoListaParaTabela(carrinhoExibido);
            '</tr>' +
            '</tbody>' +
            '</table>'

        const divValorTotal = `<span class="valor-total-conteudo">Valor Total: R$ <span class="valor-total-bruto">${somarValorTotal(carrinhoExibido)}</span></span>`

        $("#tabela-carrinho-compra").append(tabela);
        $(".valor-total").append(divValorTotal);
    }
}

let somarValorTotal = (carrinhoExibido) => {
    let valorTotal = 0;
    carrinhoExibido.forEach(elemento => {
        valorTotal += elemento.Preco * elemento.Quantidade;
    })
    return valorTotal.toFixed(2);
}