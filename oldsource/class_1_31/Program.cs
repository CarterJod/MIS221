//Main
int exam1 = GetGrade();
DisplayResults(exam1);

//End Main

static int GetGrade(){
    System.Console.WriteLine("Please enter the grade");
    return int.Parse(Console.ReadLine());
}

static void DisplayResults(int grade){
    string userName = "Chase";
    System.Console.WriteLine($"Your grade on the exam was{grade} ");
    if(IsAnA(grade) && userName == "Chase"){
        System.Console.WriteLine("Great job, thats an A!");
    }
    else if(IsAB(grade) || userName == "Jeff"){
        System.Console.WriteLine("Good job, thats a B, you're doing well");
    }
    else if(IsAC(grade)){
        System.Console.WriteLine("Cs get degrees.");
    }
    else
    {
        System.Console.WriteLine("Keep working hard");
    }
}

static bool IsAnA(int grade){
    if(grade >= 90)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static bool IsAB(int grade){
    if(grade < 90 && grade >= 80)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static bool IsAC(int grade){
    if(grade < 80 && grade >= 70)
    {
        return true;
    }
    else
    {
        return false;
    }
}