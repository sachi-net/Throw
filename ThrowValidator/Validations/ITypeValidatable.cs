using System;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define methods to validate <see cref="Type"/> constructs.
    /// </summary>
    public interface ITypeValidatable
    {
        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
        public ITypeValidatable When(Func<bool> condition, string message = null);

        /// <summary>
        /// Triggers when the value is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
        public ITypeValidatable WhenNull(string message = null);

        /// <summary>
        /// Triggers when the <see cref="Type"/> is equal to the given <paramref name="type"/>.
        /// </summary>
        /// <param name="type">Type to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
        public ITypeValidatable WhenEqualTo(Type type, string message = null);

        /// <summary>
        /// Triggers when the <see cref="Type"/> is not equal to the given <paramref name="type"/>.
        /// </summary>
        /// <param name="type">Type to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
        public ITypeValidatable WhenNotEqualTo(Type type, string message = null);
    }
}
