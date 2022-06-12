using System;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define methods to validate in-built or custom classes.
    /// </summary>
    /// <typeparam name="T">Type of class.</typeparam>
    public interface ICustomTypeValidatable<T>
    {
        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with custom-type validator.</returns>
        public ICustomTypeValidatable<T> When(Func<bool> condition, string message = null);

        /// <summary>
        /// Triggers when the given <paramref name="predicate"/> evaluated to be true against this object.
        /// </summary>
        /// <param name="predicate">Boolean predicate condition of this object.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with custom-type validator.</returns>
        public ICustomTypeValidatable<T> When(Func<T, bool> predicate, string message = null);

        /// <summary>
        /// Triggers when the given <paramref name="predicate"/> evaluated to be false against this object.
        /// </summary>
        /// <param name="predicate">Boolean predicate condition of this object.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with custom-type validator.</returns>
        public ICustomTypeValidatable<T> WhenNot(Func<T, bool> predicate, string message = null);

        /// <summary>
        /// Triggers when the object is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with custom-type validator.</returns>
        public ICustomTypeValidatable<T> WhenNull(string message = null);
    }
}
