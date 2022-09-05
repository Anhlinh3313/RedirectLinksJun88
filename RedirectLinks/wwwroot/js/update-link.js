
$("#modal-btn-update-link").click(function () {
    let linkId = $("#link-id").val();
    let linkGroupId = $("#modal-link-group-id").val();
    let url = $("#modal-url").val();
    let linkOrder = $("#modal-link-order").val();

    if (linkGroupId && url && linkOrder) {
        let link = {
            Id: linkId,
            LinkGroupId: linkGroupId,
            Url: url,
            LinkOrder: linkOrder
        }
        $.ajax({
            method: "PUT",
            url: "/Admin/UpdateLink",
            data: link,
            success: function (response) {
                if (response.status == 1) {
                    toastr.success("Sửa link thành công!");
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