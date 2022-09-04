namespace ProjectTester.Domain.Models.Animals
{
    /// <summary>
    /// Represent the <see cref="Animal"/> information.
    /// </summary>
    public class Animal
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public Characteristics? Characteristics { get; set; }
    }
}