var assignmentProvider = {};

assignmentProvider.getStudentAssignments = function (getStudentAssignmentsUrl) {
    $.ajax({
        url: getStudentAssignmentsUrl,
        type: 'Get',
        success: function (data) {
            assignmentProvider.populateDataTable(data);
        },
        error: function () {
            $("#assignmentsList tbody").empty();
            $("#assignmentsList > tbody:last").append("<tr><td colspan=2>No records found</td></tr>");
        }
    });
};

assignmentProvider.populateDataTable = function (assignments) {

    $("#assignmentsList tbody").empty();
    $('#assignmentsList').dataTable({
        "aaData": assignments,
        "aoColumns": [
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return data.AssignmentName;
                },
                "sWidth": "auto"
            },
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return moment(data.DueDate).format("L");
                },
                "sWidth": "auto"
            },
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return data.MaxScore;
                },
                "sWidth": "auto"
            },
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    var completionDate = moment(data.CompletionDate);
                    return completionDate.isValid()?completionDate.format("L") : "";
                },
                "sWidth": "auto"
            },
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return data.ScoreEarned;
                },
                "sWidth": "auto"
            }
        ]
    });
};