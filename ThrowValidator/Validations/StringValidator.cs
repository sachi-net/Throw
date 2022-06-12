using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define validations for <see cref="string"/> structures.
    /// </summary>
    public class StringValidator : ValidationBase, IStringValidatable
    {
        internal string value;

        /// <summary>
        /// Initialize <see cref="StringValidator"/> instance with <see cref="string"/> value to perform validations.
        /// </summary>
        /// <param name="value">String value.</param>
        public StringValidator(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Initialize <see cref="StringValidator"/> instance with <see cref="string"/> value to perform validations with custom <paramref name="message"/>.
        /// </summary>
        /// <param name="value">String value.</param>
        /// <param name="message">Custom message in the default exception.</param>
        public StringValidator(string value, string message) : this(value)
        {
            _message = message;
        }

        /// <summary>
        /// Initialize <see cref="StringValidator"/> instance with <see cref="string"/> value to perform validations with custom <paramref name="exception"/>.
        /// </summary>
        /// <param name="value">String value.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        public StringValidator(string value, Exception exception) : this(value)
        {
            this.exception = exception;
        }

        /// <summary>
        /// Initialize <see cref="StringValidator"/> instance with <see cref="string"/> value and <paramref name="action"/> to invoke when triggering validations.
        /// </summary>
        /// <param name="value">String value.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        public StringValidator(string value, Action action) : this(value)
        {
            this.action = action;
        }

        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ConditionNotMeetException">Throws default exception.</exception>
        public IStringValidatable When(Func<bool> condition, string message = null)
        {
            if (condition.Invoke())
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.CONDITION : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> contains the given <paramref name="character"/> at least once.
        /// </summary>
        /// <param name="character">Character to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenContain(char character, string message = null)
        {
            if (value.Contains(character))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_CONTAINS, character) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> contains the given <paramref name="value"/> at least once.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenContain(string value, string message = null)
        {
            if (this.value.Contains(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_CONTAINS, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> contains the given <paramref name="character"/> at least once with string comparison rules.
        /// </summary>
        /// <param name="character">Character to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenContain(char character, StringComparison comparison, string message = null)
        {
            if (value.Contains(character, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_CONTAINS, character) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> contains the given <paramref name="value"/> at least once with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenContain(string value, StringComparison comparison, string message = null)
        {
            if (this.value.Contains(value, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_CONTAINS, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value is empty.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenEmpty(string message = null)
        {
            if (value == string.Empty)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.EMPTY_STRING : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value ends with given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenEndWith(string value, string message = null)
        {
            if (this.value.EndsWith(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_ENDS_WITH, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value ends with given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenEndWith(string value, StringComparison comparison, string message = null)
        {
            if (this.value.EndsWith(value, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_ENDS_WITH, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value is equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenEqualTo(string value, string message = null)
        {
            if (this.value.Equals(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.EQUALS_STRING : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value is equal to the given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenEqualTo(string value, StringComparison comparison, string message = null)
        {
            if (this.value.Equals(value, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.EQUALS_STRING : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the length of <see cref="string"/> value is equal to the given <paramref name="length"/>.
        /// </summary>
        /// <param name="length">Number of characters to be allowed.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenLengthEqualTo(int length, string message = null)
        {
            if (value.Length == length)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LENGTH_EQUALS, length) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the length of <see cref="string"/> value is higher than the given <paramref name="maxLength"/>.
        /// </summary>
        /// <param name="maxLength">Maximum number of characters to be allowed.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenLengthLongerThan(int maxLength, string message = null)
        {
            if (value.Length > maxLength)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.MAX_LENGTH, maxLength) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the length of <see cref="string"/> value is not equal to the given <paramref name="length"/>.
        /// </summary>
        /// <param name="length">Number of characters to be allowed.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenLengthNotEqualTo(int length, string message = null)
        {
            if (value.Length != length)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LENGTH_NOT_EQUALS, length) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the length of <see cref="string"/> value is lower than the given <paramref name="minLength"/>.
        /// </summary>
        /// <param name="minLength">Minimum number of characters to be allowed.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenLengthShorterThan(int minLength, string message = null)
        {
            if (value.Length < minLength)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.MIN_LENGTH, minLength) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> matches with given <paramref name="pattern"/>.
        /// </summary>
        /// <param name="pattern">Compilable string pattern to be used in comparison.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenMatchWith(string pattern, string message = null)
        {
            Regex regex = new(pattern);
            if (regex.IsMatch(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.PATTERN_MATCH : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> matches with given Regular-Expression.
        /// </summary>
        /// <param name="regex">Regular-Expression to be used in comparison.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenMatchWith(Regex regex, string message = null)
        {
            if (regex.IsMatch(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.PATTERN_MATCH : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> matches with given <paramref name="pattern"/> with Regular-Expression options.
        /// </summary>
        /// <param name="pattern">Compilable string pattern to be used in comparison.</param>
        /// <param name="options">Regular-Expression options.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenMatchWith(string pattern, RegexOptions options, string message = null)
        {
            if (Regex.IsMatch(value, pattern, options))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.PATTERN_MATCH : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> does not contain the given <paramref name="character"/> at least once.
        /// </summary>
        /// <param name="character">Character to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotContain(char character, string message = null)
        {
            if (!value.Contains(character))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_CONTAINS, character) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> does not contain the given <paramref name="value"/> at least once.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotContain(string value, string message = null)
        {
            if (!this.value.Contains(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_CONTAINS, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> does not contain the given <paramref name="character"/> at least once with string comparison rules.
        /// </summary>
        /// <param name="character">Character to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotContain(char character, StringComparison comparison, string message = null)
        {
            if (!value.Contains(character, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_CONTAINS, character) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> contains the given <paramref name="value"/> at least once with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotContain(string value, StringComparison comparison, string message = null)
        {
            if (!this.value.Contains(value, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_CONTAINS, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value does not end with given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotEndWith(string value, string message = null)
        {
            if (!this.value.EndsWith(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_ENDS_WITH, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value does not end with given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotEndWith(string value, StringComparison comparison, string message = null)
        {
            if (!this.value.EndsWith(value, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_ENDS_WITH, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value is not equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotEqualTo(string value, string message = null)
        {
            if (!this.value.Equals(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.NOT_EQUALS_STRING : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value is not equal to the given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotEqualTo(string value, StringComparison comparison, string message = null)
        {
            if (!this.value.Equals(value, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.NOT_EQUALS_STRING : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> does not match with given <paramref name="pattern"/>.
        /// </summary>
        /// <param name="pattern">Compilable string pattern to be used in comparison.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotMatchWith(string pattern, string message = null)
        {
            Regex regex = new(pattern);
            if (!regex.IsMatch(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.PATTERN_NOT_MATCH : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> does not match with given Regular-Expression.
        /// </summary>
        /// <param name="regex">Regular-Expression to be used in comparison.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotMatchWith(Regex regex, string message = null)
        {
            if (!regex.IsMatch(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.PATTERN_NOT_MATCH : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> does not match with given <paramref name="pattern"/> with Regular-Expression options.
        /// </summary>
        /// <param name="pattern">Compilable string pattern to be used in comparison.</param>
        /// <param name="options">Regular-Expression options.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotMatchWith(string pattern, RegexOptions options, string message = null)
        {
            if (!Regex.IsMatch(value, pattern, options))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.PATTERN_NOT_MATCH : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value does not start with given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotStartWith(string value, string message = null)
        {
            if (!this.value.StartsWith(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_STARTS_WITH, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value does not start with given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNotStartWith(string value, StringComparison comparison, string message = null)
        {
            if (!this.value.StartsWith(value, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_STARTS_WITH, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the value is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenNull(string message = null)
        {
            if (value is null)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.NULL : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value starts with given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenStartWith(string value, string message = null)
        {
            if (this.value.StartsWith(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_STARTS_WITH, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value starts with given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenStartWith(string value, StringComparison comparison, string message = null)
        {
            if (this.value.StartsWith(value, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_STARTS_WITH, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="string"/> value only contains white-spaces
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IStringValidatable WhenWhiteSpaces(string message = null)
        {
            if (value.Replace(" ", string.Empty) == string.Empty)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.WHITESPACES : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }
    }
}
