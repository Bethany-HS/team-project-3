using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.Tests
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void TestForVaccinations()
        {
            Pet pet = new Pet("Spot", "dog");

            string testForRabies = "Rabies";

            Assert.AreEqual(testForRabies, pet.ListVaccinations());
        }
    }
}
