using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore
{
    public class SampleData
    {
        public static void Initialize(BookContext context)
        {
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Name = "Martin Eden",
                        Author = "Jack London",
                        Price = 1800
                    },
                    new Book
                    {
                        Name = "Three comrades",
                        Author = "Erich Maria Remarque",
                        Price = 2200
                    },
                    new Book
                    {
                        Name = "The Master and Margarita",
                        Author = "Mikhail Bulgakov",
                        Price = 2000
                    },
                    new Book
                    {
                        Name = "To Kill a Mockingbird",
                        Author = "Harper Lee",
                        Price = 2200
                    },
                    new Book
                    {
                        Name = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        Price = 1800
                    },
                    new Book
                    {
                        Name = "Jane Eyre",
                        Author = "Charlotte Brontë",
                        Price = 2000
                    },
                    new Book
                    {
                        Name = "Crime and Punishment",
                        Author = "Fyodor Dostoevsky",
                        Price = 1800
                    },
                    new Book
                    {
                        Name = "One Flew Over the Cuckoo's Nest",
                        Author = "Ken Kesey",
                        Price = 2000
                    },
                    new Book
                    {
                        Name = " The Iliad",
                        Author = "Homer ",
                        Price = 2200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
