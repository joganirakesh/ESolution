using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SampleConsoleApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private DateTimeUtils dateTimeUtils;
        [TestInitialize]
        public void Setup()
        {
            dateTimeUtils = new DateTimeUtils();
        }
        [TestMethod]
        public void AddDays_ShouldReturnCorrectDate()
        {
            // Arrange
            DateTime initialDate = new DateTime(2023, 1, 1);
            DateTime expectedDate = new DateTime(2023, 1, 6);

            // Act
            DateTime result = dateTimeUtils.AddDays(initialDate, 5);

            // Assert
            Assert.AreEqual(expectedDate, result);
        }
        [TestMethod]
        public void SubtractDays_ShouldReturnCorrectDate()
        {
            // Arrange
            DateTime initialDate = new DateTime(2023, 1, 10);
            DateTime expectedDate = new DateTime(2023, 1, 5);

            // Act
            DateTime result = dateTimeUtils.SubtractDays(initialDate, 5);

            // Assert
            Assert.AreEqual(expectedDate, result);
        }

        [TestMethod]
        public void DaysBetween_ShouldReturnCorrectNumberOfDays()
        {
            // Arrange
            DateTime startDate = new DateTime(2023, 1, 1);
            DateTime endDate = new DateTime(2023, 1, 10);

            // Act
            int result = dateTimeUtils.DaysBetween(startDate, endDate);

            // Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void AddDays_WithNegativeDays_ShouldReturnCorrectDate()
        {
            // Arrange
            DateTime initialDate = new DateTime(2023, 1, 10);
            DateTime expectedDate = new DateTime(2023, 1, 5);

            // Act
            DateTime result = dateTimeUtils.AddDays(initialDate, -5);

            // Assert
            Assert.AreEqual(expectedDate, result);
        }

        [TestMethod]
        public void SubtractDays_WithNegativeDays_ShouldReturnCorrectDate()
        {
            // Arrange
            DateTime initialDate = new DateTime(2023, 1, 5);
            DateTime expectedDate = new DateTime(2023, 1, 10);

            // Act
            DateTime result = dateTimeUtils.SubtractDays(initialDate, -5);

            // Assert
            Assert.AreEqual(expectedDate, result);
        }

        [TestMethod]
        public void DaysBetween_SameDate_ShouldReturnZero()
        {
            // Arrange
            DateTime date = new DateTime(2023, 1, 1);

            // Act
            int result = dateTimeUtils.DaysBetween(date, date);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
