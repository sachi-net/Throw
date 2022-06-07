using System;

namespace ThrowValidator.Validations
{
    public interface ICustomType<T>
    {
        public ICustomType<T> When(Func<bool> condition, string message = null);
        public ICustomType<T> When(Func<T, bool> predicate, string message = null);
        public ICustomType<T> WhenNot(Func<T, bool> predicate, string message = null);
        public ICustomType<T> WhenNull(string message = null);
    }
}
