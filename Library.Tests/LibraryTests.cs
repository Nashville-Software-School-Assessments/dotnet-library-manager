using System;
using Xunit;
using System.Reflection;
using System.IO;

namespace Library.Tests
{
    public class LibraryTests
    {
        [Fact]
        public void TestBook()
        {
            var book = new Book
            {
                Title = "title",
                Author = "author",
                PublishDate = new DateTime(2022, 02, 02),
                Genre = "horror"
            };

            Assert.Equal("title", book.Title);
            Assert.Equal("author", book.Author);
            Assert.Equal(new DateTime(2022, 02, 02), book.PublishDate);
            Assert.Equal("horror", book.Genre);
        }

        [Fact]
        public void TestLibrary()
        {
            // Is there a Library Manager class?
            var library = new LibraryManager("Anoka County");
            // Does the class have a name property set in the constructor?
            Assert.Equal("Anoka County", library.Name);

            var info = library.GetType().GetField("_books", BindingFlags.NonPublic |BindingFlags.Instance);
            // Is there a private _books field?
            Assert.True(info != null);

            // Is that field of type List<Book>?
            Assert.Equal("System.Collections.Generic.List`1[Library.Book] _books",
            info.ToString());

            //can a book be added?
            library.AddBook(new Book {
                Title = "title",
                Author = "author",
                PublishDate = new DateTime(2022, 02, 02),
                Genre = "horror"
            });
            var output = new StringWriter();
            Console.SetOut(output);
            library.ListBooks();
            // does the ListBooks() print out the formatted book titles?
            Assert.Contains("title, by author", output.ToString());
        }
    }
}
