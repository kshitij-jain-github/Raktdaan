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
    // Add the search icon inside the search input
    $('#myTable input')
        .addClass('form-control form-control-sm')
        .wrap('<div class="input-group"></div>')
        .parent()
        .prepend('<span class="input-group-text"  ><span class="fas fa-search text-danger " ></span></span>');

    $('.dt-search input')
        .addClass('form-control form-control-sm')
        .wrap('<div class="input-group"></div>')
        .parent()
        .prepend('<span class="input-group-text"><span class="fas fa-search text-danger" ></span></span>');
 
    
});

function loadDataTable() {
    dataTable = $('#myTable').DataTable({
         "ajax": {
            "url": "/Home/GetAll"
        },
        dom: 'lBfrtip', // Add 'f' to include the search input
        language: {
            search: '_INPUT_',
            searchPlaceholder: "Search records"
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
                            <a href="/home/donar_details?id=${data}" class="btn btn-danger btn-sm">
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
 