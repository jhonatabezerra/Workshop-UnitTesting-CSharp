using ProjectTester.Domain.Models.Enum;
using ProjectTester.Domain.Models.Operations;

namespace ProjectTester.Services.Provider
{
    /// <summary>Responsible for provider the <see cref="Operations"/> information.</summary>
    public class TransactionProvider
    {
        /// <summary>Get a new <see cref="Operations"/> instance with information.</summary>
        /// <returns>A <see cref="Operations"/> instance.</returns>
        public Operations GetOperation() => new()
        {
            Operation = OperationTypes.BUY,
            UnitCost = 1,
            Quantity = 1,
        };

        /// <summary>Get a new <see cref="Operations"/> instance with information.</summary>
        /// <returns>A <see cref="Operations"/> instance.</returns>
        public Operations PostOperation(Operations operations)
        {
            Operations operations1 = operations;
            return operations1;
        }
    }
}