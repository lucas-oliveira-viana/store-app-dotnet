function gerarTabelaCarrinho() {
    if (carrinhoExibido.length > 0) {
        var tabela = ' <table class="table" id="table-produto">' +
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

        $("#tabela-carrinho-compra").append(tabela);
        }
    }