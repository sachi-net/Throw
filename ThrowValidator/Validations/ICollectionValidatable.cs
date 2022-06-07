using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowValidator.Validations
{
    public interface ICollectionValidatable<T>
    {
        public ICollectionValidatable<T> When(Func<bool> condition, string message = null);
        public ICollectionValidatable<T> WhenAny(Func<T, bool> predicate, string message = null);
        public ICollectionValidatable<T> WhenNull(string message = null);
        public ICollectionValidatable<T> WhenEmpty(string message = null);
        public ICollectionValidatable<T> WhenNotEmpty(string message = null);
        public ICollectionValidatable<T> WhenCountEqualTo(int value, string message = null);
        public ICollectionValidatable<T> WhenCountNotEqualTo(int value, string message = null);
        public ICollectionValidatable<T> WhenCountLessThan(int minimum, string message = null);
        public ICollectionValidatable<T> WhenCountLessThanOrEqualTo(int minimum, string message = null);
        public ICollectionValidatable<T> WhenCountGreaterThan(int maximum, string message = null);
        public ICollectionValidatable<T> WhenCountGreaterThanOrEqualTo(int maximum, string message = null);
        public ICollectionValidatable<T> WhenContain(T value, string message = null);
        public ICollectionValidatable<T> WhenNotContain(T value, string message = null);
    }
}
