
using NUnit.Framework;

using ContosoCrafts.WebSite.Pages.Product;

namespace UnitTests.Pages.Product.Read
{
    public class ReadTests
    {
        #region TestSetup
        public static ReadModel pageModel;

        [SetUp]
        public void TestInitialize()
        {
            pageModel = new ReadModel(TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup

        #region OnGet
        [Test]
        public void OnGet_Valid_Should_Return_Products()
        {
            // Arrange
            // Act
            pageModel.OnGet("Thomas_dog");
            // Assert
            Assert.AreEqual("Thomas - A Young male Mixed Breed Dog  available for Adoption", pageModel.Product.Name);
        }

        [Test]
        public void OnGet_Valid_Should_Return_Products_ToString()
        {
            // Arrange
            pageModel.OnGet("Thomas_dog");
            // Act
            string dogString = pageModel.Product.ToString();
            // Assert
            Assert.IsNotNull(dogString);
         }

        #endregion OnGet
    }
}