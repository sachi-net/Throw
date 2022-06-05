using System;
using ThrowValidator.Validations;

namespace ThrowValidator.Extensions
{
    public static class Thrower
    {
        #region sbyte
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

        public static NumericValidatorNullable<int> Throw(this int? value) => new NumericValidatorNullable<int>(value);

        public static NumericValidatorNullable<int> Throw(this int? value, string message) => new NumericValidatorNullable<int>(value, message);

        public static NumericValidatorNullable<int> Throw(this int? value, Exception exception) => new NumericValidatorNullable<int>(value, exception);
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

        public static NumericValidatorNullable<double> Throw(this double? value) => new NumericValidatorNullable<double>(value);

        public static NumericValidatorNullable<double> Throw(this double? value, string message) => new NumericValidatorNullable<double>(value, message);

        public static NumericValidatorNullable<double> Throw(this double? value, Exception exception) => new NumericValidatorNullable<double>(value, exception);
        #endregion

        #region decimal
        #endregion
    }
}
