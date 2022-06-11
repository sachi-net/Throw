using System;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define methods to validate Boolean (<see cref="bool"/>) values and expressions.
    /// </summary>
    public interface IBooleanValidatable
    {
        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public IBooleanValidatable When(Func<bool> condition, string message = null);

        /// <summary>
        /// Triggers when the given <see cref="bool"/> (nullable) expression or value is null.
        /// </summary>
        /// <param name="message">optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public IBooleanValidatable WhenNull(string message = null);

        /// <summary>
        /// Triggers when the given <see cref="bool"/> (nullable) expression or value is true.
        /// </summary>
        /// <param name="message">optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public IBooleanValidatable WhenTrue(string message = null);

        /// <summary>
        /// Triggers when the given <see cref="bool"/> (nullable) expression or value is false.
        /// </summary>
        /// <param name="message">optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public IBooleanValidatable WhenFalse(string message = null);
    }
}
