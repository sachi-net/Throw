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
        #endregion

        #region short
        #endregion

        #region ushort
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
