using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_3_27
{
    public class Book
    {
        private string title;
        private string author;

        public Book(){

        }

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
        public virtual void Read(){
            System.Console.WriteLine("I am reading the paper");
        }
    }
}