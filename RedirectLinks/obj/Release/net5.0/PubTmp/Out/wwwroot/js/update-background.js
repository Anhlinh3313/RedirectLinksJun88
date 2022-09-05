$("#btn-status").on("click", function () {
    let hadClass = $(this).hasClass("active-status");
    if (hadClass) {
        $(this).removeClass("active-status");
        $("#status").val("false");
    }
    else {
        $(this).addClass("active-status");
        $("#status").val("true");
    }
});

$("#update-btn-upload-background").click(function () {
    $("#update-background-file").click();
});

$("#update-background-file").change(function () {
    let file = document.getElementById("update-background-file").files[0];
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
                    $("#modal-background-container img").attr("src", response.data)
                    $("#update-background-url").val(response.data);
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

$("#modal-btn-update-background").click(function () {
    let id = $("#background-id").val();
    let backGroundImage = $("#update-background-url").val();
    let linkGroupId = $("#modal-link-group-id").val();
    let isShow = $("#status").val();

    if (backGroundImage && linkGroupId) {
        let background = {
            Id: id,
            LinkGroupId: linkGroupId,
            BackgroundImage: backGroundImage,
            IsShow: isShow
        }
        $.ajax({
            method: "PUT",
            url: "/Admin/UpdateBackground",
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