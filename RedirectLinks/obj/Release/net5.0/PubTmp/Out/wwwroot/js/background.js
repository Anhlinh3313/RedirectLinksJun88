

$("#insert-btn-upload-background").click(function () {
    $("#insert-background-file").click();
});

$("#insert-background-file").change(function () {
    let file = document.getElementById("insert-background-file").files[0];
    if (file) {
        let formData = new FormData();
        formData.append("file", file);
        $.ajax({
            method: "POST",
            url: "/Upload/UploadFile",
            contentType: false,
            processData: false,
            data: formData,
            success: function (response) {
                if (response.status == 1) {
                    $("#background-container img").attr("src", response.data)
                    $("#insert-background-url").val(response.data);
                    toastr.success("Upload thành công!");
                }
                else {
                    toastr.error("Upload thất bại!");
                    console.log(response);
                }
            }
        });
    }
});

$("#btn-insert-background").click(function () {
    let backGroundImage = $("#insert-background-url").val();
    let linkGroupId = $("#link-group-id").val();
    let isShow = $("#status").val();

    if (backGroundImage && linkGroupId) {
        let background = {
            LinkGroupId: linkGroupId,
            BackgroundImage: backGroundImage,
            IsShow: isShow
        }
        $.ajax({
            method: "POST",
            url: "/Admin/InsertBackground",
            data: background,
            success: function (response) {
                if (response.status == 1) {
                    toastr.success("Thêm ảnh nền thành công!");
                    setTimeout(function () {
                        location.reload();
                    }, 1500);
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

$(".btn-update-background").click(function () {
    let backgroundId = $(this).attr("background-id");
    if (backgroundId) {
        $.ajax({
            method: "GET",
            url: "/Admin/UpdateBackground?id=" + backgroundId,
            success: function (response) {
                $("#update-background-modal-body").html(response);
                $("#update-background-modal").modal("show");
            }
        });
    }
});

$(".btn-delete-background").click(function () {
    let oke = confirm("Bạn có chắc chắn muốn xóa?");
    if (oke) {
        let backgroundId = $(this).attr("background-id");
        if (backgroundId) {
            $.ajax({
                method: "DELETE",
                url: "/Admin/DeleteBackground?id=" + backgroundId,
                success: function (response) {
                    if (response.status == 1) {
                        toastr.success("Xóa ảnh nền thành công!");
                        setTimeout(function () {
                            location.reload();
                        }, 1500);
                    }
                    else if (response.status == 0) {
                        toastr.error("Ảnh nền không tồn tại!");
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
    location.href = "/admin/background?linkGroupId=" + linkGroupId;
});

$("#page-size-select").change(function () {
    let pageSize = $(this).val();
    let linkGroupId = $("#hidden-link-group-id").val();
    if (pageSize) {
        location.href = "/admin/background?linkGroupId=" + linkGroupId + "&pageSize=" + pageSize;
    }
});