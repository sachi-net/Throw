using System;
using System.Text.RegularExpressions;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define methods to validate <see cref="string"/> structures.
    /// </summary>
    public interface IStringValidatable
    {
        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable When(Func<bool> condition, string message = null);

        /// <summary>
        /// Triggers when the value is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNull(string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value only contains white-spaces
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenWhiteSpaces(string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value is empty.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenEmpty(string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value is equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenEqualTo(string value, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value is equal to the given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenEqualTo(string value, StringComparison comparison, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value is not equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotEqualTo(string value, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value is not equal to the given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotEqualTo(string value, StringComparison comparison, string message = null);

        /// <summary>
        /// Triggers when the length of <see cref="string"/> value is higher than the given <paramref name="maxLength"/>.
        /// </summary>
        /// <param name="maxLength">Maximum number of characters to be allowed.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenLengthLongerThan(int maxLength, string message = null);

        /// <summary>
        /// Triggers when the length of <see cref="string"/> value is lower than the given <paramref name="minLength"/>.
        /// </summary>
        /// <param name="minLength">Minimum number of characters to be allowed.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenLengthShorterThan(int minLength, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> matches with given <paramref name="pattern"/>.
        /// </summary>
        /// <param name="pattern">Compilable string pattern to be used in comparison.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenMatchWith(string pattern, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> matches with given <paramref name="pattern"/> with Regular-Expression options.
        /// </summary>
        /// <param name="pattern">Compilable string pattern to be used in comparison.</param>
        /// <param name="options">Regular-Expression options.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenMatchWith(string pattern, RegexOptions options, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> matches with given Regular-Expression.
        /// </summary>
        /// <param name="regex">Regular-Expression to be used in comparison.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenMatchWith(Regex regex, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> does not match with given <paramref name="pattern"/>.
        /// </summary>
        /// <param name="pattern">Compilable string pattern to be used in comparison.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotMatchWith(string pattern, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> does not match with given <paramref name="pattern"/> with Regular-Expression options.
        /// </summary>
        /// <param name="pattern">Compilable string pattern to be used in comparison.</param>
        /// <param name="options">Regular-Expression options.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotMatchWith(string pattern, RegexOptions options, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> does not match with given Regular-Expression.
        /// </summary>
        /// <param name="regex">Regular-Expression to be used in comparison.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotMatchWith(Regex regex, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> contains the given <paramref name="character"/> at least once.
        /// </summary>
        /// <param name="character">Character to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenContain(char character, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> contains the given <paramref name="character"/> at least once with string comparison rules.
        /// </summary>
        /// <param name="character">Character to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenContain(char character, StringComparison comparison, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> contains the given <paramref name="value"/> at least once.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenContain(string value, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> contains the given <paramref name="value"/> at least once with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenContain(string value, StringComparison comparison, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> does not contain the given <paramref name="character"/> at least once.
        /// </summary>
        /// <param name="character">Character to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotContain(char character, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> does not contain the given <paramref name="character"/> at least once with string comparison rules.
        /// </summary>
        /// <param name="character">Character to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotContain(char character, StringComparison comparison, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> does not contain the given <paramref name="value"/> at least once.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotContain(string value, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> contains the given <paramref name="value"/> at least once with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotContain(string value, StringComparison comparison, string message = null);

        /// <summary>
        /// Triggers when the length of <see cref="string"/> value is equal to the given <paramref name="length"/>.
        /// </summary>
        /// <param name="length">Number of characters to be allowed.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenLengthEqualTo(int length, string message = null);

        /// <summary>
        /// Triggers when the length of <see cref="string"/> value is not equal to the given <paramref name="length"/>.
        /// </summary>
        /// <param name="length">Number of characters to be allowed.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenLengthNotEqualTo(int length, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value starts with given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenStartWith(string value, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value starts with given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenStartWith(string value, StringComparison comparison, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value does not start with given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotStartWith(string value, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value does not start with given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotStartWith(string value, StringComparison comparison, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value ends with given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenEndWith(string value, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value ends with given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenEndWith(string value, StringComparison comparison, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value does not end with given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotEndWith(string value, string message = null);

        /// <summary>
        /// Triggers when the <see cref="string"/> value does not end with given <paramref name="value"/> with string comparison rules.
        /// </summary>
        /// <param name="value">String to be searched.</param>
        /// <param name="comparison">String comparison rule when performing validation.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public IStringValidatable WhenNotEndWith(string value, StringComparison comparison, string message = null);
    }
}
