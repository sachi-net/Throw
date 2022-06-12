using System;
using System.Collections.Generic;
using System.Linq;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define validations for <see cref="ICollection{T}"/> collections.
    /// </summary>
    public class CollectionValidator<T> : ValidationBase, ICollectionValidatable<T>
    {
        internal ICollection<T> collection;

        /// <summary>
        /// Initialize <see cref="CollectionValidator{T}"/> instance with <see cref="ICollection{T}"/> list to perform validations.
        /// </summary>
        /// <param name="collection">Collection to be compared.</param>
        public CollectionValidator(ICollection<T> collection)
        {
            this.collection = collection;
        }

        /// <summary>
        /// Initialize <see cref="CollectionValidator{T}"/> instance with <see cref="ICollection{T}"/> list to perform validations with custom <paramref name="message"/>.
        /// </summary>
        /// <param name="collection">Collection to be compared.</param>
        /// <param name="message">Custom message in the default exception.</param>
        public CollectionValidator(ICollection<T> collection, string message) : this(collection)
        {
            _message = message;
        }

        /// <summary>
        /// Initialize <see cref="CollectionValidator{T}"/> instance with <see cref="ICollection{T}"/> list to perform validations with custom <paramref name="exception"/>.
        /// </summary>
        /// <param name="collection">Collection to be compared.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        public CollectionValidator(ICollection<T> collection, Exception exception) : this(collection)
        {
            this.exception = exception;
        }

        /// <summary>
        /// Initialize <see cref="CollectionValidator{T}"/> instance with <see cref="ICollection{T}"/> list and <paramref name="action"/> to invoke when triggering validations.
        /// </summary>
        /// <param name="collection">Collection to be compared.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        public CollectionValidator(ICollection<T> collection, Action action) : this(collection)
        {
            this.action = action;
        }

        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ConditionNotMeetException">Throws default exception.</exception>
        public ICollectionValidatable<T> When(Func<bool> condition, string message = null)
        {
            if (condition.Invoke())
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.CONDITION : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the given <paramref name="predicate"/> evaluated to be true against each element in the collection.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="message"></param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenAny(Func<T, bool> predicate, string message = null)
        {
            if (collection.Where(predicate)?.Count() > 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.LIST_ANY : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="ICollection{T}"/> contains the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be checked in the list.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenContain(T value, string message = null)
        {
            if (collection.Contains(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.LIST_CONTAIN : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenCountEqualTo(int value, string message = null)
        {
            if (collection.Count == value)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LIST_COUNT_EQUALS, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is greater than the given <paramref name="maximum"/> value.
        /// </summary>
        /// <param name="maximum">Maximum value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenCountGreaterThan(int maximum, string message = null)
        {
            if (collection.Count > maximum)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LIST_COUNT_GREATER, maximum) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is greater than or equal to the given <paramref name="maximum"/> value.
        /// </summary>
        /// <param name="maximum">Maximum value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenCountGreaterThanOrEqualTo(int maximum, string message = null)
        {
            if (collection.Count >= maximum)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LIST_COUNT_GREATER_EQ, maximum) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is less than the given <paramref name="minimum"/> value.
        /// </summary>
        /// <param name="minimum">Minimum value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenCountLessThan(int minimum, string message = null)
        {
            if (collection.Count < minimum)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LIST_COUNT_LESSER, minimum) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is less than or equal to the given <paramref name="minimum"/> value.
        /// </summary>
        /// <param name="minimum">Minimum value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenCountLessThanOrEqualTo(int minimum, string message = null)
        {
            if (collection.Count <= minimum)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LIST_COUNT_LESSER_EQ, minimum) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the number of elements in the <see cref="ICollection{T}"/> is not equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenCountNotEqualTo(int value, string message = null)
        {
            if (collection.Count != value)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LIST_COUNT_NOT_EQUALS, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="ICollection{T}"/> list has no elements.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenEmpty(string message = null)
        {
            if (collection.Count == 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.LIST_EMPTY : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="ICollection{T}"/> does not contain the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be checked in the list.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ConditionNotMeetException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenNotContain(T value, string message = null)
        {
            if (!collection.Contains(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.LIST_NOT_CONTAIN : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="ICollection{T}"/> list has at least one element.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenNotEmpty(string message = null)
        {
            if (collection.Count > 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.LIST_NOT_EMPTY : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="ICollection{T}"/> list is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public ICollectionValidatable<T> WhenNull(string message = null)
        {
            if (collection is null)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.LIST_NULL : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }
    }
}
