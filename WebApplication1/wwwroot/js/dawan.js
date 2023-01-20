$(document).ready(function () {

    $(".element-order-item .add-command-button").click(function (e) {
        console.log($(this).data())
        $.post("/Command/Add" + $(this).data().type + "/" + $(this).data().id, function (data) {
            $("#menu-commande-price").html(data);
        });
    });



    $(".command-block a").click(function (e) {
        console.log($(this).data())
        var datascope = $(this).data()
        $.post("/Command/Remove" + $(this).data().type + "/" + $(this).data().id, function (data) {
            $("#" + datascope.type + "-command-block-" + datascope.id).remove()
            $("#menu-commande-price").html(data);
        });
    });


});



