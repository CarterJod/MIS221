using class_3_6;

Book myBook = new Book();

myBook.SetTitle("Secret #5");
myBook.SetAuthor("Brandon Sanderson");
myBook.SetGenre("Fantasy");
myBook.SetPages(631);

Book yourBook = new Book("Oathbringer", "Sanderson", "Fantasy", 1200);

System.Console.WriteLine(myBook.ToString());

System.Console.WriteLine(yourBook.ToString());

Book[] myBooks = new Book[50];
myBooks[0] = myBook;
myBooks[1] = yourBook;
myBooks[2] = new Book("Seven Habits of Highly...", "Steven Covey", "Nonfiction", 250);
for(int i = 0; i < 3; i++){
    System.Console.WriteLine(myBooks[i].ToString());
}