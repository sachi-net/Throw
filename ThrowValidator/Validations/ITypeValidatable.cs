using System;

namespace ThrowValidator.Validations
{
    public interface ITypeValidatable
    {
        public ITypeValidatable When(Func<bool> condition, string message = null);
        public ITypeValidatable WhenNull(string message = null);
        public ITypeValidatable WhenEqualTo(Type type, string message = null);
        public ITypeValidatable WhenNotEqualTo(Type type, string message = null);
    }
}
