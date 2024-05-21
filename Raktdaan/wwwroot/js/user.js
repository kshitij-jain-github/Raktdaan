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
  
    // Handle click event for the Stripe buy button
    $(document).on('click', '.stripe-buy-button', function (e) {
        e.preventDefault();
        var donorId = $(this).data('id');

    /*    // Create a Checkout Session with the selected price
        $.ajax({
            url: '/Payment/CreateCheckoutSession',
            method: 'POST',
            data: { donorId: donorId },
            success: function (sessionId) {
                var stripe = Stripe('pk_test_51PHdjuSE21W6ukJqMCcDKgj1aCjwbuhtMeF8F3cxlCLx9FDIuNl8Zuk0wFbVm3Q4nvq1fMQIv9zPtkOUwgphEN8z00rzu2NonH');
                stripe.redirectToCheckout({ sessionId: sessionId });
            },
            error: function (error) {
                console.error("Error creating Stripe Checkout session:", error);
            }
        });*/
    });
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
                        <div >
                           <a class=" btn btn-danger btn-sm" href="/home/donar_details?id=${data}">Get Details</a>
                         </div>
            
                    `;

                },

            }

        ],

        "paging": false, // Disable default paging

    });
}




 