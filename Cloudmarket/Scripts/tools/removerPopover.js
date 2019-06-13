function removerPopover(listaDeCampos) {
    listaDeCampos.forEach(function (campo) {
        $("#" + campo).click(function () {
            const popoverNumber = $("#" + campo).attr("aria-describedby").split(" ")[0];
            $("#" + popoverNumber).hide();
        })
    })
}
