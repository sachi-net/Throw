using System;

namespace ThrowValidator.Validations
{
    public interface IBooleanValidatable
    {
        public IBooleanValidatable When(Func<bool> condition, string message = null);
        public IBooleanValidatable WhenNull(string message = null);
        public IBooleanValidatable WhenTrue(string message = null);
        public IBooleanValidatable WhenFalse(string message = null);
    }
}
