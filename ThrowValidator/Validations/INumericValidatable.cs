using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowValidator.Validations
{
    public interface INumericValidatable<T>
    {
        public INumericValidatable<T> When(Func<bool> condition, string message = null);
        public INumericValidatable<T> WhenNull(string message = null);
        public INumericValidatable<T> WhenZero(string message = null);
        public INumericValidatable<T> WhenPositive(string message = null);
        public INumericValidatable<T> WhenNegative(string message = null);
        public INumericValidatable<T> WhenLessThan(T value, string message = null);
        public INumericValidatable<T> WhenLessThanOrEqualTo(T value, string message = null);
        public INumericValidatable<T> WhenGreaterThan(T value, string message = null);
        public INumericValidatable<T> WhenGreaterThanOrEqualTo(T value, string message = null);
        public INumericValidatable<T> WhenEqualTo(T value, string message = null);
        public INumericValidatable<T> WhenNotEqualTo(T value, string message = null);
        public INumericValidatable<T> WhenInRange(T left, T right, Boundary boundary = Boundary.Inclusive, string message = null);
        public INumericValidatable<T> WhenOutOfRange(T left, T right, Boundary boundary = Boundary.Exclusive, string message = null);
    }
}
