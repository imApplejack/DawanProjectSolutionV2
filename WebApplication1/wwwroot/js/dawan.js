$(document).ready(function () {
    $(".element-order-item .add-command-button").click(function (e) {
        console.log($(this).data())
        $.post("/Command/Add" + $(this).data().type + "/" + $(this).data().id, function (data) {
            $("#menu-commande-price").html(data);
        });
    });
});