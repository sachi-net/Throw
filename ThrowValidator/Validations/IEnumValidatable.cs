using System;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define methods to validate enumerators (<see cref="Enum"/>).
    /// </summary>
    public interface IEnumValidatable
    {
        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
        public IEnumValidatable When(Func<bool> condition, string message = null);

        /// <summary>
        /// Triggers when the <see cref="Enum"/> value is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
        public IEnumValidatable WhenNull(string message = null);

        /// <summary>
        /// Triggers when the <see cref="Enum"/> is equal to the given <paramref name="enum"/> value.
        /// </summary>
        /// <param name="enum">Enum value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
        public IEnumValidatable WhenEqualTo(Enum @enum, string message = null);

        /// <summary>
        /// Triggers when the given <paramref name="enumIndex"/> is not define in the <see cref="Enum"/>.
        /// </summary>
        /// <param name="enumIndex">Enum index to be evaluated.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
        public IEnumValidatable WhenOutOfRange(int enumIndex, string message = null);
    }
}
