//Ilość prób przed podaniem wyniku
var howManyTrials = 5;
//Zmierzone czasy reakcji
var reactionTimes = [];
//Rozpoczęcie pomiaru czasu
var trialStart = 0;
//Koniec pomiaru czasu
var trialEnd = 0;
//Licznik próby
var trialCounter = 0;
//Po jakim czasie ma się pojawić zielony przycisk
var randomTimer = 0;
//Resetowanie czasów reakcji
function ResetTimes(){
    for(var i=0; i<howManyTrials;i++){
        reactionTimes[i] = 0;
    }
}
//Rozpoczęcie odliczania do pomiaru czasu
function StartIdle(){
    document.getElementById("button").src = "images/buttonBlue.png";
    // Funkcja uruchomiona po kliknięciu - wywołanie funkcji FalseStart
    document.getElementById("button").onclick = function(){
        FalseStart();
    };
    if(trialCounter > howManyTrials-1){
        ResetTimes();
        trialCounter = 0;
        UpdateTable(0);
    }
    trialCounter++;
    randomTimer = Math.floor(Math.random()*1000 + 500);
    setTimeout(StartTimer, randomTimer);
}
//Rozpoczęcie pomiaru czasu reakcji
function StartTimer(){
    document.getElementById("button").src = "images/buttonGreen.png";
    document.getElementById("button").onclick = function(){ StopTimer();};
    // Aktualny czas
    trialStart = new Date().getTime();
}
//Ukaranie za naciśniecie przycisku zbyt szybko
function FalseStart(){
    trialStart = new Date().getTime()-1000;
    StopTimer();
}
//Zakończenie pomiaru czasu reakcji i wyświetlenie wyniku
function StopTimer(){
    document.getElementById("button").src = "images/buttonRed.png";
    document.getElementById("button").onclick = function(){ StartIdle(); };
    //Srednia 
    var average = 0;
    //Wyliczony czas
    trialEnd = new Date().getTime() - trialStart;
    reactionTimes[trialCounter-1]=trialEnd;

    UpdateTable(average);

    if(trialCounter > howManyTrials - 1){
        for(var i = 0; i<trialCounter;i++){
            average +=reactionTimes[i];
        }
        //Wyliczenie średniej wyników
        average = Math.round(average/howManyTrials);
        
        UpdateTable(average);
        alert("Your average reaction time: "+average + " ms");
    }
}
//Odświerzenie tabeli z wynikami
function UpdateTable(average){
    document.getElementById("timesTable").innerHTML = "";
    document.getElementById("timesTable").innerHTML+=
        '<tr>' + 
        '<th> Attempt No. </th>' +
        '<th> Reaction time </th>' +
        '</tr>';
    //Wyświetlenie czasu reakcji
    for(var i = 0; i< howManyTrials; i++){
        document.getElementById("timesTable").innerHTML += '<tr>' +
            '<td> Attempt ' + (i + 1) + ' </td>' + 
            '<td>' + 
            reactionTimes[i] + 
            ' ms </td>' + 
            '</tr>';
    }

    document.getElementById("timesTable").innerHTML +=
        '<tr>' + 
        '<td> Average </td>' + 
        '<td> ' + average + ' ms </td>' + 
        '</tr>';
}