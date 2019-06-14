function tratamentoMensagensDeErro(nomesDosCampos) {
    $(document).ready(function () {

        $(".btn-default").click(function () {
            $(".form-horizontal").submit();
            nomesDosCampos.forEach(function (nome) {
                colocarPopover(nome);
            });
        });
        removerPopover(nomesDosCampos);

        nomesDosCampos.forEach(campo => {
            $("#" + campo).blur(function () {
                $("#" + campo + "-error").remove();
            })
        })
    })
}