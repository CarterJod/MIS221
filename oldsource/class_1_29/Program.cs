String userName = GetUserName();
SayHello(ref userName);
System.Console.WriteLine($"Back in Main. The value is {userName}");

int a = 10;
int b = 5;
Subtract(b, a);
Subtract(5, 10);

//End main
static string GetUserName(){
    System.Console.Write("Please enter your name ");
    string userInput = Console.ReadLine();
    return userInput;
}

static void SayHello(ref string userName){
    System.Console.WriteLine("Hello " + userName + ", how are you today?");
    userName = "Jeff";
    System.Console.WriteLine($"Still in SayHello(). The value is {userName}");
}

static void Subtract(int a, int b){
    System.Console.WriteLine(a - b);
}