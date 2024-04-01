using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_3_18
{
    public class BookFileHandler
    {
        private Book[] myBooks;
        public BookFileHandler(Book[] myBooks){
            this.myBooks = myBooks;
        }
        public void GetAllBooks(){
            Book.SetCount(0);

            StreamReader inFile = new StreamReader("books.txt");

            string line = inFile.ReadLine();

            while(line != null){
                string[] temp = line.Split("#");
                myBooks[Book.GetCount()] = new Book(temp[0], temp[1], int.Parse(temp[2]), temp[3]);
                Book.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }
        public void SaveAllBooks(){
            StreamWriter outFile = new StreamWriter("books.txt");
            for(int i = 0; i < Book.GetCount(); i++){
                outFile.WriteLine(myBooks[i].ToFile());
            }
            outFile.Close();
        }
    }
}