using System;

namespace ThrowValidator.Validations
{
    public abstract class Validator
    {
        public abstract Validator WhenNull(string message = null);

        public abstract Validator When(Func<bool> condition, string message = null);
    }
}
