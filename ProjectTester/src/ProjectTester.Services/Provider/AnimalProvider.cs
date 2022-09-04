using ProjectTester.Domain.Models.Animals;

namespace ProjectTester.Services.Provider
{
    /// <summary>
    /// Responsible for provider the <see cref="Animal"/> information.
    /// </summary>
    public class AnimalProvider
    {
        /// <summary>
        /// Get a new <see cref="Animal"/> instance with information.
        /// </summary>
        /// <returns>A <see cref="Animal"/> instance.</returns>
        public Animal GetAnimals() => new()
        {
            Name = "Dog",
            Quantity = 1,
            Characteristics = new()
            {
                SpeciesType = "Canidae",
                FlyingType = false
            }
        };
    }
}