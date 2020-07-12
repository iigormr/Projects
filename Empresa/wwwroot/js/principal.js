$(document).ready(function(){
    $("#cnpj").mask("00.000.000/0000-00")
    $("#cep").mask("00000-000")
    $(".real").mask("000.000.000.000.000,00", { reverse: true })
    $(".date").mask("00/00/0000")
})

$(".input").on("focus", function () {
    $(this).addClass("focus")
})

$(".input").on("blur", function () {
    if ($(this).val() === "") {
        $(this).css("transition", "0.5s")
        $(this).removeClass("focus")
    }
});