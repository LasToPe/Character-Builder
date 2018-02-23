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

function ShowRacialBonusSelector() {
    var choices = document.getElementsByName("race");
    var selected;
    for (var i = 0; i < choices.length; i++) {
        if (choices[i].checked) {
            selected = choices[i].id;
            break;
        }
    }
    if (selected == "Human" || selected == "Half elf" || selected == "Half orc") {
        document.getElementById("bonus-selector-container").style.display = "block";
    } else {
        document.getElementById("bonus-selector-container").style.display = "none";
    }
}

function SetRace() {
    var choices = document.getElementsByName("race");
    var selected;
    for (var i = 0; i < choices.length; i++) {
        if (choices[i].checked) {
            selected = choices[i].id;
            break;
        }
    }

    var bonus = document.getElementById("bonus-selector").value;

    $.ajax({
        url: "/Section/SetRace",
        data: {
            Race: selected,
            Bonus: bonus
        },
        success: function () {
            $("#body-container").load(location.href + "#inner-body");
        }
    });
}

function UpdateBasics() {
    //not working properly
    $.ajax({
        url: "/Section/UpdateBasics",
        data: {
            Name: document.getElementById("character-name"),
            Alignment: document.getElementById("alignment"),
            Age: document.getElementById("age")
        },
        success: function () {
            $("#body-container").load(location.href + "#inner-body");
        }
    });
}