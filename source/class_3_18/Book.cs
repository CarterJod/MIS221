using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_3_18
{
    public class Book
    {
        private string title;
        private string author;        
        private int pages;
        private string genre;
        private static int count;

        public Book(string title, string author, int pages, string genre)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.genre = genre;
        }
        public Book(){}
        public string GetTitle(){
            return title;
        }
        public void SetTitle(string title){
            this.title = title;
        }
        public string GetAuthor(){
            return author;
        }
        public void SetAuthor(string author){
            this.author = author;
        }
        public int GetPages(){
            return pages;
        }
        public void SetPages(int pages){
            this.pages = pages;
        }
        public string GetGenre(){
            return genre;
        }
        public void SetGenre(string genre){
            this.genre = genre;
        }
        static public void SetCount(int count){
            Book.count = count;
        }
        static public int GetCount(){
            return Book.count;
        }
        public static void IncCount(){
            Book.count++;
        }
        public override string ToString()
        {
            return $"{title}\t{author}\t{pages}\t{genre}";
        }
        public string ToFile()
        {
            return $"{title}#{author}#{pages}#{genre}";
        }
    }
}