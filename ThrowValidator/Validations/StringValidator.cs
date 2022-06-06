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
    public class StringValidator : ValidationBase, IStringValidatable
    {
        internal string value;

        public StringValidator(string value)
        {
            this.value = value;
        }

        public StringValidator(string value, string message) : this(value)
        {
            _message = message;
        }

        public StringValidator(string value, Exception exception) : this(value)
        {
            this.exception = exception;
        }

        public StringValidator(string value, Action action) : this(value)
        {
            this.action = action;
        }

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

        public IStringValidatable WhenContain(char character, string message = null)
        {
            if (value.Contains(character))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_CONTAINS, character) : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public IStringValidatable WhenContain(string value, string message = null)
        {
            if (this.value.Contains(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_CONTAINS, value) : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public IStringValidatable WhenContain(char character, StringComparison comparison, string message = null)
        {
            if (value.Contains(character, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_CONTAINS, character) : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public IStringValidatable WhenContain(string value, StringComparison comparison, string message = null)
        {
            if (this.value.Contains(value, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_CONTAINS, value) : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

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

        public IStringValidatable WhenNotContain(char character, string message = null)
        {
            if (!value.Contains(character))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_CONTAINS, character) : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public IStringValidatable WhenNotContain(string value, string message = null)
        {
            if (!this.value.Contains(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_CONTAINS, value) : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public IStringValidatable WhenNotContain(char character, StringComparison comparison, string message = null)
        {
            if (!value.Contains(character, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_CONTAINS, character) : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public IStringValidatable WhenNotContain(string value, StringComparison comparison, string message = null)
        {
            if (!this.value.Contains(value, comparison))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.STRING_NOT_CONTAINS, value) : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

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
