using System;

namespace ThrowValidator.Validations
{
    public abstract class ValidationBase
    {
        protected string _message = null;
        protected Action action = null;
        protected Exception exception = null;
    }
}
