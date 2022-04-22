using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;

namespace TestValidation
{
    [TestClass]

    public class UnitTest1
    {
        List<ProductReview> productList;
        [TestInitialize]
        public void SetUp()
        {
            productList = new List<ProductReview>();
        }
        /// <summary>
        /// UC1--->Adding a Productreview details in list and returns the count
        /// </summary>
        [TestMethod]
        public void TestMethodForAddingDetailsInList()
        {
            int expected = 25;
            int actual = ProductReviewManager.AddingProductReview(productList);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC2--->Retrieve Top Three Records Whose Rating is High
        /// </summary>
        [TestMethod]
        public void TestMethodForRetrieveTopThreeRecord()
        {
            int expected = 3;

            var actual = ProductReviewManager.RetrieveTopThreeRating(productList);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC3-->Retrieve  records from list based on productid and rating > 3 
        /// </summary>
        [TestMethod]
        public void TestMethodForRetrieveRecordsBasedOnRatingAndProductId()
        {
            int[] expected = { 1, 1, 4, 9, 9, 1, 4 };
            var actual = ProductReviewManager.RetrieveRecordsBasedOnRatingAndProductId(productList);
            CollectionAssert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC4-->Retrived the count of productId
        /// </summary>
        [TestMethod]
        public void TestMethodForCountingProductId()
        {
            string expected = "1 3 2 4 3 4 4 2 9 2 5 3 7 1 10 1 12 1 14 1 18 1 13 1 19 1 ";
            string actual = ProductReviewManager.CountingProductId(productList);
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// UC5---->Retrieving the product id in list
        /// </summary>
        [TestMethod]
        public void TestMethodForProductId()
        {
            string expected = "1 2 3 2 1 2 4 9 3 5 7 9 10 1 5 3 12 14 18 13 2 4 19 3 5 ";
            string actual = ProductReviewManager.RetrieveOnlyProductIdAndReviews(productList);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC6--->Skip Top five records(Already 25 Records present in list)
        /// </summary>
        [TestMethod]
        public void TestMethodSkipTopFiveRecords()
        {
            int expected = 20;
            int actual = ProductReviewManager.SkipTopFiveRecords(productList);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC9-retrieve the records whose column islike has true using (DataTable)
        /// </summary>
        [TestMethod]
        public void TestMethodForReturnsOnlyIsLikeFieldAsTrue()
        {
            int expected = 18;
            int actual = ProductReviewManager.ReturnsOnlyIsLikeFieldAsTrue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForAverageRating()
        {
            double expected = 12.44;
            double actual = ProductReviewManager.AverageOfRating();
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethodForReturnsCountOfReviewMessageContainsGood()
        {
            int expected = 5;
            int actual = ProductReviewManager.ReturnsReviewMessageContainsGood();
            Assert.AreEqual(expected, actual);
        }
    }
}
