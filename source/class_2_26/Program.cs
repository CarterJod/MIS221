//Begin main
const int MAX_BOOKS = 100;

string[] titles = new string[MAX_BOOKS];
string[] authors = new string[MAX_BOOKS];
int[] pages = new int[MAX_BOOKS];
string[] genres = new string[MAX_BOOKS];

int count = GetAllBooks(titles, authors, pages, genres);

//PrintAllBooks(titles, authors, pages, genres, count);

SortBooks(titles, authors, pages, genres, count);
System.Console.WriteLine("After the sort");
PrintAllBooks(titles, authors, pages, genres, count);

System.Console.WriteLine("\nAbout to do report\n");

CountsByGenre(genres, count);



//SaveAllBooks(titles, authors, pages, genres, count);

//End main

static int GetAllBooks(string[] titles, string[] authors, int[] pages, string[] genres){
    int count = 0;
    
    StreamReader inFile = new StreamReader("books.txt");
    
    string line = inFile.ReadLine();
    
    while(line != null && count < MAX_BOOKS){
        string[] temp = line.Split('#');
        titles[count] = temp[0];
        authors[count] = temp[1];
        pages[count] = int.Parse(temp[2]);
        genres[count] = temp[3];
        count++;

        line = inFile.ReadLine();
    }
    
    inFile.Close();

    return count;
}

static void PrintAllBooks(string[] titles, string[] authors, int[] pages, string[] genres, int count){
    for(int i = 0; i < count; i++){
        System.Console.WriteLine($"{titles[i]}\t{authors[i]}\t{pages[i]}\t{genres[i]}");
    }   
}

static void SaveAllBooks(string[] titles, string[] authors, int[] pages, string[] genres, int count){
    StreamWriter outFile = new StreamWriter("books2.txt");
    
    authors[0] = "Brandon";

    for(int i = 0; i < count; i++){
        outFile.WriteLine($"{titles[i]}#{authors[i]}#{pages[i]}#{genres[i]}");
    }

    outFile.Close();
}

static void SortBooks(string[] titles, string[] authors, int[] pages, string[] genres, int count){
    for(int i = 0; i < count - 1; i++){
        int min = i;
        for(int j = i + 1; j < count; j++){
            if(genres[j].CompareTo(genres[min]) < 0){
                min = j;
            }
        }
        if(min != i){
            Swap(titles, min, i);
            Swap(genres, min, i);
            SwapInt(pages, min, i);
            Swap(authors, min, i);
        }
    }
}

static void Swap(string[] myArray, int x, int y){
    string temp = myArray[x];
    myArray[x] = myArray[y];
    myArray[y] = temp;
}

static void SwapInt(int[] myArray, int x, int y){
    int temp = myArray[x];
    myArray[x] = myArray[y];
    myArray[y] = temp;
}

static void CountsByGenre(string[] genres, int count){
    string curr = genres[0];
    int genreCount = 1;
    for(int i = 1; i < count; i++){
        if(curr == genres[i]){
            genreCount++;
        }
        else{
            ProcessBreak(ref curr, genres[i], ref genreCount);
        }
    }
    ProcessBreak(ref curr, genres[0], ref genreCount);
}
static void ProcessBreak(ref string curr, string newGenre, ref int genreCount){
    System.Console.WriteLine($"Genre count = {genreCount} for {curr}");
    curr = newGenre;
    genreCount = 1;
}