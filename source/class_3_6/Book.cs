using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_3_6
{
    public class Book
    {
        private string title;
        private string author;
        private string genre;
        private int pages;

        public Book(string title, string author, string genre, int pages){
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.pages = pages;
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

        public string GetGenre(){
            return genre;
        }

        public void SetGenre(string genre){
            this.genre = genre;
        }

        public int GetPages(){
            return pages;
        }

        public void SetPages(int pages){
            this.pages = pages;
        }

        public override string ToString(){
            return $"{title}\t{author}\t{genre}\t{pages}";
        }
    }
}