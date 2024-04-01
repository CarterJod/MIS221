using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_3_18
{
    public class BookReport
    {
        private Book[] myBooks;

        public BookReport(Book[] myBooks){
            this.myBooks = myBooks;
        }
        public void PrintAllBooks(){
            for(int i = 0; i < Book.GetCount(); i++){
                System.Console.WriteLine(myBooks[i].ToString());
            }
        }
        public void BooksByGenre(){
            string curr = myBooks[0].GetGenre();
            int count = 1;

            System.Console.WriteLine($"{myBooks[0].ToString()}");

            for(int i = 1; i < Book.GetCount(); i++){
                if(curr == myBooks[i].GetGenre()){
                    System.Console.WriteLine(myBooks[i].ToString());
                    count++;
                }
                else{
                    ProcessBreak(curr, count, i);
                }
            }
            ProcessBreak(curr, count, Book.GetCount() - 1);
        }
        private void ProcessBreak(ref string curr, ref int count, int i){
            System.Console.WriteLine($"{curr}\t\t{count}");
            curr = myBooks[i].GetGenre();
            count = 1;
            System.Console.WriteLine(myBooks[i].ToString());
        }
        private void ProcessBreak(string curr, int count, int i){
            count++;
            System.Console.WriteLine(myBooks[i].ToString());
            System.Console.WriteLine($"{curr}\t\t{count}");
        }
    }
}