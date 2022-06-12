using System;
using System.Collections.Generic;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define methods to validate collections which implements <see cref="ICollection{T}"/>.
    /// </summary>
    /// <typeparam name="T">Type of class or struct.</typeparam>
    public interface ICollectionValidatable<T>
    {
        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> When(Func<bool> condition, string message = null);

        /// <summary>
        /// Triggers when the given <paramref name="predicate"/> evaluated to be true against each element in the collection.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="message"></param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenAny(Func<T, bool> predicate, string message = null);

        /// <summary>
        /// Triggers when the <see cref="ICollection{T}"/> list is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenNull(string message = null);

        /// <summary>
        /// Triggers when the <see cref="ICollection{T}"/> list has no elements.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenEmpty(string message = null);

        /// <summary>
        /// Triggers when the <see cref="ICollection{T}"/> list has at least one element.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenNotEmpty(string message = null);

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenCountEqualTo(int value, string message = null);

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is not equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenCountNotEqualTo(int value, string message = null);

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is less than the given <paramref name="minimum"/> value.
        /// </summary>
        /// <param name="minimum">Minimum value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenCountLessThan(int minimum, string message = null);

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is less than or equal to the given <paramref name="minimum"/> value.
        /// </summary>
        /// <param name="minimum">Minimum value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenCountLessThanOrEqualTo(int minimum, string message = null);

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is greater than the given <paramref name="maximum"/> value.
        /// </summary>
        /// <param name="maximum">Maximum value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenCountGreaterThan(int maximum, string message = null);

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is greater than or equal to the given <paramref name="maximum"/> value.
        /// </summary>
        /// <param name="maximum">Maximum value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenCountGreaterThanOrEqualTo(int maximum, string message = null);

        /// <summary>
        /// Triggers when the <see cref="ICollection{T}"/> contains the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be checked in the list.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenContain(T value, string message = null);

        /// <summary>
        /// Triggers when the <see cref="ICollection{T}"/> does not contain the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be checked in the list.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public ICollectionValidatable<T> WhenNotContain(T value, string message = null);
    }
}
