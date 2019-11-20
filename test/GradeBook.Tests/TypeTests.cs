using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CSharpCanPassByRef()
        {
            // arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name"); // "ref" tells this method to use reference to the object rather than value
            // act
        

            // assert
            Assert.Equal("New Name", book1.Name);

        }

        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            // arrange
            var x = GetInt();
            SetInt(x);
            // act  
            // assert
            Assert.Equal(3, x);

        }
        private void SetInt(int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }


        private void GetBookSetName(ref Book book, string name) // "ref" tells this method to use reference to the object rather than value
        {
            book = new Book(name);
        }


        [Fact]
        public void CSharpIsPassByValue()
        {
            // arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            // act
        

            // assert
            Assert.Equal("Book 1", book1.Name);

        }
        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }


        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            // act
        

            // assert
            Assert.Equal("New Name", book1.Name);

        }
                private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObj()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // act
        

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

         [Fact]
        public void TwoVarsCanRefSameObj()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // act
        

            // assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }

    }
}
