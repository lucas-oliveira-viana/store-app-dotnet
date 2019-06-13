$(document).ready(function () {

    function limpa_formulário_Cep() {

        $("#Rua").val("");
        $("#Bairro").val("");
        $("#Cidade").val("");
        $("#Estado").val("");
        $("#ibge").val("");
    }

    function executaApiCorreios() {
        var Cep = $("#Cep").val().replace(/\D/g, '');
        if (Cep != "") {

            var validaCep = /^[0-9]{8}$/;

            if (validaCep.test(Cep)) {

                $("#Rua").val("...");
                $("#Bairro").val("...");
                $("#Cidade").val("...");
                $("#Estado").val("...");
                $("#ibge").val("...");

                $.getJSON("https://viaCep.com.br/ws/" + Cep + "/json/?callback=?", function (dados) {
                    if (!("erro" in dados)) {

                        $("#Rua").val(dados.logradouro);
                        $("#Bairro").val(dados.bairro);
                        $("#Cidade").val(dados.localidade);
                        $("#Estado").val(dados.uf);
                        $("#ibge").val(dados.ibge);

                        permissaoCadastrarEndereco = true;
                    }
                    else {
                        limpa_formulário_Cep();
                        alert("CEP não encontrado.");
                    }
                });
            }
            else {
                limpa_formulário_Cep();
                alert("Formato de CEP inválido.");
                permissaoCadastrarEndereco = false;
            }
        }
        else {
            limpa_formulário_Cep();
        }
    }

    $("#Cep").blur(function () {
        executaApiCorreios();
    })
});