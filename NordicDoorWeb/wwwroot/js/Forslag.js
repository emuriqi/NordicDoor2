var dataTable;

$(document).ready(function () {
   loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Forslag/GetAll"
        },
        "columns": [
            { "data": "forslagID", "width": "15%" },
            { "data": "ansattID", "width": "15%" },
            { "data": "tittel", "width": "15%" },
            { "data": "nyttForslag", "width": "15%" },
            { "data": "årsak", "width": "15%" },
            { "data": "mål", "width": "15%" },
            { "data": "løsning", "width": "15%" },
            { "data": "datoRegistrert", "width": "15%" },
            { "data": "frist", "width": "15%" },
            { "data": "imageUrl", "width": "15%" },
            { "data": "team", "width": "15%" },
            { "data": "ansavarlig", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="w-75 btn-group" role="group">
                        <a href="/Admin/Product/Upsert?id=${data}"
                        class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                        <a onClick=Delete('/Admin/Product/Delete/${data}')
                        class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
					</div>
                        `
                },
                "width": "15%"
            }
        ]
    });
}
