var dataTable;
$(document).ready(function () {
    loadDataTable();

    // Apply the search
    $('#myTable thead .column-search').on('keyup change', function () {

        var column = $(this).data('column'); // Get the column index
        var value = $(this).val(); // Get the search value
        dataTable.column(column).search(value).draw();
     
    });

    // Prevent sorting when clicking on search inputs
    $('#myTable thead .column-search').on('click', function (e) {
        e.stopPropagation();

     });
});

function loadDataTable() {
    dataTable = $('#myTable').DataTable({
        "ajax": {
            "url": "/Home/GetAll"
        },
        "columns": [
            { "data": "full_Name" },
            { "data": "blood_group" },
            { "data": "city" },
            { "data": "state" },
            { "data": "country" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="w-75 btn-group" role="group">
                            <a href="/Product/Upsert?id=${data}" class="btn btn-danger btn-sm">
                                <i class="fa fa-pencil-square"></i> Get Contact
                            </a>
                        </div>
                    `;
                },
 
            }

        ],
     

        "paging": false, // Disable default paging
     });
} 