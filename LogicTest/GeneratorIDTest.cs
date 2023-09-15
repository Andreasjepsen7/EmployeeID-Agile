using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeIdGenerator;

namespace EmployeeIdGenerator.Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void GenerateEmployeeId_WithValidNames_ReturnsCorrectValue()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doen";

            // Create an instance of the Logic class
            Logic logic = new Logic();

            // Act
            string employeeId = logic.GenerateEmployeeId(firstName, lastName);

            // Assert
            Assert.AreEqual("JohnDoen", employeeId.Substring(0, 8));
        }

        [TestMethod]
        public void GenerateEmployeeId_WithShortNames_ReturnsErrorMessage()
        {
            // Arrange
            string firstName = "Joh";
            string lastName = "Do";

            // Create an instance of the Logic class
            Logic logic = new Logic();

            // Act
            string employeeId = logic.GenerateEmployeeId(firstName, lastName);

            // Assert
            Assert.AreEqual("JohxDoxx", employeeId.Substring(0, 8));
            //Assert.AreEqual("Both first name and last name must have at least 4 characters.", employeeId);
        }
    }
}
