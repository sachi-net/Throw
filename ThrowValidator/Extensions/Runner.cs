using System;
using System.Collections.Generic;
using ThrowValidator.Validations;

namespace ThrowValidator.Extensions
{
    /// <summary>
    /// Runner defines extensions for invoking custom actions based on validatable conditions.
    /// </summary>
    public static class Runner
    {
        #region sbyte
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="sbyte"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="sbyte"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="sbyte"/>.</returns>
        public static INumericValidatable<sbyte> Run(this sbyte value, Action action) => new NumericValidator<sbyte>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="sbyte"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="sbyte"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="sbyte"/>.</returns>
        public static INumericValidatable<sbyte> Run(this sbyte? value, Action action) => new NumericValidatorNullable<sbyte>(value, action);
        #endregion

        #region byte
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="byte"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="byte"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="byte"/>.</returns>
        public static INumericValidatable<byte> Run(this byte value, Action action) => new NumericValidator<byte>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="byte"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="byte"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="byte"/>.</returns>
        public static INumericValidatable<byte> Run(this byte? value, Action action) => new NumericValidatorNullable<byte>(value, action);
        #endregion

        #region short
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="short"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="short"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="short"/>.</returns>
        public static INumericValidatable<short> Run(this short value, Action action) => new NumericValidator<short>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="short"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="short"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="short"/>.</returns>
        public static INumericValidatable<short> Run(this short? value, Action action) => new NumericValidatorNullable<short>(value, action);
        #endregion

        #region ushort
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="ushort"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ushort"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ushort"/>.</returns>
        public static INumericValidatable<ushort> Run(this ushort value, Action action) => new NumericValidator<ushort>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="ushort"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ushort"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ushort"/>.</returns>
        public static INumericValidatable<ushort> Run(this ushort? value, Action action) => new NumericValidatorNullable<ushort>(value, action);
        #endregion

        #region int
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="int"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="int"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="int"/>.</returns>
        public static INumericValidatable<int> Run(this int value, Action action) => new NumericValidator<int>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="int"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="int"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="int"/>.</returns>
        public static INumericValidatable<int> Run(this int? value, Action action) => new NumericValidatorNullable<int>(value, action);
        #endregion

        #region uint
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="uint"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="uint"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="uint"/>.</returns>
        public static INumericValidatable<uint> Run(this uint value, Action action) => new NumericValidator<uint>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="uint"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="uint"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="uint"/>.</returns>
        public static INumericValidatable<uint> Run(this uint? value, Action action) => new NumericValidatorNullable<uint>(value, action);
        #endregion

        #region long
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="long"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="long"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="long"/>.</returns>
        public static INumericValidatable<long> Run(this long value, Action action) => new NumericValidator<long>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="long"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="long"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="long"/>.</returns>
        public static INumericValidatable<long> Run(this long? value, Action action) => new NumericValidatorNullable<long>(value, action);
        #endregion

        #region ulong
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="ulong"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ulong"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ulong"/>.</returns>
        public static INumericValidatable<ulong> Run(this ulong value, Action action) => new NumericValidator<ulong>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="ulong"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="ulong"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="ulong"/>.</returns>
        public static INumericValidatable<ulong> Run(this ulong? value, Action action) => new NumericValidatorNullable<ulong>(value, action);
        #endregion

        #region float
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="float"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="float"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="float"/>.</returns>
        public static INumericValidatable<float> Run(this float value, Action action) => new NumericValidator<float>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="float"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="float"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="float"/>.</returns>
        public static INumericValidatable<float> Run(this float? value, Action action) => new NumericValidatorNullable<float>(value, action);
        #endregion

        #region double
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="double"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="double"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="double"/>.</returns>
        public static INumericValidatable<double> Run(this double value, Action action) => new NumericValidator<double>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="double"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="double"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="double"/>.</returns>
        public static INumericValidatable<double> Run(this double? value, Action action) => new NumericValidatorNullable<double>(value, action);
        #endregion

        #region decimal
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="decimal"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="decimal"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="decimal"/>.</returns>
        public static INumericValidatable<decimal> Run(this decimal value, Action action) => new NumericValidator<decimal>(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="decimal"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="decimal"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator. T is <see cref="decimal"/>.</returns>
        public static INumericValidatable<decimal> Run(this decimal? value, Action action) => new NumericValidatorNullable<decimal>(value, action);
        #endregion

        #region string
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="string"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="string"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="IStringValidatable"/> with string validator.</returns>
        public static IStringValidatable Run(this string value, Action action) => new StringValidator(value, action);
        #endregion

        #region DateTime
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="DateTime"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="DateTime"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public static IDateTimeValidatable Run(this DateTime value, Action action) => new DateTimeValidator(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="DateTime"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="DateTime"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        public static IDateTimeValidatable Run(this DateTime? value, Action action) => new DateTimeValidator(value, action);
        #endregion

        #region bool
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="bool"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="bool"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public static IBooleanValidatable Run(this bool value, Action action) => new BooleanValidator(value, action);

        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="bool"/>? (nullable) struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="bool"/>? (nullable) instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
        public static IBooleanValidatable Run(this bool? value, Action action) => new BooleanValidator(value, action);
        #endregion

        #region enum
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="Enum"/> struct based on its <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of the <see cref="Enum"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
        public static IEnumValidatable Run(this Enum value, Action action) => new EnumValidator(value, action);
        #endregion

        #region custom-objects
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <typeparamref name="T"/> construct based on its <paramref name="value"/>.
        /// This extends all built-in and custom class type constructs when their type was not specified in other <see cref="Runner"/> extensions built for specific classes.
        /// </summary>
        /// <typeparam name="T">Class type construct.</typeparam>
        /// <param name="value">Value of the <typeparamref name="T"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with class validator.</returns>
        public static ICustomTypeValidatable<T> Run<T>(this T value, Action action) where T : class => new CustomValidator<T>(value, action);
        #endregion

        #region collections
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="ICollection{T}"/> construct based on its <paramref name="collection"/> items.
        /// </summary>
        /// <typeparam name="T">Class or struct type construct.</typeparam>
        /// <param name="collection">Collection list of <typeparamref name="T"/>.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="ICollectionValidatable{T}"/> with collection validator.</returns>
        public static ICollectionValidatable<T> Run<T>(this ICollection<T> collection, Action action) => new CollectionValidator<T>(collection, action);
        #endregion

        #region Type
        /// <summary>
        /// Initialize <see cref="Runner"/> for invoking <paramref name="action"/> on <see cref="Type"/> struct based on its <paramref name="type"/>.
        /// </summary>
        /// <param name="type">Value of the <see cref="Type"/> instance.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
        public static ITypeValidatable Run(this Type type, Action action) => new TypeValidator(type, action);
        #endregion

    }
}
