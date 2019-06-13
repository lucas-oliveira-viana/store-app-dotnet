function transicaoEntreItens(itemAtual, proximoItem) {
    $(itemAtual).fadeOut(500);
    $(itemAtual).promise().done(function () {
        $(proximoItem).fadeIn(500);
    });
}