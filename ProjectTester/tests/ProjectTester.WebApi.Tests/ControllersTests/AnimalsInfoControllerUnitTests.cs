using Microsoft.Extensions.Logging;
using Moq;
using ProjectTester.Domain.Models.Animals;
using ProjectTester.Services.Provider;
using ProjectTester.WebApi.Controllers;
using Xunit;

namespace ProjectTester.WebApi.Tests.ControllersTests
{
    public class AnimalsInfoControllerUnitTests
    {
        private readonly AnimalProvider _animalProvider;
        private readonly AnimalsInfoController _animalsInfoController;
        private readonly Mock<ILogger<AnimalsInfoController>> _loggerMock;

        public AnimalsInfoControllerUnitTests()
        {
            _loggerMock = new Mock<ILogger<AnimalsInfoController>>();
            _animalProvider = new AnimalProvider();
            _animalsInfoController = new AnimalsInfoController(_loggerMock.Object, _animalProvider);
        }

        [Fact]
        public void GetAnimals_WhenCallApiController_ShouldReturnAnimalInstance()
        {
            // Arrange
            var animal = new Animal
            {
                Name = "Dog",
                Quantity = 1,
                Characteristics = new()
                {
                    SpeciesType = "Canidae",
                    FlyingType = false
                }
            };

            // Act
            var result = _animalsInfoController.GetAnimals();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.Name, animal.Name);
            Assert.Equal(result.Quantity, animal.Quantity);
            Assert.Equal(result.Characteristics.SpeciesType, animal.Characteristics.SpeciesType);
            Assert.Equal(result.Characteristics.FlyingType, animal.Characteristics.FlyingType);
        }
    }
}