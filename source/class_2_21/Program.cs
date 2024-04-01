// Start main
using System.Runtime.InteropServices;

const int MAX_BOOKS = 70;
string[] titles = new string[MAX_BOOKS];
string[] authors = new string[MAX_BOOKS];
int count = GetAllTitles(titles, authors);


PrintAllBooks(titles, authors, count);

System.Console.WriteLine("Enter the title that has the incorrect author");
bool isFixed = false;
while(!isFixed){
    try{
        int foundIndex = Find(titles, Console.ReadLine(), count);
        if(foundIndex == -1){
            throw new Exception("Book was not in the list :(");
        }

        UpdateBookAuthor(authors, foundIndex);

        isFixed = true;
    } catch(Exception e){
        System.Console.WriteLine(e.Message);
    }

}

//SortByAuthor(titles, authors, count);

System.Console.WriteLine("\nAfter the sort");

PrintAllBooks(titles, authors, count);

//end main

static int GetAllTitles(string[] titles, string[] authors){
int count = 0;

    System.Console.WriteLine("Enter the title. Stop to quit");
    string userInput = Console.ReadLine();

    while (userInput.ToLower() != "stop" && count < 70){
        titles[count] = userInput;
        System.Console.WriteLine("Enter the author");
        authors[count] = Console.ReadLine();
        count ++;

        System.Console.WriteLine("Enter the title. Stop to quit");
        userInput = Console.ReadLine();
    }
    return count;
}

static int Find(string[] titles, string searchVal, int count){
    for(int i = 0; i < count; i++){
        if(searchVal.ToLower() == titles[i].ToLower()){
            return i;
        }
    }
    return -1;
}

static void UpdateBookAuthor(string[] authors, int index){
    System.Console.WriteLine("Who is the correct author");
    authors[index] = Console.ReadLine();
}

static void PrintAllBooks(string[] titles, string[] authors, int count){
    for(int i = 0; i < count; i++){
        System.Console.WriteLine($"{titles[i]} written by {authors[i]}");
    }
}

static void SortByAuthor(string[] titles, string[] authors, int count){
    for(int i = 0; i < count - 1; i++){
        int min = i;
        for (int j = i + 1; j < count; j++){
            if(authors[min].CompareTo(authors[j]) > 0){
                min = j;
            }
        }
        if(min != i){
            Swaps(titles, min, i);
            Swaps(authors, min, i);
        }
    }
}

static void Swaps(string[] myArray, int x, int y){
    string temp = myArray[x];
    myArray[x] = myArray[y];
    myArray[y] = temp;

}