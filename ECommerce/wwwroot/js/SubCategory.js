var dataTable;

$(document).ready(function () {
    loadDataTable();

});

function loadDataTable() {

    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/SubCategory/GetAll"
        },
        "columns": [
            { "data": "name", "width": "65%" },
            {
                "data": "id",
                "render": function(data) {
                    return `
                 <div class="text-center">
                     <a href="/Admin/SubCategory/Upsert/${data}" class="btn btn-success text-white" style="cursor: pointer">
                         <i class="fas fa-edit"></i> 
                     </a>
                     <a onclick=Delete("/Admin/SubCategory/Delete/${data}") class="btn btn-danger text-white" style="cursor: pointer">
                         <i class="fas fa-trash-alt"></i>
                     </a>
                 </div>

                          `;
                }, "width": "35%"
            }
        ]
    });

}

function Delete(url) {

    swal({
        title: "Silmek istediğinize emin misiniz?",
        text: "Verileriniz tekrar geri gelmeyecek!",
        icon: "warning",
        buttons: true,
        dangerMode: true

    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function(data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    } else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}