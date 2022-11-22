$(document).ready(function () {
    $('#myTable').DataTable({
        'bProcessing': true,
        "sAjaxSource": "../php/users.php",
        'aoColumns': [{
                mData: 'id'
            },
            {
                mData: 'name'
            },
            {
                mData: 'username'
            }

        ]
    });
});