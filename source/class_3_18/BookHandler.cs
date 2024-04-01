using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_3_18
{   
    public class BookHandler
    {
        private Book[] myBooks;
        private BookFileHandler fileHandler;
        private BookReport bookReport;
        
        public BookHandler(){
            //Instantiate instance variables
            myBooks = new Book[100];
            fileHandler = new BookFileHandler(myBooks);
            bookReport = new BookReport(myBooks);

            //Populatre array of books
            fileHandler.GetAllBooks();

        }
        public void PrintAllBooks(){
            bookReport.PrintAllBooks();
        }

        public void SaveAllBooks(){
            fileHandler.SaveAllBooks();
        }
        public void AddBook(){
            Book newBook = new Book();
            System.Console.WriteLine("What's the title of your book?");
            newBook.SetTitle(Console.ReadLine());
            System.Console.WriteLine("Who's the author?");
            newBook.SetAuthor(Console.ReadLine());
            System.Console.WriteLine("How many pages?");
            try{
                newBook.SetPages(int.Parse(Console.ReadLine()));
            }
            catch (Exception e){
                System.Console.WriteLine("Invalid number of pages, setting page count to 0");
                newBook.SetPages(0);
            }
            System.Console.WriteLine("What's the genre?");
            newBook.SetGenre(Console.ReadLine());

            myBooks[Book.GetCount()] = newBook;
            Book.IncCount();
            SaveAllBooks();
        }
        public void SortByGenre(){
            for(int i = 0; i < Book.GetCount() - 1; i++){
                int min = 1;
                for(int j = i + 1; j < Book.GetCount(); j++){
                    if(myBooks[min].GetGenre().CompareTo(myBooks[j].GetGenre()) > 0){
                        min = j;
                    }
                }

                if(min != i){
                    Swap(min, i);
                }
            }
        }
        private void Swap(int x, int y){
            Book temp = myBooks[x];
            myBooks[x] = myBooks[y];
            myBooks[y] = temp;
        }
    }
}