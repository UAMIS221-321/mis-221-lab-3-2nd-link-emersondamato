//Objective of this program: I would like to help the user determine what stadium to visit for a football game
//main


int enjoymentLevel = GetEnjoymentLevel();
string rateEnjoymentLevel = GetStadiumRecommendations(enjoymentLevel);
string game = GetGameRecommendations(rateEnjoymentLevel);
DisplayStadiumDetails(rateEnjoymentLevel, game);


// string stadiumRecommendation = GetStadiumRecommendations(enjoymentLevel);
// string gameDecision = GetGameRecommendations(stadiumRecommendation);
// DisplayEnjoymentLevel(stadiumRecommendation, gameDecision);

//end main

static int GetEnjoymentLevel(){
    System.Console.WriteLine("What is your enjoyment level?");
    System.Console.WriteLine("1. Boring \n 2. Average \n 3. Fun \n 4. Epic");
    int choice = int.Parse(Console.ReadLine());
    return choice;
}

static string GetStadiumRecommendations(int enjoymentLevel){
if (enjoymentLevel == 1){
    return("Neyland Stadium");
}
else if(enjoymentLevel == 2){
    return("Jordan-Hare Stadium");
}
else if(enjoymentLevel == 3){
    return("Tiger Stadium");
}
else if(enjoymentLevel == 4){
    return("Saban Field at Bryant-Denny Stadium");
}
else{
return "that input is invalid";
}

}

static string GetGameRecommendations(string stadium){
    if(stadium == "Neyland Stadium"){
        return "Tennesee vs. Kent State";
    }
    if(stadium == "Jordan-Hare Stadium"){
        return "Auburn vs. Kentucky";
    }
    if(stadium == "Tiger Stadium"){
        return "Clemson vs. Alabama";
    }
    if(stadium == "Saban Field at Bryant-Denny Stadium"){
        return "Alabama vs. Auburn";
    }
    else{
         return "that input is invalid";
    }
}
static void DisplayStadiumDetails(string stadium, string game){
    System.Console.WriteLine($"The best recommendation is {stadium} and your game is {game}");
}