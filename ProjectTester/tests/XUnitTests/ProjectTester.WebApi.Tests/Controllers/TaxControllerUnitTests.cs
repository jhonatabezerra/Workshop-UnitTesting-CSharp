using Microsoft.Extensions.Logging;
using Moq;
using ProjectTester.Domain.Models.Enum;
using ProjectTester.Domain.Models.Operations;
using ProjectTester.Services.Provider;
using ProjectTester.WebApi.Controllers;
using Xunit;

namespace ProjectTester.WebApi.Tests.Controllers
{
    public class TaxControllerUnitTests
    {
        private readonly TransactionProvider _transactionProvider;
        private readonly TaxController _taxController;
        private readonly Mock<ILogger<TaxController>> _loggerMock;

        public TaxControllerUnitTests()
        {
            _loggerMock = new Mock<ILogger<TaxController>>();
            _transactionProvider = new TransactionProvider();
            _taxController = new TaxController(_loggerMock.Object, _transactionProvider);
        }

        [Fact]
        public void GetAnimals_WhenCallApiController_ShouldReturnAnimalInstance()
        {
            // Arrange
            Operations operation = new()
            {
                Operation = OperationTypes.BUY,
                UnitCost = 1,
                Quantity = 1
            };

            // Act
            var result = _taxController.GetOperation();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.Operation, operation.Operation);
            Assert.Equal(result.UnitCost, operation.UnitCost);
            Assert.Equal(result.Quantity, operation.Quantity);
        }
    }
}