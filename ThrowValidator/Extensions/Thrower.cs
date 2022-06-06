using System;
using ThrowValidator.Validations;

namespace ThrowValidator.Extensions
{
    public static class Thrower
    {
        #region sbyte
        public static INumericValidator<sbyte> Throw(this sbyte value) => new NumericValidator<sbyte>(value);

        public static INumericValidator<sbyte> Throw(this sbyte value, string message) => new NumericValidator<sbyte>(value, message);

        public static INumericValidator<sbyte> Throw(this sbyte value, Exception exception) => new NumericValidator<sbyte>(value, exception);

        public static INumericValidator<sbyte> Throw(this sbyte? value) => new NumericValidatorNullable<sbyte>(value);

        public static INumericValidator<sbyte> Throw(this sbyte? value, string message) => new NumericValidatorNullable<sbyte>(value, message);

        public static INumericValidator<sbyte> Throw(this sbyte? value, Exception exception) => new NumericValidatorNullable<sbyte>(value, exception);
        #endregion

        #region byte
        public static INumericValidator<byte> Throw(this byte value) => new NumericValidator<byte>(value);

        public static INumericValidator<byte> Throw(this byte value, string message) => new NumericValidator<byte>(value, message);

        public static INumericValidator<byte> Throw(this byte value, Exception exception) => new NumericValidator<byte>(value, exception);

        public static INumericValidator<byte> Throw(this byte? value) => new NumericValidatorNullable<byte>(value);

        public static INumericValidator<byte> Throw(this byte? value, string message) => new NumericValidatorNullable<byte>(value, message);

        public static INumericValidator<byte> Throw(this byte? value, Exception exception) => new NumericValidatorNullable<byte>(value, exception);
        #endregion

        #region short
        public static INumericValidator<short> Throw(this short value) => new NumericValidator<short>(value);

        public static INumericValidator<short> Throw(this short value, string message) => new NumericValidator<short>(value, message);

        public static INumericValidator<short> Throw(this short value, Exception exception) => new NumericValidator<short>(value, exception);

        public static INumericValidator<short> Throw(this short? value) => new NumericValidatorNullable<short>(value);

        public static INumericValidator<short> Throw(this short? value, string message) => new NumericValidatorNullable<short>(value, message);

        public static INumericValidator<short> Throw(this short? value, Exception exception) => new NumericValidatorNullable<short>(value, exception);
        #endregion

        #region ushort
        public static INumericValidator<ushort> Throw(this ushort value) => new NumericValidator<ushort>(value);

        public static INumericValidator<ushort> Throw(this ushort value, string message) => new NumericValidator<ushort>(value, message);

        public static INumericValidator<ushort> Throw(this ushort value, Exception exception) => new NumericValidator<ushort>(value, exception);

        public static INumericValidator<ushort> Throw(this ushort? value) => new NumericValidatorNullable<ushort>(value);

        public static INumericValidator<ushort> Throw(this ushort? value, string message) => new NumericValidatorNullable<ushort>(value, message);

        public static INumericValidator<ushort> Throw(this ushort? value, Exception exception) => new NumericValidatorNullable<ushort>(value, exception);
        #endregion

        #region int
        public static INumericValidator<int> Throw(this int value) => new NumericValidator<int>(value);

        public static INumericValidator<int> Throw(this int value, string message) => new NumericValidator<int>(value, message);

        public static INumericValidator<int> Throw(this int value, Exception exception) => new NumericValidator<int>(value, exception);

        public static INumericValidator<int> Throw(this int? value) => new NumericValidatorNullable<int>(value);

        public static INumericValidator<int> Throw(this int? value, string message) => new NumericValidatorNullable<int>(value, message);

        public static INumericValidator<int> Throw(this int? value, Exception exception) => new NumericValidatorNullable<int>(value, exception);
        #endregion

        #region uint
        #endregion

        #region long
        #endregion

        #region ulong
        #endregion

        #region nint
        #endregion

        #region nuint
        #endregion

        #region float
        #endregion

        #region double
        public static INumericValidator<double> Throw(this double value) => new NumericValidator<double>(value);

        public static INumericValidator<double> Throw(this double value, string message) => new NumericValidator<double>(value, message);

        public static INumericValidator<double> Throw(this double value, Exception exception) => new NumericValidator<double>(value, exception);

        public static INumericValidator<double> Throw(this double? value) => new NumericValidatorNullable<double>(value);

        public static INumericValidator<double> Throw(this double? value, string message) => new NumericValidatorNullable<double>(value, message);

        public static INumericValidator<double> Throw(this double? value, Exception exception) => new NumericValidatorNullable<double>(value, exception);
        #endregion

        #region decimal
        #endregion
    }
}
