using System;

namespace ThrowValidator.Validations
{
    public interface IDateTimeValidatable
    {
        public IDateTimeValidatable When(Func<bool> condition, string message = null);
        public IDateTimeValidatable WhenNull(string message = null);
        public IDateTimeValidatable WhenEqualTo(DateTime? dateTime, string message = null);
        public IDateTimeValidatable WhenNotEqualTo(DateTime? dateTime, string message = null);
        public IDateTimeValidatable WhenLessThan(DateTime? dateTime, string message = null);
        public IDateTimeValidatable WhenLessThanOrEqualTo(DateTime? dateTime, string message = null);
        public IDateTimeValidatable WhenGreaterThan(DateTime? dateTime, string message = null);
        public IDateTimeValidatable WhenGreaterThanOrEqualTo(DateTime? dateTime, string message = null);
        public IDateTimeValidatable WhenInRange(DateTime? left, DateTime? right, Boundary boundary = Boundary.Inclusive, string message = null);
        public IDateTimeValidatable WhenOutOfRange(DateTime? left, DateTime? right, Boundary boundary = Boundary.Exclusive, string message = null);
    }
}
