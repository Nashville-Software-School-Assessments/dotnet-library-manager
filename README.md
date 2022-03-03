# Library Manager Assessment
### Learning Objectives
1. Assess your understanding of Chapters 1-12 of the C# curriculum
1. Introduce you to testing and test driven development

### Time Limit
Take no longer than 1.5 hours to complete this, get as far as you can.

### Instructions
1. Clone this repo
1. Unlike in the past, when we've erased the `Program` class and `Main` methods, leave them there this time.
1. In `Book`.cs, create a class called `Book` . Put it in the same namespace as the `Program` class.
1. The `Book` class should have Title, Author, PublishDate, and Genre properties.
1. In the main method, create an instance of the `Book` class, and save its value as a variable
1. using your instance of` Book`, print out its Title and Author to the Console in the format   '{Title}, by {Author}'
1. Create some more books and store them in a List
1. Iterate over that list of books, and print the title and author to the Console in the loop in the same format as in 6.
1. In `LibraryManager.cs` create a class in it called `LibraryManager`. Put the class in the same namespace as the other classes
1. Add a constructor method to your LibraryManager class that takes a string parameter that will represent the library's name.
1. Create a Name property in the `LibraryManager` class and use the the constructor to set the name parameter in the constructor as the value of `Name` when a new instance is created.
1. Create a private field in the `LibraryManager` class called `_books`. Its type will be `List<Book>` , and you can set it equal to an empty `List<Book>`
1. Write a method for the `LibraryManager` class that displays the books in an instance of `LibraryManager` using the same format as #6 and #8. Call your method `ListBooks`.
1. Write a method to add a book (called `AddBook`) to an instance of LibraryManagers _books field, it should take a parameter of type Book
1. Remove the code in the main method that you added in steps 6 and 8
1. Create a new instance of the `LibraryManager` class at the beginning of the Main method, pass the constructor a name for your library.
1. Write out "Welcome to the {Name} Library Management System!" to the console using your library instance.
1. Use the method your wrote to add books to add all of the books you created in steps 5 and 7 to your instance of `LibraryManager`'s `_books`
1. Use the method you wrote to list all of the books to print all of the books out to the console. 