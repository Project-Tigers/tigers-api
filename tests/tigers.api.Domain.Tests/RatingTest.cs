using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Tigers.Domain.Catalog;
using System;
namespace tigers.api.Domain.Tests;

[TestClass]
public class RatingTests
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    [TestMethod]
    public void Can_Create_New_Rating()
    {
      // ARRANGE
      var rating = new Rating(1, "Mike", "Great fit!");
     
      // Act (empty)
  
      // Assert
      Assert.AreEqual(1, rating.Stars);
      Assert.AreEqual("Mike", rating.UserName);
      Assert.AreEqual("Great fit!", rating.Review);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Rating_With_Invalid_Stars()
    {
      // ARRANGE
      var rating = new Rating(0, "Mike", "Great fit!");
    }
}
