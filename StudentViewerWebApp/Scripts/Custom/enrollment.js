var enrollmentProvider = {};

enrollmentProvider.getStudentEnrollments = function (getStudentEnrollmentsUrl) {
    $.ajax({
        url: getStudentEnrollmentsUrl,
        type: 'Get',
        success: function (data) {
            enrollmentProvider.populateDataTable(data);
        },
        error: function () {
            $("#enrollmentsList tbody").empty();
            $("#enrollmentsList > tbody:last").append("<tr><td colspan=2>No records found</td></tr>");
        }
    });
};

enrollmentProvider.populateDataTable = function (enrollments) {

    $("#enrollmentsList tbody").empty();
    $('#enrollmentsList').dataTable({
        "aaData": enrollments,
        "aoColumns": [
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return moment(data.EntryDate).format("L");
                },
                "sWidth": "auto"
            },
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return moment(data.ExitDate).format("L");
                },
                "sWidth": "auto"
            },
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return data.ExitReason;
                },
                "sWidth": "auto"
            }
        ]
    });
};