

function getA1Rates(var1) {
    console.log(var1)
    $.ajax({
        type: "POST",
        URL: "/ExamController/Exam/",
        data: { id: $("input[id = '${var1}')]").val() },
        dataType: "json",
    });
}
//function createQuestionBody


