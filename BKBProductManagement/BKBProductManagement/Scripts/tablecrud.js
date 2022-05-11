$(function () {

    $(".editActionButton").click(function (e) {
        e.preventDefault();
        e.stopPropagation();

        var url = $(this).attr("href");

        $.ajax({
            url: url,
            cache: false,
            type: "GET",
            success: function (result) {
                $('#editModal .modal-body').html(result);
                $('#editModal').modal('show');
            }
        });
    });

    $(".deleteActionButton").click(function (e) {
        e.preventDefault();
        e.stopPropagation();

        var url = $(this).attr("href");

        $.ajax({
            url: url,
            cache: false,
            type: "GET",
            success: function (result) {
                alert("Item excluído com sucesso!");
                window.location.reload();
            }
        });
    });

});

function saveModal() {
    var url = $(".editModalUrl").attr("href");
    var data = $(".editForm").serialize();

    $.ajax({
        url: url,
        cache: false,
        data: data,
        type: "POST",
        success: function (result) {
            alert("Item alterado com sucesso!");
            window.location.reload();
        }
    });
}
