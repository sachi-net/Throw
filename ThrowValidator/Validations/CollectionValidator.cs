using System;
using System.Collections.Generic;
using System.Linq;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    public class CollectionValidator<T> : ValidationBase, ICollectionValidatable<T>
    {
        internal ICollection<T> collection;

        public CollectionValidator(ICollection<T> collection)
        {
            this.collection = collection;
        }

        public CollectionValidator(ICollection<T> collection, string message) : this(collection)
        {
            _message = message;
        }

        public CollectionValidator(ICollection<T> collection, Exception exception) : this(collection)
        {
            this.exception = exception;
        }

        public CollectionValidator(ICollection<T> collection, Action action) : this(collection)
        {
            this.action = action;
        }

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
