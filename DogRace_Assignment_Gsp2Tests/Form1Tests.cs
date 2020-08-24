using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogRace_Assignment_Gsp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace_Assignment_Gsp2.Tests
{
    [TestClass()] 
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Runner runner = new Runner();
            int y=runner.jump();
            if (y > 10)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }
    }
}