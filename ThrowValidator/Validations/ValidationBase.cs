using System;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Share validation-base properties.
    /// </summary>
    public abstract class ValidationBase
    {
        /// <summary>
        /// Validation message to be shown.
        /// </summary>
        protected string _message = null;

        /// <summary>
        /// Action method to be invoked when failing the validation
        /// </summary>
        protected Action action = null;

        /// <summary>
        /// Custom exception to be thrown instead of the default exception.
        /// </summary>
        protected Exception exception = null;
    }
}
