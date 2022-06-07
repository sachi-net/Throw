using System;

namespace ThrowValidator.Validations
{
    public interface ICustomTypeValidatable<T>
    {
        public ICustomTypeValidatable<T> When(Func<bool> condition, string message = null);
        public ICustomTypeValidatable<T> When(Func<T, bool> predicate, string message = null);
        public ICustomTypeValidatable<T> WhenNot(Func<T, bool> predicate, string message = null);
        public ICustomTypeValidatable<T> WhenNull(string message = null);
    }
}
