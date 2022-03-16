using ProjectTester.Domain.Models.Animals;

namespace ProjectTester.Services.Provider
{
    public class AnimalProvider
    {
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