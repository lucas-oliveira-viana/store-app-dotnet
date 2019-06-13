function colocarPopover(nome) {

    var content = $("#" + nome + "-error").text();

    if (content !== "") {
        $("." + nome + "-error").hide();

        $("#" + nome).attr("data-toggle", "popover").attr("data-content", content);

        $("[data-toggle='popover']").each(function () {
            $(this).popover('show');
        })
    } else {
        var popoverNumber = $("#" + nome).attr("aria-describedby").split(" ")[0];
        $("#" + popoverNumber).hide();
    }
}