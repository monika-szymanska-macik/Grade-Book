using System;
using Xunit;
using System.Collections.Generic;

namespace GradeBook.Tests
{
    public class TypeTests
    { 

        public void Test1()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book 1, "New Name");
            Assert.Equal("New name", book1.Name);
        }
        public void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }
        public void CanSetTheNAmeFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book 1, "New Name");
            Assert.Equal("New name", book1.Name);
        }
        public void SetName(Book book, string name)
        {
            book.name = name;
        }
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
