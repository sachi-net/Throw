using System;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    public class NumericValidatorNullable<T> : ValidationBase, INumericValidator<T> where T: struct
    {
        internal T? value;

        public NumericValidatorNullable(T? value)
        {
            this.value = value;
        }

        public NumericValidatorNullable(T? value, string message)
        {
            this.value = value;
            _message = message;
        }

        public NumericValidatorNullable(T? value, Exception exception)
        {
            this.value = value;
            this.exception = exception;
        }

        public NumericValidatorNullable(T? value, Action action)
        {
            this.value = value;
            this.action = action;
        }

        public INumericValidator<T> When(Func<bool> condition, string message = null)
        {
            if (condition.Invoke())
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.CONDITION : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenEqualTo(T value, string message = null)
        {
            if (Nullable.Compare(this.value, value) is 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.EQUALS, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenGreaterThan(T value, string message = null)
        {
            if (Nullable.Compare(this.value, value) > 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.GREATER, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenGreaterThanOrEqualTo(T value, string message = null)
        {
            if (Nullable.Compare(this.value, value) >= 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.GREATER_EQ, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenInRange(T left, T right, Boundary boundary = Boundary.Inclusive, string message = null)
        {
            bool isInRange = false;

            if (Nullable.Compare<T>(left, right) > 0)
            {
                T temp = left;
                left = right;
                right = temp;
            }

            switch (boundary)
            {
                case Boundary.Inclusive:
                    isInRange = Nullable.Compare(value, left) >= 0 && Nullable.Compare(value, right) <= 0;
                    break;
                case Boundary.Exclusive:
                    isInRange = Nullable.Compare(value, left) > 0 && Nullable.Compare(value, right) < 0;
                    break;
                case Boundary.LeftOnly:
                    isInRange = Nullable.Compare(value, left) >= 0 && Nullable.Compare(value, right) < 0;
                    break;
                case Boundary.RightOnly:
                    isInRange = Nullable.Compare(value, left) > 0 && Nullable.Compare(value, right) <= 0;
                    break;
            }
            if (isInRange)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.IN_RANGE, $"({left}, {right})", boundary) : _message);
                throw exception is not null ? exception : new RangeNotMatchException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenLessThan(T value, string message = null)
        {
            if (Nullable.Compare(this.value, value) < 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LESSER, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenLessThanOrEqualTo(T value, string message = null)
        {
            if (Nullable.Compare(this.value, value) <= 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LESSER_EQ, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenNegative(string message = null)
        {
            T value = (T)Convert.ChangeType(0, typeof(T));
            if (Nullable.Compare(this.value, value) < 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.NEGATIVE : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenNotEqualTo(T value, string message = null)
        {
            if (Nullable.Compare(this.value, value) is not 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.NOT_EQUALS, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenNull(string message = null)
        {
            if (value is null)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.NULL : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenOutOfRange(T left, T right, Boundary boundary = Boundary.Exclusive, string message = null)
        {
            bool isOutOfRange = false;

            if (Nullable.Compare<T>(left, right) > 0)
            {
                T temp = left;
                left = right;
                right = temp;
            }

            switch (boundary)
            {
                case Boundary.Inclusive:
                    isOutOfRange = Nullable.Compare(value, left) <= 0 || Nullable.Compare(value, right) >= 0;
                    break;
                case Boundary.Exclusive:
                    isOutOfRange = Nullable.Compare(value, left) < 0 || Nullable.Compare(value, right) > 0;
                    break;
                case Boundary.LeftOnly:
                    isOutOfRange = Nullable.Compare(value, left) <= 0 || Nullable.Compare(value, right) > 0;
                    break;
                case Boundary.RightOnly:
                    isOutOfRange = Nullable.Compare(value, left) < 0 || Nullable.Compare(value, right) >= 0;
                    break;
            }
            if (isOutOfRange)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.OUT_OF_RANGE, $"({left}, {right})", boundary) : _message);
                throw exception is not null ? exception : new RangeNotMatchException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenPositive(string message = null)
        {
            T value = (T)Convert.ChangeType(0, typeof(T));
            if (Nullable.Compare(this.value, value) > 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.POSITIVE : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public INumericValidator<T> WhenZero(string message = null)
        {
            T value = (T)Convert.ChangeType(0, typeof(T));
            if (Nullable.Compare(this.value, value) is 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.ZERO : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }
    }
}
