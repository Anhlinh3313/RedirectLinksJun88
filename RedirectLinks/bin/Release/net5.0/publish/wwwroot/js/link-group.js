
$("#btn-insert-link-group").click(function () {
    let linkGroupName = $("#link-group-name").val();
    if (linkGroupName) {
        linkGroupName = linkGroupName.replace(/\s/g, '');
        let linkGroup = {
            LinkGroupName: linkGroupName
        }
        $.ajax({
            method: "POST",
            url: "/Admin/InsertLinkGroup",
            data: linkGroup,
            success: function (response) {
                if (response.status == 1) {
                    toastr.success("Thêm mới nhóm link thành công!");
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

$(".btn-delete-link-group").click(function () {
    let oke = confirm("Bạn có chắc chắn muốn xóa?");
    if (oke) {
        let linkGroupId = $(this).attr("link-group-id");
        if (linkGroupId) {
            $.ajax({
                method: "DELETE",
                url: "/Admin/DeleteLinkGroup?id=" + linkGroupId,
                success: function (response) {
                    if (response.status == 1) {
                        toastr.success("Xóa nhóm link thành công!");
                        setTimeout(function () {
                            location.reload();
                        }, 1500);
                    }
                    else if (response.status == 0) {
                        toastr.error("Nhóm link hiện không tồn tại!");
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

$(".btn-update-link-group").click(function () {
    let linkGroupId = $(this).attr("link-group-id");
    if (linkGroupId) {
        $.ajax({
            method: "GET",
            url: "/Admin/UpdateLinkGroup?id=" + linkGroupId,
            success: function (response) {
                $("#update-link-group-modal-body").html(response);
                $("#update-link-group-modal").modal("show");
            }
        });
    }
});

$("#btn-search").click(function () {
    let linkGroupName = $("#link-group-name-for-search").val();
    if (linkGroupName) {
        location.href = "/admin/linkgroup?linkGroupName=" + linkGroupName;
    }
    else {
        toastr.error("Vui lòng nhập tên nhóm link!");
    }
});

$("#page-size-select").change(function () {
    let pageSize = $(this).val();
    let linkGroupName = $("#hidden-link-group-name").val();
    if (pageSize) {
        location.href = "/admin/linkgroup?linkGroupName=" + linkGroupName + "&pageSize=" + pageSize;
    }
});