var indexProvider = {};

indexProvider.getAllStudents = function (getAllStudentsUrl) {
    $.ajax({
        url: getAllStudentsUrl,
        type: 'Get',
        success: function (data) {
            indexProvider.populateDataTable(data);
        },
        error: function () {
            $("#studentList tbody").empty();
            $("#studentList > tbody:last").append("<tr><td colspan=2>No records found</td></tr>");
        }
    });
};

indexProvider.populateDataTable = function (students) {

    $("#studentList tbody").empty();
    $('#studentList').dataTable({
        "aaData": students,
        "aoColumns": [
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return data.StudentId;
                },
                "sWidth": "auto"
            },
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return data.FirstName;
                },
                "sWidth": "auto"
            },
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return data.LastName;
                },
                "sWidth": "auto"
            },
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return data.Grade;
                },
                "sWidth": "auto"
            },
            {
                "mData": null,
                "bSortable": true,
                "mRender": function (data, type, full) {
                    return data.SchoolName;
                },
                "sWidth": "auto"
            },
             {
                 "mData": null,
                 "bSortable": false,
                 "mRender": function (data, type, full) {
                     return indexProvider.AssignmentUrl.replace("_studentId", data.StudentId);
                 },
                 "sWidth": "auto"
             },
              {
                  "mData": null,
                  "bSortable": false,
                  "mRender": function (data, type, full) {
                      return indexProvider.EnrollmentUrl.replace("_studentId", data.StudentId);
                  },
                  "sWidth": "auto"
              }
       ]
    });
};