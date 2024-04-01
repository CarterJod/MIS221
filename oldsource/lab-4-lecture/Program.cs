using System.Runtime.InteropServices;

string userInput = GetMenuChoice();

while(userInput!= "2"){
    RouteEm(userInput);
    userInput = GetMenuChoice();
}

static string GetMenuChoice(){
    DisplayMenu();
    return Console.ReadLine();
}

static void DisplayMenu(){
    System.Console.WriteLine("1. Say Hello\n2. Exit");
}

static void RouteEm(string userInput){
    switch(userInput){
        case "1":
            SayHello();
            break;
        default:
            System.Console.WriteLine("Invalid input!");
            break;
    }
}

static void SayHello(){
    int numberOfHellos = GetNumberOfHellos();

    for(int i = numberOfHellos; i > 0; i--){
        System.Console.WriteLine("Hello!");
    }
}

static int GetNumberOfHellos(){
    System.Console.WriteLine("How many hellow would you like?");
    return int.Parse(Console.ReadLine());
}