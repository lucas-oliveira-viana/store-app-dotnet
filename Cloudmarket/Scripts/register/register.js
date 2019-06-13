$(document).ready(function () {
    const nomesDosCampos = ["Nome", "DataNascimento", "Rg", "CPF", "Email", "Password", "ConfirmPassword"];

    $(".btn-default").click(function () {
        $(".form-horizontal").submit();
        nomesDosCampos.forEach(function (nome) {
            colocarPopover(nome);
        });
    });
    removerPopover(nomesDosCampos);
})