// Write your JavaScript code.
function testFunction() {
    $.ajax({
        url: "/Section/TestAction"
    });
    $("#body-container").load(location.href + "#inner-body");
}