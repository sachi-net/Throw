using System;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define methods to validate <see cref="DateTime"/> struct.
    /// </summary>
    public interface IDateTimeValidatable
    {
        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public IDateTimeValidatable When(Func<bool> condition, string message = null);

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> (nullable) value is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public IDateTimeValidatable WhenNull(string message = null);

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is equal to the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public IDateTimeValidatable WhenEqualTo(DateTime? dateTime, string message = null);

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is not equal to the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public IDateTimeValidatable WhenNotEqualTo(DateTime? dateTime, string message = null);

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is less than the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public IDateTimeValidatable WhenLessThan(DateTime? dateTime, string message = null);

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is less than or equal to the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public IDateTimeValidatable WhenLessThanOrEqualTo(DateTime? dateTime, string message = null);

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is greater than the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public IDateTimeValidatable WhenGreaterThan(DateTime? dateTime, string message = null);

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is greater than or equal to the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public IDateTimeValidatable WhenGreaterThanOrEqualTo(DateTime? dateTime, string message = null);

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is within the given range between <paramref name="left"/> and <paramref name="right"/>.
        /// </summary>
        /// <param name="left">Date-Time left boundary.</param>
        /// <param name="right">Date-Time right boundary.</param>
        /// <param name="boundary">Boundary value comparison whether Inclusive, Exclusive, LeftOnly or RightOnly.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public IDateTimeValidatable WhenInRange(DateTime? left, DateTime? right, Boundary boundary = Boundary.Inclusive, string message = null);

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is out of the given range of <paramref name="left"/> and <paramref name="right"/>.
        /// </summary>
        /// <param name="left">Date-Time left boundary.</param>
        /// <param name="right">Date-Time right boundary.</param>
        /// <param name="boundary">Boundary value comparison whether Inclusive, Exclusive, LeftOnly or RightOnly.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public IDateTimeValidatable WhenOutOfRange(DateTime? left, DateTime? right, Boundary boundary = Boundary.Exclusive, string message = null);
    }
}
