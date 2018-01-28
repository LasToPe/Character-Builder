// Write your JavaScript code.
function testFunction() {
    $.ajax({
        url: "/Section/TestAction"
    });
    $("#testcontainer").load(location.href + " #testdiv");
}