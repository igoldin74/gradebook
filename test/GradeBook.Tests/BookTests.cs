using System;
using System.Collections.Generic;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(68.5);
            book.AddGrade(55.5);
            book.AddGrade(20.0);
            
            // act
            var result = book.GetStats();

            // assert
            Assert.Equal(68.5, result.High, 1);
            Assert.Equal(20.0, result.Low, 1);
            Assert.Equal(48, result.Average, 1); //3rd parameter is how many deciaml places we are comparing
            Assert.Equal('F', result.Letter); // avg. result of 48 corresponds to Letter grade 'F'
        }

        [Fact]
        public void CanLoopOverGrades()
        {
            var book = new Book("expected");
            book.AddGrade(10);
            book.AddGrade(20);
            book.AddGrade(30);
            Statistics actual = book.GetStats();
            Assert.Equal(actual.Average, 20);
            Assert.Equal(actual.Low, 10);
            Assert.Equal(actual.High, 30);

        }
    }
}
