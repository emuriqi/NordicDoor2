var dataTable;

$(document).ready(function () {
   loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "Admin/Forslag/GetAll"
        },
        "columns": [
            { "data": "nyttForslag", "width": "15%" },
        ]
    });
}
