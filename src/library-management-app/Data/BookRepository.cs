using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using library_management_app.Models;

namespace library_management_app.Data
{
    public class BookRepository
    {
        //A list of books that is currently holding book data
        //TODO get this data from a database or api
        private static Book[] _books = new Book[]
        {

            new Book()
            {
                Id = 1,
                Title = "Sapiens: A Brief History of Humankind",
                DescriptionHtml = "\"A Brief History of Humankind is a book by Yuval Noah Harari first published in Hebrew in Israel in 2011," +
                " and in English in 2014. The book surveys the history of humankind from the evolution of archaic human species in the Stone Age up " +
                "to the twenty-first century, focusing on Homo sapiens.\" - Wikipedia",
                Author = new Author[]
                {
                    new Author { Name = "Yuval Noah Harari", Role = "Author" }
                },
                Favorite = false
            },

            new Book()
            {
                Id = 2,
                Title = "Cosmos: A Personal Voyage",
                DescriptionHtml = "\"Cosmos is a 1980 popular science book by astronomer and Pulitzer Prize-winning author Carl Sagan. Its 13 illustrated " +
                                    "chapters, corresponding to the 13 episodes of the Cosmos TV series, which the book was co-developed with and intended to complement," +
                                    " explore the mutual development of science and civilization.\" - Wikipedia",
                Author = new Author[]
                {
                    new Author { Name = "Carl Sagan", Role = "Author" },
                    new Author { Name = "Random House", Role = "Publisher" }
                },
                Favorite = false
            },

            new Book()
            {
                Id = 3,
                Title = "Astrophysics for People in a Hurry",
                DescriptionHtml = "\"Astrophysics for People in a Hurry is a 2017 " +
                "                   popular science book by Neil deGrasse Tyson, centering around a number of basic" +
                "                   questions about the universe.\" - Wikipedia",
                Author = new Author[]
                {
                    new Author { Name = "Neil deGrasse Tyson", Role = "Author" }
                },
                Favorite = true
            }
        };

      
        //return an array of books for the index page mainly.
        public Book[] GetBooks()
        {
            return _books;
        }

        //find a single instance of a book with a matching id.
        //TODO handle the error for when the id does not exist.
        public Book GetBook(int id)
        {
            Book bookToReturn = null;
            
            foreach(var book in _books)
            {
                if (book.Id == id)
                {
                    bookToReturn = book;
                    break;
                }

            }
            return bookToReturn;
        }
    }
}