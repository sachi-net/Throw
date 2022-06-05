using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowValidator.Validations
{
    public interface INumericValidator<T>
    {
        public INumericValidator<T> When(Func<bool> condition, string message = null);
        public INumericValidator<T> WhenNull(string message = null);
        public INumericValidator<T> WhenZero(string message = null);
        public INumericValidator<T> WhenPositive(string message = null);
        public INumericValidator<T> WhenNegative(string message = null);
        public INumericValidator<T> WhenLessThan(T value, string message = null);
        public INumericValidator<T> WhenLessThanOrEqualTo(T value, string message = null);
        public INumericValidator<T> WhenGreaterThan(T value, string message = null);
        public INumericValidator<T> WhenGreaterThanOrEqualTo(T value, string message = null);
        public INumericValidator<T> WhenEqualTo(T value, string message = null);
        public INumericValidator<T> WhenNotEqualTo(T value, string message = null);
    }
}
