function mapearValoresCartao() {
    pagamento.tipoCartao = $("#TipoCartao :selected").text();
    pagamento.numeroCartao = $("#Numero").val();
    pagamento.nomeCartao = $("#NomeCartao").val();
    pagamento.validadeCartao = $("#Validade").val();
    pagamento.cvv == $("#Cvv").val();

    informacoesPagamentoToModel.tipoCartao = pagamento.tipoCartao;
    informacoesPagamentoToModel.numeroCartao = pagamento.numeroCartao;
    informacoesPagamentoToModel.nomeCartao = pagamento.nomeCartao;
    informacoesPagamentoToModel.validadeCartao = pagamento.validadeCartao;
    informacoesPagamentoToModel.cvv == pagamento.cvv;
}
