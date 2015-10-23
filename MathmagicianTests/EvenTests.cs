using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class EvenTests
    {
        [[TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            EvenNumbers even = new EvenNumbers();
        }
    }
}
