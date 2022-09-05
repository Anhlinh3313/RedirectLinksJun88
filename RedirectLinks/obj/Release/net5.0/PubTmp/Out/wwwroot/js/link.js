
$("#btn-insert-link").click(function () {
    let linkGroupId = $("#link-group-id").val();
    let url = $("#url").val();
    let linkOrder = $("#link-order").val();

    if (linkGroupId && url && linkOrder) {
        let link = {
            LinkGroupId: linkGroupId,
            Url: url,
            LinkOrder: linkOrder
        }
        $.ajax({
            method: "POST",
            url: "/Admin/InsertLink",
            data: link,
            success: function (response) {
                if (response.status == 1) {
                    toastr.success("Thêm mới link thành công!");
                    setTimeout(function () {
                        location.reload();
                    }, 1500);
                }
                else if (response.status == 0) {
                    toastr.error("Link đã tồn tại!");
                }
                else {
                    toastr.error(response.message);
                    console.log(response);
                }
            }
        });
    }
    else {
        toastr.error("Vui lòng nhập đủ thông tin!");
    }
});

$(".btn-update-link").click(function () {
    let linkId = $(this).attr("link-id");
    if (linkId) {
        $.ajax({
            method: "GET",
            url: "/Admin/UpdateLink?id=" + linkId,
            success: function (response) {
                $("#insert-link-modal-body").html(response);
                $("#insert-link-modal").modal("show");
            }
        });
    }
});

$(".btn-delete-link").click(function () {
    let oke = confirm("Bạn có chắc chắn muốn xóa?");
    if (oke) {
        let linkId = $(this).attr("link-id");
        if (linkId) {
            $.ajax({
                method: "DELETE",
                url: "/Admin/DeleteLink?id=" + linkId,
                success: function (response) {
                    if (response.status == 1) {
                        toastr.success("Xóa link thành công!");
                        setTimeout(function () {
                            location.reload();
                        }, 1500);
                    }
                    else if (response.status == 0) {
                        toastr.error("Link hiện không tồn tại!");
                    }
                    else {
                        toastr.error(response.message);
                        console.log(response);
                    }
                }
            });
        }
    }
});

$("#btn-search").click(function () {
    let linkGroupId = $("#link-group-for-search").val();
    location.href = "/admin/index?linkGroupId=" + linkGroupId;
});

$("#page-size-select").change(function () {
    let pageSize = $(this).val();
    let linkGroupId = $("#hidden-link-group-id").val();
    if (pageSize) {
        location.href = "/admin/index?linkGroupId=" + linkGroupId + "&pageSize=" + pageSize;
    }
});