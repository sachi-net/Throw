using System;
using System.Text.RegularExpressions;

namespace ThrowValidator.Validations
{
    public interface IStringValidatable
    {
        public IStringValidatable When(Func<bool> condition, string message = null);
        public IStringValidatable WhenNull(string message = null);
        public IStringValidatable WhenWhiteSpaces(string message = null);
        public IStringValidatable WhenEmpty(string message = null);
        public IStringValidatable WhenEqualTo(string value, string message = null);
        public IStringValidatable WhenEqualTo(string value, StringComparison comparison, string message = null);
        public IStringValidatable WhenNotEqualTo(string value, string message = null);
        public IStringValidatable WhenNotEqualTo(string value, StringComparison comparison, string message = null);
        public IStringValidatable WhenLengthLongerThan(int maxLength, string message = null);
        public IStringValidatable WhenLengthShorterThan(int minLength, string message = null);
        public IStringValidatable WhenMatchWith(string pattern, string message = null);
        public IStringValidatable WhenMatchWith(string pattern, RegexOptions options, string message = null);
        public IStringValidatable WhenMatchWith(Regex regex, string message = null);
        public IStringValidatable WhenNotMatchWith(string pattern, string message = null);
        public IStringValidatable WhenNotMatchWith(string pattern, RegexOptions options, string message = null);
        public IStringValidatable WhenNotMatchWith(Regex regex, string message = null);
        public IStringValidatable WhenContain(char character, string message = null);
        public IStringValidatable WhenContain(char character, StringComparison comparison, string message = null);
        public IStringValidatable WhenContain(string value, string message = null);
        public IStringValidatable WhenContain(string value, StringComparison comparison, string message = null);
        public IStringValidatable WhenNotContain(char character, string message = null);
        public IStringValidatable WhenNotContain(char character, StringComparison comparison, string message = null);
        public IStringValidatable WhenNotContain(string value, string message = null);
        public IStringValidatable WhenNotContain(string value, StringComparison comparison, string message = null);
        public IStringValidatable WhenLengthEqualTo(int length, string message = null);
        public IStringValidatable WhenLengthNotEqualTo(int length, string message = null);
        public IStringValidatable WhenStartWith(string value, string message = null);
        public IStringValidatable WhenStartWith(string value, StringComparison comparison, string message = null);
        public IStringValidatable WhenNotStartWith(string value, string message = null);
        public IStringValidatable WhenNotStartWith(string value, StringComparison comparison, string message = null);
        public IStringValidatable WhenEndWith(string value, string message = null);
        public IStringValidatable WhenEndWith(string value, StringComparison comparison, string message = null);
        public IStringValidatable WhenNotEndWith(string value, string message = null);
        public IStringValidatable WhenNotEndWith(string value, StringComparison comparison, string message = null);
    }
}
