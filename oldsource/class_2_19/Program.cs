//Start main
using System.Net;

const int MAX_BOOKS = 70;
string[] titles = new string[MAX_BOOKS];
string[] authors = new string[MAX_BOOKS];
int count = GetAllTitles(titles, authors);
PrintAllBooks(titles, authors, count);
SortByAuthors(titles, authors, count);

System.Console.WriteLine("\nAfter the sort");
PrintAllBooks(titles, authors, count);
//End main

static int GetAllTitles(string[] titles, string[] authors){
    int count = 0;
    System.Console.WriteLine("Enter the title. (stop to quit)");
    string userInput = Console.ReadLine();
    while(userInput.ToLower() != "stop" && count < 70){
        titles[count] = userInput;
        System.Console.WriteLine("Enter the author");
        authors[count] = Console.ReadLine();
        count++;
        System.Console.WriteLine("Enter the title. (stop to quit)");
        userInput = Console.ReadLine();
    }
    return count;
}

static void PrintAllBooks(string[] titles, string[] authors, int count){
    for(int i = 0; i < count; i++){
        System.Console.WriteLine($"{titles[i]} was written by {authors[i]}");
    }
}

static void SortByAuthors(string[] titles, string[] authors, int count){
    for(int i = 0; i < count - 1; i++){
        int min = 1;
        for(int j = 0; j < i + 1; j++){
            if(authors[min].CompareTo(authors[j]) > 0){
                min = j;
            }
        }
        if(min != i){
            Swap(titles, min, i);
            Swap(authors, min, i);
        }
    }
}

static void Swap(string[] myArray, int x, int y){
    string temp = myArray[x];
    myArray[x] = myArray[y];
    myArray[y] = temp;
}