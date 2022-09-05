
$("#modal-btn-update-link-group").click(function () {
    let id = $("#link-group-id").val();
    let linkGroupName = $("#modal-link-group-name").val();
    if (linkGroupName) {
        let linkGroup = {
            Id: id,
            LinkGroupName: linkGroupName
        }
        $.ajax({
            method: "PUT",
            url: "/Admin/UpdateLinkGroup",
            data: linkGroup,
            success: function (response) {
                if (response.status == 1) {
                    toastr.success("Sửa nhóm link thành công!");
                    setTimeout(function () {
                        location.reload();
                    }, 1500);
                }
                else if (response.status == 0) {
                    toastr.error("Nhóm link đã tồn tại!");
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