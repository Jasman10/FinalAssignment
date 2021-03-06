﻿using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalAssignment;

namespace UnitTestProjectProgram
{
    [TestClass]
    public class CircleTest
    {
        int texturestyle;
        Brush bb;

        Color c1 = Color.Black;

        public CircleTest()
        {

        }


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            var c = new FinalAssignment.Circle();
            int x = 200, y = 200, size = 100, size1 = 100;
            c.set(texturestyle, bb, c1, x, y, size, size1);
            Assert.AreEqual(200, x);
        }
    }
}
