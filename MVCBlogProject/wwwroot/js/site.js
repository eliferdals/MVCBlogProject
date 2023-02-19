$(document).ready(function () {
    GetWritersListPartial();
    GetOpenWriterCreationFormButtonPartial();
});

//Mevcut okul listesini _WriterListPartial a yazdırma
function GetWritersListPartial() {
    var myUrl = "/Writers/GetWritersListPartial";
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            $("#writersListPartial").html(response);
        }
    });
}

// Create butonunu getirme
function GetOpenWriterCreationFormButtonPartial() {
    var myUrl = "/Writers/GetOpenWriterCreationFormButtonPartial";
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            $("#openCloseWriterCreationFormButtonsPartial").html(response);
        }
    });
}

//Create butonundaki OpenCreationForm eventi tetikleniyor ve bu method çalışıyor ve form ekranı geliyor
function OpenCreationForm() {
    var myUrl = "/Writers/GetCreateWriterPartial";
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            GetCloseWriterCreationFormButtonPartial();
            $("#createWritersPartial").html(response);
            $("#tables").addClass("row");
            $("#writersListPartial").addClass("col");
            document.getElementById("updateWritersPartial").style.display = "none";
        }
    });
}

function OpenUpdateForm(id) {
    var myUrl = "/Writers/GetUpdateWriterPartial/" + id;
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            GetCloseWriterCreationFormButtonPartial();
            $("#updateWritersPartial").html(response);
            $("#tables").addClass("row");
            $("#writersListPartial").addClass("col");
            document.getElementById("createWritersPartial").style.display = "none";
        }
    });
}


// formun create butonuna tıklandığında AddWriterAJ() methodu tetikleniyor

function AddWriterAJ() {
    $("#fail").html("");
    var formdata = new FormData();
    formdata.append('name', $("#Name").val());
    var myfile = document.getElementById("formFile");

    if (myfile.files.length > 0) {
        formdata.append('image', myfile.files[0]);
    }

    var myUrl = "/Writers/AddWriter";

    if ($('#createWriterForm').valid()) {
        $.ajax({
            url: myUrl,
            type: "POST",
            data: formdata,
            processData: false,
            contentType: false,
            success: function (response) {
                if (response == "ok") {
                    GetWritersListPartial();
                }
                else {
                    $("#fail").append('<div class="alert alert-danger" role="alert">Error! Writer addition failed.</div>');
                }
            }
        });
    }
}


function UpdateWriterAJ(id) {
    $("#fail").html("");
    var formdata = new FormData();
    formdata.append('name', $("#Name").val());
    formdata.append('id', id);
    var myfile = document.getElementById("formFile");

    if (myfile.files.length > 0) {
        formdata.append('updateImage', myfile.files[0]);
    }


    var myUrl = "/Writers/UpdateWriter";

    $.ajax({
        url: myUrl,
        type: "POST",
        data: formdata,
        processData: false,
        contentType: false,
        success: function (response) {
            if (response == "ok") {
                GetWritersListPartial();
            }
            else {
                $("#fail").append('<div class="alert alert-danger" role="alert">Error! Writer addition failed.</div>');
            }
        }
    });
}


// Create neew- Close form buton dönüşümü
function GetCloseWriterCreationFormButtonPartial() {
    var myUrl = "/Writers/GetCloseWriterCreationFormButtonPartial";
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            $("#openCloseWriterCreationFormButtonsPartial").html(response);
        }
    });
}

// close form butonuna tıklandığında onClick eventi tetikleniyor
function CloseCreationForm() {
    GetOpenWriterCreationFormButtonPartial();
    $("#createWritersPartial").html("");
    $("#updateWritersPartial").html("");
    document.getElementById("createWritersPartial").style.display = "block";
    document.getElementById("updateWritersPartial").style.display = "block";
    $("#tables").removeClass("row");
    $("#writersListPartial").removeClass("col");
}



