using System;
using System.Collections.Generic;
using ThrowValidator.Validations;

namespace ThrowValidator.Extensions
{
    /// <summary>
    /// Thrower defines extensions for throwing exceptions based on validatable conditions.
    /// </summary>
    public static class Thrower
    {
        #region sbyte
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="sbyte"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="sbyte"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="sbyte"/>.</returns>
        public static INumericValidatable<sbyte> Throw(this sbyte value) => new NumericValidator<sbyte>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="sbyte"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="sbyte"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="sbyte"/>.</returns>
        public static INumericValidatable<sbyte> Throw(this sbyte value, string message) => new NumericValidator<sbyte>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="sbyte"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="sbyte"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="sbyte"/>.</returns>
        public static INumericValidatable<sbyte> Throw(this sbyte value, Exception exception) => new NumericValidator<sbyte>(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="sbyte"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="sbyte"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="sbyte"/>.</returns>
        public static INumericValidatable<sbyte> Throw(this sbyte? value) => new NumericValidatorNullable<sbyte>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="sbyte"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="sbyte"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="sbyte"/>.</returns>
        public static INumericValidatable<sbyte> Throw(this sbyte? value, string message) => new NumericValidatorNullable<sbyte>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="sbyte"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="sbyte"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="sbyte"/>.</returns>
        public static INumericValidatable<sbyte> Throw(this sbyte? value, Exception exception) => new NumericValidatorNullable<sbyte>(value, exception);
        #endregion

        #region byte
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="byte"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="byte"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="byte"/>.</returns>
        public static INumericValidatable<byte> Throw(this byte value) => new NumericValidator<byte>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="byte"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="byte"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="byte"/>.</returns>
        public static INumericValidatable<byte> Throw(this byte value, string message) => new NumericValidator<byte>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="byte"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="byte"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="byte"/>.</returns>
        public static INumericValidatable<byte> Throw(this byte value, Exception exception) => new NumericValidator<byte>(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="byte"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="byte"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="byte"/>.</returns>
        public static INumericValidatable<byte> Throw(this byte? value) => new NumericValidatorNullable<byte>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="byte"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="byte"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="byte"/>.</returns>
        public static INumericValidatable<byte> Throw(this byte? value, string message) => new NumericValidatorNullable<byte>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="byte"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="byte"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="byte"/>.</returns>
        public static INumericValidatable<byte> Throw(this byte? value, Exception exception) => new NumericValidatorNullable<byte>(value, exception);
        #endregion

        #region short
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="short"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="short"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="short"/>.</returns>
        public static INumericValidatable<short> Throw(this short value) => new NumericValidator<short>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="short"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="short"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="short"/>.</returns>
        public static INumericValidatable<short> Throw(this short value, string message) => new NumericValidator<short>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="short"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="short"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="short"/>.</returns>
        public static INumericValidatable<short> Throw(this short value, Exception exception) => new NumericValidator<short>(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="short"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="short"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="short"/>.</returns>
        public static INumericValidatable<short> Throw(this short? value) => new NumericValidatorNullable<short>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="short"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="short"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="short"/>.</returns>
        public static INumericValidatable<short> Throw(this short? value, string message) => new NumericValidatorNullable<short>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="short"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="short"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="short"/>.</returns>
        public static INumericValidatable<short> Throw(this short? value, Exception exception) => new NumericValidatorNullable<short>(value, exception);
        #endregion

        #region ushort
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="ushort"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ushort"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ushort"/>.</returns>
        public static INumericValidatable<ushort> Throw(this ushort value) => new NumericValidator<ushort>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="ushort"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ushort"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ushort"/>.</returns>
        public static INumericValidatable<ushort> Throw(this ushort value, string message) => new NumericValidator<ushort>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="ushort"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ushort"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ushort"/>.</returns>
        public static INumericValidatable<ushort> Throw(this ushort value, Exception exception) => new NumericValidator<ushort>(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="ushort"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ushort"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ushort"/>.</returns>
        public static INumericValidatable<ushort> Throw(this ushort? value) => new NumericValidatorNullable<ushort>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="ushort"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ushort"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ushort"/>.</returns>
        public static INumericValidatable<ushort> Throw(this ushort? value, string message) => new NumericValidatorNullable<ushort>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="ushort"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ushort"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ushort"/>.</returns>
        public static INumericValidatable<ushort> Throw(this ushort? value, Exception exception) => new NumericValidatorNullable<ushort>(value, exception);
        #endregion

        #region int
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="int"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="int"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="int"/>.</returns>
        public static INumericValidatable<int> Throw(this int value) => new NumericValidator<int>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="int"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="int"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="int"/>.</returns>
        public static INumericValidatable<int> Throw(this int value, string message) => new NumericValidator<int>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="int"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="int"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="int"/>.</returns>
        public static INumericValidatable<int> Throw(this int value, Exception exception) => new NumericValidator<int>(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="int"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="int"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="int"/>.</returns>
        public static INumericValidatable<int> Throw(this int? value) => new NumericValidatorNullable<int>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="int"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="int"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="int"/>.</returns>
        public static INumericValidatable<int> Throw(this int? value, string message) => new NumericValidatorNullable<int>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="int"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="int"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="int"/>.</returns>
        public static INumericValidatable<int> Throw(this int? value, Exception exception) => new NumericValidatorNullable<int>(value, exception);
        #endregion

        #region uint
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="uint"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="uint"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="uint"/>.</returns>
        public static INumericValidatable<uint> Throw(this uint value) => new NumericValidator<uint>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="uint"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="uint"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="uint"/>.</returns>
        public static INumericValidatable<uint> Throw(this uint value, string message) => new NumericValidator<uint>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="uint"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="uint"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="uint"/>.</returns>
        public static INumericValidatable<uint> Throw(this uint value, Exception exception) => new NumericValidator<uint>(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="uint"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="uint"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="uint"/>.</returns>
        public static INumericValidatable<uint> Throw(this uint? value) => new NumericValidatorNullable<uint>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="uint"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="uint"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="uint"/>.</returns>
        public static INumericValidatable<uint> Throw(this uint? value, string message) => new NumericValidatorNullable<uint>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="uint"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="uint"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="uint"/>.</returns>
        public static INumericValidatable<uint> Throw(this uint? value, Exception exception) => new NumericValidatorNullable<uint>(value, exception);
        #endregion

        #region long
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="long"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="long"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="long"/>.</returns>
        public static INumericValidatable<long> Throw(this long value) => new NumericValidator<long>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="long"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="long"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="long"/>.</returns>
        public static INumericValidatable<long> Throw(this long value, string message) => new NumericValidator<long>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="long"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="long"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="long"/>.</returns>
        public static INumericValidatable<long> Throw(this long value, Exception exception) => new NumericValidator<long>(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="long"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="long"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="long"/>.</returns>
        public static INumericValidatable<long> Throw(this long? value) => new NumericValidatorNullable<long>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="long"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="long"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="long"/>.</returns>
        public static INumericValidatable<long> Throw(this long? value, string message) => new NumericValidatorNullable<long>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="long"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="long"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="long"/>.</returns>
        public static INumericValidatable<long> Throw(this long? value, Exception exception) => new NumericValidatorNullable<long>(value, exception);
        #endregion

        #region ulong
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="ulong"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ulong"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ulong"/>.</returns>
        public static INumericValidatable<ulong> Throw(this ulong value) => new NumericValidator<ulong>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="ulong"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ulong"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ulong"/>.</returns>
        public static INumericValidatable<ulong> Throw(this ulong value, string message) => new NumericValidator<ulong>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="ulong"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ulong"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ulong"/>.</returns>
        public static INumericValidatable<ulong> Throw(this ulong value, Exception exception) => new NumericValidator<ulong>(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="ulong"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ulong"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ulong"/>.</returns>
        public static INumericValidatable<ulong> Throw(this ulong? value) => new NumericValidatorNullable<ulong>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="ulong"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ulong"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ulong"/>.</returns>
        public static INumericValidatable<ulong> Throw(this ulong? value, string message) => new NumericValidatorNullable<ulong>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="ulong"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ulong"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ulong"/>.</returns>
        public static INumericValidatable<ulong> Throw(this ulong? value, Exception exception) => new NumericValidatorNullable<ulong>(value, exception);
        #endregion

        #region float
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="float"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="float"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="float"/>.</returns>
        public static INumericValidatable<float> Throw(this float value) => new NumericValidator<float>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="float"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="float"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="float"/>.</returns>
        public static INumericValidatable<float> Throw(this float value, string message) => new NumericValidator<float>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="float"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="float"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="float"/>.</returns>
        public static INumericValidatable<float> Throw(this float value, Exception exception) => new NumericValidator<float>(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="float"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="float"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="float"/>.</returns>
        public static INumericValidatable<float> Throw(this float? value) => new NumericValidatorNullable<float>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="float"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="float"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="float"/>.</returns>
        public static INumericValidatable<float> Throw(this float? value, string message) => new NumericValidatorNullable<float>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="float"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="float"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="float"/>.</returns>
        public static INumericValidatable<float> Throw(this float? value, Exception exception) => new NumericValidatorNullable<float>(value, exception);
        #endregion

        #region double
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="double"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="double"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="double"/>.</returns>
        public static INumericValidatable<double> Throw(this double value) => new NumericValidator<double>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="double"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="double"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="double"/>.</returns>
        public static INumericValidatable<double> Throw(this double value, string message) => new NumericValidator<double>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="double"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="double"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="double"/>.</returns>
        public static INumericValidatable<double> Throw(this double value, Exception exception) => new NumericValidator<double>(value, exception);
        
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="double"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="double"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="double"/>.</returns>
        public static INumericValidatable<double> Throw(this double? value) => new NumericValidatorNullable<double>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="double"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="double"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="double"/>.</returns>
        public static INumericValidatable<double> Throw(this double? value, string message) => new NumericValidatorNullable<double>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="double"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="double"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="double"/>.</returns>
        public static INumericValidatable<double> Throw(this double? value, Exception exception) => new NumericValidatorNullable<double>(value, exception);
        #endregion

        #region decimal
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="decimal"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="decimal"/> instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="decimal"/>.</returns>
        public static INumericValidatable<decimal> Throw(this decimal value) => new NumericValidator<decimal>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="decimal"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="decimal"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="decimal"/>.</returns>
        public static INumericValidatable<decimal> Throw(this decimal value, string message) => new NumericValidator<decimal>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="decimal"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="decimal"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="decimal"/>.</returns>
        public static INumericValidatable<decimal> Throw(this decimal value, Exception exception) => new NumericValidator<decimal>(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="decimal"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="decimal"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="decimal"/>.</returns>
        public static INumericValidatable<decimal> Throw(this decimal? value) => new NumericValidatorNullable<decimal>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="decimal"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="decimal"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="decimal"/>.</returns>
        public static INumericValidatable<decimal> Throw(this decimal? value, string message) => new NumericValidatorNullable<decimal>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="decimal"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="decimal"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="decimal"/>.</returns>
        public static INumericValidatable<decimal> Throw(this decimal? value, Exception exception) => new NumericValidatorNullable<decimal>(value, exception);
        #endregion

        #region string
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="string"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="string"/> instance.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public static IStringValidatable Throw(this string value) => new StringValidator(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="string"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="string"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public static IStringValidatable Throw(this string value, string message) => new StringValidator(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="string"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="string"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public static IStringValidatable Throw(this string value, Exception exception) => new StringValidator(value, exception);
        #endregion

        #region DateTime
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="DateTime"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="DateTime"/> instance.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public static IDateTimeValidatable Throw(this DateTime value) => new DateTimeValidator(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="DateTime"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="DateTime"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public static IDateTimeValidatable Throw(this DateTime value, string message) => new DateTimeValidator(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="DateTime"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="DateTime"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public static IDateTimeValidatable Throw(this DateTime value, Exception exception) => new DateTimeValidator(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="DateTime"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="DateTime"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public static IDateTimeValidatable Throw(this DateTime? value) => new DateTimeValidator(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="DateTime"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="DateTime"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public static IDateTimeValidatable Throw(this DateTime? value, string message) => new DateTimeValidator(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="DateTime"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="DateTime"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public static IDateTimeValidatable Throw(this DateTime? value, Exception exception) => new DateTimeValidator(value, exception);
        #endregion

        #region bool
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="bool"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="bool"/> instance.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public static IBooleanValidatable Throw(this bool value) => new BooleanValidator(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="bool"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="bool"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public static IBooleanValidatable Throw(this bool value, string message) => new BooleanValidator(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="bool"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="bool"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public static IBooleanValidatable Throw(this bool value, Exception exception) => new BooleanValidator(value, exception);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="bool"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="bool"/>? (nullable) instance.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public static IBooleanValidatable Throw(this bool? value) => new BooleanValidator(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="bool"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="bool"/>? (nullable) instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public static IBooleanValidatable Throw(this bool? value, string message) => new BooleanValidator(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="bool"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="bool"/>? (nullable) instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public static IBooleanValidatable Throw(this bool? value, Exception exception) => new BooleanValidator(value, exception);
        #endregion

        #region enum
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="Enum"/> construct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="Enum"/> instance.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
        public static IEnumValidatable Throw(this Enum value) => new EnumValidator(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="Enum"/> construct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="Enum"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
        public static IEnumValidatable Throw(this Enum value, string message) => new EnumValidator(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="Enum"/> construct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="Enum"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
        public static IEnumValidatable Throw(this Enum value, Exception exception) => new EnumValidator(value, exception);
        #endregion

        #region custom-objects
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <typeparamref name="T"/> construct based on its <paramref name="value"/>.
        /// This extends all built-in and custom class type constructs when their type was not specified in other <see cref="Thrower"/> extensions built for specific classes.
        /// </summary>
        /// <typeparam name="T">Class type construct.</typeparam>
        /// <param name="value">Value of the <typeparamref name="T"/> instance.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with class validator.</returns>
        public static ICustomTypeValidatable<T> Throw<T>(this T value) where T : class => new CustomValidator<T>(value);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <typeparamref name="T"/> construct based on its <paramref name="value"/>.
        /// This extends all built-in and custom class type constructs when their type was not specified in other <see cref="Thrower"/> extensions built for specific classes.
        /// </summary>
        /// <typeparam name="T">Class type construct.</typeparam>
        /// <param name="value">Value of the <typeparamref name="T"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with class validator.</returns>
        public static ICustomTypeValidatable<T> Throw<T>(this T value, string message) where T : class => new CustomValidator<T>(value, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <typeparamref name="T"/> construct based on its <paramref name="value"/>.
        /// This extends all built-in and custom class type constructs when their type was not specified in other <see cref="Thrower"/> extensions built for specific classes.
        /// </summary>
        /// <typeparam name="T">Class type construct.</typeparam>
        /// <param name="value">Value of the <typeparamref name="T"/> instance.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with class validator.</returns>
        public static ICustomTypeValidatable<T> Throw<T>(this T value, Exception exception) where T : class => new CustomValidator<T>(value, exception);
        #endregion

        #region collections
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="ICollection{T}"/> construct based on its <paramref name="collection"/> items.
        /// </summary>
        /// <typeparam name="T">Class or struct type construct.</typeparam>
        /// <param name="collection">Collection list of <typeparamref name="T"/>.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public static ICollectionValidatable<T> Throw<T>(this ICollection<T> collection) => new CollectionValidator<T>(collection);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="ICollection{T}"/> construct based on its <paramref name="collection"/> items.
        /// </summary>
        /// <typeparam name="T">Class or struct type construct.</typeparam>
        /// <param name="collection">Collection list of <typeparamref name="T"/>.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public static ICollectionValidatable<T> Throw<T>(this ICollection<T> collection, string message) => new CollectionValidator<T>(collection, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="ICollection{T}"/> construct based on its <paramref name="collection"/> items.
        /// </summary>
        /// <typeparam name="T">Class or struct type construct.</typeparam>
        /// <param name="collection">Collection list of <typeparamref name="T"/>.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public static ICollectionValidatable<T> Throw<T>(this ICollection<T> collection, Exception exception) => new CollectionValidator<T>(collection, exception);
        #endregion

        #region Type
        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception on <see cref="Type"/> construct based on its <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type as <see cref="Type"/> instance.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
        public static ITypeValidatable Throw(this Type type) => new TypeValidator(type);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="message"/> on <see cref="Type"/> construct based on its <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type as <see cref="Type"/> instance.</param>
        /// <param name="message">Custom message in the default exception.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
        public static ITypeValidatable Throw(this Type type, string message) => new TypeValidator(type, message);

        /// <summary>
        /// Initialize <see cref="Thrower"/> for throwing exception with custom <paramref name="exception"/> on <see cref="Type"/> construct based on its <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type as <see cref="Type"/> instance.</param>
        /// <param name="exception"></param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
        public static ITypeValidatable Throw(this Type type, Exception exception) => new TypeValidator(type, exception);
        #endregion
    }
}
