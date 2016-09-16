using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBook;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTest
    {
        [TestMethod]
        public void VariablesHoldAReference()
        {
            GradeBook.GradeBook g1 = new GradeBook.GradeBook();
            GradeBook.GradeBook g2 = g1;

            g1.Name = "Chads Gradebook";

            Assert.AreEqual(g1.Name, g2.Name);

        }

    }
}
