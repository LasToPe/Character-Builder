// Write your JavaScript code.
function SetScores() {
    $.ajax({
        url: "/Section/SetScores",
        data: {
            Strength: document.getElementById("Strength").value,
            Dexterity: document.getElementById("Dexterity").value,
            Constitution: document.getElementById("Constitution").value,
            Intelligence: document.getElementById("Intelligence").value,
            Wisdom: document.getElementById("Wisdom").value,
            Charisma: document.getElementById("Charisma").value
        },
        success: function () {
            $("#body-container").load(location.href + "#inner-body");
        }
    });
    
}