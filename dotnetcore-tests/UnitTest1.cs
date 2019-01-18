using System;
using System.Collections.Generic;
using System.Linq;
using dotnetcore_sample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnetcore_sample.Controllers; 

namespace dotnetcore_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void About()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.About() as ViewResult;

          // Assert
          Assert.AreEqual("Your application description page.", result.ViewData["Message"]);
        }

        [TestMethod]
        public void Contact()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.Contact() as ViewResult;

          // Assert
          Assert.AreEqual("Your contact page.", result.ViewData["Message"]);
        }

        [TestMethod]
        public void GenerateWarnings()
        {
            var result = generate_warnings<int>.ConvertAll(s => s.ToString(), new List<int>{ 1 });

            Assert.AreEqual(result.Single(), "1");
        }
        
        [TestMethod]
        public void FailingTest()
        {
            var result = generate_warnings<int>.ConvertAll(s => s.ToString(), new List<int>{ 1 });

            Assert.AreEqual(result.Single(), "2");
        }
    }
}
