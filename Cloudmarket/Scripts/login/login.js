$(document).ready(function () {
    const nomesDosCampos = ["Email", "Password"];

    $(".btn-default").click(function () {
        $(".form-horizontal").submit();
        nomesDosCampos.forEach(function (nome) {
            colocarPopover(nome);
        });
    });

    removerPopover(nomesDosCampos);
})