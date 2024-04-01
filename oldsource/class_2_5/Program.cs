//Begin main

//Priming read
int grade = 0;

//Condition check

//string letterGrade = GetLetterGrade(grade);
//DisplayMessage(letterGrade);

do {
    grade = GetGrade();
    string letterGrade = GetLetterGrade(grade);
    DisplayMessage(letterGrade);
} while(grade != -1);


//End main

static int GetGrade(){
    System.Console.WriteLine("Please enter your grade, enter -1 to stop");
    return int.Parse(Console.ReadLine());
}

static string GetLetterGrade(int grade){
    if(grade >= 90){
        return "A";
    }
    else if(grade >= 80){
        return "B";
    }
    else if(grade >= 70){
        return "C";
    }
    else{
        return "DNP";
    }
}

static void DisplayMessage(string letterGrade){
    switch(letterGrade){
        case "A":
            System.Console.WriteLine("Great job!!");
            break;
        case "B":
            System.Console.WriteLine("Good job");
            break;
        case "C":
            System.Console.WriteLine("Nice you pass");
            break;
        default:
            System.Console.WriteLine("Keep working hard");
            break;
    }
}

