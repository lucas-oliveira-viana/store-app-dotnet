$(document).ready(function () {
    var dt = $('#table-produto-cli').dataTable({
        "lengthMenu": [12],
        "bLengthChange": false,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado",
            "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
            "sInfoFiltered": "(Filtrados de _MAX_ registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Exibindo _MENU_ registros por página",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "",
            "oPaginate": {
                "sNext": " Próximo",
                "sPrevious": "Anterior ",
                "sFirst": "Primeiro",
                "sLast": "Último"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            }
        }
    });
    manipulacoesTabela(dt);
});

function manipulacoesTabela(dataTable) {
    $("#table-produto-cli_filter").appendTo($(".sidebar-elements")).insertBefore($("#Categoria")).addClass("t-3");
    $("#table-produto-cli_filter input").attr("placeholder", "Pesquisar");

    $("#table-produto-cli_info").remove();

    $("#Categoria").change(function (e) {
        dataTable.api().columns(3).search(e.target.value).draw();
    })
}

function esconderElementosNaoUtilizados(listaElementosQueDevemSerEscondidos) {

    listaElementosQueDevemSerEscondidos.forEach(elemento => {
        $(elemento).hide();
    })
};

listaElementosQueDevemSerEscondidos = [".head-nome", ".head-preco", ".head-codigo", ".head-img", ".head-categoria", ".body-categoria"]

esconderElementosNaoUtilizados(listaElementosQueDevemSerEscondidos);

(function aplicarMascaraDePreco() {
    var quantidadeDeProdutos = $(".display-preco").length;
    for (var produto = 0; produto < quantidadeDeProdutos; produto++) {
        var precoProduto = $('.display-preco')[produto].childNodes[0].nodeValue
        var numerosSeparadosPorPonto = precoProduto.split(".");
        var antesDoPonto = numerosSeparadosPorPonto[0];
        var depoisDoPonto = numerosSeparadosPorPonto[1];

        if (antesDoPonto.length >= 4) {
            antesDoPonto = antesDoPonto.substring(0, 1) + "." + antesDoPonto.substring(1);
        }

        $('.display-preco')[produto].childNodes[0].nodeValue = "R$ " + antesDoPonto + "," + depoisDoPonto;
    }
}());