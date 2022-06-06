using System;

namespace ThrowValidator.Validations
{
    public interface IEnumValidatable
    {
        public IEnumValidatable When(Func<bool> condition, string message = null);
        public IEnumValidatable WhenNull(string message = null);
        public IEnumValidatable WhenEqualTo(Enum @enum, string message = null);
        public IEnumValidatable WhenOutOfRange(int enumIndex, string message = null);
    }
}
