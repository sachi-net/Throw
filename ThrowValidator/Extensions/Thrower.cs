using System;
using ThrowValidator.Validations;

namespace ThrowValidator.Extensions
{
    public static class Thrower
    {
        #region sbyte
        public static INumericValidatable<sbyte> Throw(this sbyte value) => new NumericValidator<sbyte>(value);

        public static INumericValidatable<sbyte> Throw(this sbyte value, string message) => new NumericValidator<sbyte>(value, message);

        public static INumericValidatable<sbyte> Throw(this sbyte value, Exception exception) => new NumericValidator<sbyte>(value, exception);

        public static INumericValidatable<sbyte> Throw(this sbyte? value) => new NumericValidatorNullable<sbyte>(value);

        public static INumericValidatable<sbyte> Throw(this sbyte? value, string message) => new NumericValidatorNullable<sbyte>(value, message);

        public static INumericValidatable<sbyte> Throw(this sbyte? value, Exception exception) => new NumericValidatorNullable<sbyte>(value, exception);
        #endregion

        #region byte
        public static INumericValidatable<byte> Throw(this byte value) => new NumericValidator<byte>(value);

        public static INumericValidatable<byte> Throw(this byte value, string message) => new NumericValidator<byte>(value, message);

        public static INumericValidatable<byte> Throw(this byte value, Exception exception) => new NumericValidator<byte>(value, exception);

        public static INumericValidatable<byte> Throw(this byte? value) => new NumericValidatorNullable<byte>(value);

        public static INumericValidatable<byte> Throw(this byte? value, string message) => new NumericValidatorNullable<byte>(value, message);

        public static INumericValidatable<byte> Throw(this byte? value, Exception exception) => new NumericValidatorNullable<byte>(value, exception);
        #endregion

        #region short
        public static INumericValidatable<short> Throw(this short value) => new NumericValidator<short>(value);

        public static INumericValidatable<short> Throw(this short value, string message) => new NumericValidator<short>(value, message);

        public static INumericValidatable<short> Throw(this short value, Exception exception) => new NumericValidator<short>(value, exception);

        public static INumericValidatable<short> Throw(this short? value) => new NumericValidatorNullable<short>(value);

        public static INumericValidatable<short> Throw(this short? value, string message) => new NumericValidatorNullable<short>(value, message);

        public static INumericValidatable<short> Throw(this short? value, Exception exception) => new NumericValidatorNullable<short>(value, exception);
        #endregion

        #region ushort
        public static INumericValidatable<ushort> Throw(this ushort value) => new NumericValidator<ushort>(value);

        public static INumericValidatable<ushort> Throw(this ushort value, string message) => new NumericValidator<ushort>(value, message);

        public static INumericValidatable<ushort> Throw(this ushort value, Exception exception) => new NumericValidator<ushort>(value, exception);

        public static INumericValidatable<ushort> Throw(this ushort? value) => new NumericValidatorNullable<ushort>(value);

        public static INumericValidatable<ushort> Throw(this ushort? value, string message) => new NumericValidatorNullable<ushort>(value, message);

        public static INumericValidatable<ushort> Throw(this ushort? value, Exception exception) => new NumericValidatorNullable<ushort>(value, exception);
        #endregion

        #region int
        public static INumericValidatable<int> Throw(this int value) => new NumericValidator<int>(value);

        public static INumericValidatable<int> Throw(this int value, string message) => new NumericValidator<int>(value, message);

        public static INumericValidatable<int> Throw(this int value, Exception exception) => new NumericValidator<int>(value, exception);

        public static INumericValidatable<int> Throw(this int? value) => new NumericValidatorNullable<int>(value);

        public static INumericValidatable<int> Throw(this int? value, string message) => new NumericValidatorNullable<int>(value, message);

        public static INumericValidatable<int> Throw(this int? value, Exception exception) => new NumericValidatorNullable<int>(value, exception);
        #endregion

        #region uint
        public static INumericValidatable<uint> Throw(this uint value) => new NumericValidator<uint>(value);

        public static INumericValidatable<uint> Throw(this uint value, string message) => new NumericValidator<uint>(value, message);

        public static INumericValidatable<uint> Throw(this uint value, Exception exception) => new NumericValidator<uint>(value, exception);

        public static INumericValidatable<uint> Throw(this uint? value) => new NumericValidatorNullable<uint>(value);

        public static INumericValidatable<uint> Throw(this uint? value, string message) => new NumericValidatorNullable<uint>(value, message);

        public static INumericValidatable<uint> Throw(this uint? value, Exception exception) => new NumericValidatorNullable<uint>(value, exception);
        #endregion

        #region long
        public static INumericValidatable<long> Throw(this long value) => new NumericValidator<long>(value);

        public static INumericValidatable<long> Throw(this long value, string message) => new NumericValidator<long>(value, message);

        public static INumericValidatable<long> Throw(this long value, Exception exception) => new NumericValidator<long>(value, exception);

        public static INumericValidatable<long> Throw(this long? value) => new NumericValidatorNullable<long>(value);

        public static INumericValidatable<long> Throw(this long? value, string message) => new NumericValidatorNullable<long>(value, message);

        public static INumericValidatable<long> Throw(this long? value, Exception exception) => new NumericValidatorNullable<long>(value, exception);
        #endregion

        #region ulong
        public static INumericValidatable<ulong> Throw(this ulong value) => new NumericValidator<ulong>(value);

        public static INumericValidatable<ulong> Throw(this ulong value, string message) => new NumericValidator<ulong>(value, message);

        public static INumericValidatable<ulong> Throw(this ulong value, Exception exception) => new NumericValidator<ulong>(value, exception);

        public static INumericValidatable<ulong> Throw(this ulong? value) => new NumericValidatorNullable<ulong>(value);

        public static INumericValidatable<ulong> Throw(this ulong? value, string message) => new NumericValidatorNullable<ulong>(value, message);

        public static INumericValidatable<ulong> Throw(this ulong? value, Exception exception) => new NumericValidatorNullable<ulong>(value, exception);
        #endregion

        #region float
        public static INumericValidatable<float> Throw(this float value) => new NumericValidator<float>(value);

        public static INumericValidatable<float> Throw(this float value, string message) => new NumericValidator<float>(value, message);

        public static INumericValidatable<float> Throw(this float value, Exception exception) => new NumericValidator<float>(value, exception);

        public static INumericValidatable<float> Throw(this float? value) => new NumericValidatorNullable<float>(value);

        public static INumericValidatable<float> Throw(this float? value, string message) => new NumericValidatorNullable<float>(value, message);

        public static INumericValidatable<float> Throw(this float? value, Exception exception) => new NumericValidatorNullable<float>(value, exception);
        #endregion

        #region double
        public static INumericValidatable<double> Throw(this double value) => new NumericValidator<double>(value);

        public static INumericValidatable<double> Throw(this double value, string message) => new NumericValidator<double>(value, message);

        public static INumericValidatable<double> Throw(this double value, Exception exception) => new NumericValidator<double>(value, exception);

        public static INumericValidatable<double> Throw(this double? value) => new NumericValidatorNullable<double>(value);

        public static INumericValidatable<double> Throw(this double? value, string message) => new NumericValidatorNullable<double>(value, message);

        public static INumericValidatable<double> Throw(this double? value, Exception exception) => new NumericValidatorNullable<double>(value, exception);
        #endregion

        #region decimal
        public static INumericValidatable<decimal> Throw(this decimal value) => new NumericValidator<decimal>(value);

        public static INumericValidatable<decimal> Throw(this decimal value, string message) => new NumericValidator<decimal>(value, message);

        public static INumericValidatable<decimal> Throw(this decimal value, Exception exception) => new NumericValidator<decimal>(value, exception);

        public static INumericValidatable<decimal> Throw(this decimal? value) => new NumericValidatorNullable<decimal>(value);

        public static INumericValidatable<decimal> Throw(this decimal? value, string message) => new NumericValidatorNullable<decimal>(value, message);

        public static INumericValidatable<decimal> Throw(this decimal? value, Exception exception) => new NumericValidatorNullable<decimal>(value, exception);
        #endregion

        #region string
        public static IStringValidatable Throw(this string value) => new StringValidator(value);

        public static IStringValidatable Throw(this string value, string message) => new StringValidator(value, message);

        public static IStringValidatable Throw(this string value, Exception exception) => new StringValidator(value, exception);
        #endregion

        #region DateTime
        public static IDateTimeValidatable Throw(this DateTime value) => new DateTimeValidator(value);

        public static IDateTimeValidatable Throw(this DateTime value, string message) => new DateTimeValidator(value, message);

        public static IDateTimeValidatable Throw(this DateTime value, Exception exception) => new DateTimeValidator(value, exception);

        public static IDateTimeValidatable Throw(this DateTime? value) => new DateTimeValidator(value);

        public static IDateTimeValidatable Throw(this DateTime? value, string message) => new DateTimeValidator(value, message);

        public static IDateTimeValidatable Throw(this DateTime? value, Exception exception) => new DateTimeValidator(value, exception);
        #endregion

        #region bool
        public static IBooleanValidatable Throw(this bool value) => new BooleanValidator(value);

        public static IBooleanValidatable Throw(this bool value, string message) => new BooleanValidator(value, message);

        public static IBooleanValidatable Throw(this bool value, Exception exception) => new BooleanValidator(value, exception);

        public static IBooleanValidatable Throw(this bool? value) => new BooleanValidator(value);

        public static IBooleanValidatable Throw(this bool? value, string message) => new BooleanValidator(value, message);

        public static IBooleanValidatable Throw(this bool? value, Exception exception) => new BooleanValidator(value, exception);
        #endregion
    }
}
