var dataTable;

$(document).ready(function () {
    loadDataTable();
});
 
function loadDataTable() {
    dataTable = $('#myTable').DataTable(
        {
        "ajax": {
            "url": "/Home/GetAll"
        },
        "columns": [
            { "data": "full_Name"  },
            { "data": "blood_group" },
            { "data": "city" },
            { "data": "state"},
            { "data": "country" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="w-75 btn-group" role="group">
                        <a href="/Product/Upsert?id=${data}"
                        class="btn btn-danger btn-sm">  <i class="fa fa-pencil-square"></i> Get Contact</a>
                     
					</div>
                        `
                },
                
            }
        ]
    });
}


Object.assign(DataTable.defaults, {
    paging: false,
});