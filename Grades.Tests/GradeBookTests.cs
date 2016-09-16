using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBook;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {

        [TestMethod]
        public void ComputeHigestGrade()
        {
            GradeBook.GradeBook book = new GradeBook.GradeBook();
            book.Name = "Chad Gradebook";
            Console.WriteLine(book.Name);
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(90, result.HighestGrade);
            

        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook.GradeBook book = new GradeBook.GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(10, result.LowestGrade);
        }

    }
}
