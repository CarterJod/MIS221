using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_3_18
{
    public class Menu
    {
        private BookHandler bookHandler;
        public Menu(BookHandler bookhandler){
            this.bookHandler = bookHandler;
        }
        public void MainMenu(){
            int userResponse = 0;
            while(userResponse != 1 && userResponse != 2){
                System.Console.WriteLine("1. Add Book");
                System.Console.WriteLine("2. Print Books");
                userResponse = int.Parse(Console.ReadLine());
            }
            MainRouteEm(userResponse);
        }
        private void MainRouteEm(int choice){
            if(choice == 1){
                bookHandler.AddBook();
            }
            else if(choice == 2){
                bookHandler.PrintAllBooks();
            }
        }
    }
}