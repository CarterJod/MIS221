// //Start main
string[] books = new string[50];

// books[0] = "Mistborn";
// books[1] = "Oathbringer";
// books[2] = "Words of radiance";
// books[3] = "Way of kings";

//System.Console.WriteLine(books[2]);

string userInput = "";
System.Console.WriteLine("Enter name of book, stop to stop");
userInput = Console.ReadLine();
int count = 0;
while(userInput != "stop"){
    books[count] = userInput;
    count++;
    System.Console.WriteLine("Enter name of book, stop to stop");
    userInput = Console.ReadLine();
}

for(int i = 0; i < 4; i++){
    System.Console.WriteLine(books[i]);
}

//int[] grades = new int[133];

// int min = 1000;
// int max = -1000;

// //Priming Read
// string userInput = GetGrade();

// //Condition Check
// while(userInput != "-1"){
//     try{
//         int grade = int.Parse(userInput);
//         if(grade < min){
//             min = grade;
//         }
//         if(grade > max)
//         {
//             max = grade;
//         }
//     } catch (Exception e){
//         System.Console.WriteLine(e.Message);
//     }
//     userInput = GetGrade();
// }

// System.Console.WriteLine("The range was " + max - min);
// //End main

// static string GetGrade(){
//     System.Console.WriteLine("Please enter the grade, -1 to stop");
//     return Console.ReadLine();
// }