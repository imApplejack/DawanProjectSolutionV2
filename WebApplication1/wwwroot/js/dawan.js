function MajCommandView() {


    $(".menu-commande-price").html($("#menu-commande-price").html());

    if ($("#menu-commande-price").html().trim() == "0") {
        $(".validate-command-empty").removeClass("d-none");
        $(".validate-command-ok").addClass("d-none");
    }
    else {
        $(".validate-command-empty").addClass("d-none");
        $(".validate-command-ok").removeClass("d-none");
    }

}


$(document).ready(function () {

    console.log("init")
    MajCommandView();


    $(".element-order-item .add-command-button").click(function (e) {
        console.log($(this).data())
        $.post("/Command/Add" + $(this).data().type + "/" + $(this).data().id, function (data) {
            $(".menu-commande-price").html(data);
        });
    });


    $(".command-block a").click(function (e) {
        console.log($(this).data())
        var datascope = $(this).data()
        $.post("/Command/Remove" + $(this).data().type + "/" + $(this).data().id, function (data) {
            $("#" + datascope.type + "-command-block-" + datascope.id).remove()
            $(".menu-commande-price").html(data);
            MajCommandView();
        });
    });
});



