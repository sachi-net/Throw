using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThrowValidator.Validations;

namespace ThrowValidator.Extensions
{
    public static class Runner
    {
        #region sbyte
        public static INumericValidatable<sbyte> Run(this sbyte value, Action action) => new NumericValidator<sbyte>(value, action);

        public static INumericValidatable<sbyte> Run(this sbyte? value, Action action) => new NumericValidatorNullable<sbyte>(value, action);
        #endregion

        #region byte
        public static INumericValidatable<byte> Run(this byte value, Action action) => new NumericValidator<byte>(value, action);

        public static INumericValidatable<byte> Run(this byte? value, Action action) => new NumericValidatorNullable<byte>(value, action);
        #endregion

        #region short
        public static INumericValidatable<short> Run(this short value, Action action) => new NumericValidator<short>(value, action);

        public static INumericValidatable<short> Run(this short? value, Action action) => new NumericValidatorNullable<short>(value, action);
        #endregion

        #region ushort
        public static INumericValidatable<ushort> Run(this ushort value, Action action) => new NumericValidator<ushort>(value, action);

        public static INumericValidatable<ushort> Run(this ushort? value, Action action) => new NumericValidatorNullable<ushort>(value, action);
        #endregion

        #region int
        public static INumericValidatable<int> Run(this int value, Action action) => new NumericValidator<int>(value, action);

        public static INumericValidatable<int> Run(this int? value, Action action) => new NumericValidatorNullable<int>(value, action);
        #endregion

        #region uint
        public static INumericValidatable<uint> Run(this uint value, Action action) => new NumericValidator<uint>(value, action);

        public static INumericValidatable<uint> Run(this uint? value, Action action) => new NumericValidatorNullable<uint>(value, action);
        #endregion

        #region long
        public static INumericValidatable<long> Run(this long value, Action action) => new NumericValidator<long>(value, action);

        public static INumericValidatable<long> Run(this long? value, Action action) => new NumericValidatorNullable<long>(value, action);
        #endregion

        #region ulong
        public static INumericValidatable<ulong> Run(this ulong value, Action action) => new NumericValidator<ulong>(value, action);

        public static INumericValidatable<ulong> Run(this ulong? value, Action action) => new NumericValidatorNullable<ulong>(value, action);
        #endregion

        #region float
        public static INumericValidatable<float> Run(this float value, Action action) => new NumericValidator<float>(value, action);

        public static INumericValidatable<float> Run(this float? value, Action action) => new NumericValidatorNullable<float>(value, action);
        #endregion

        #region double
        public static INumericValidatable<double> Run(this double value, Action action) => new NumericValidator<double>(value, action);

        public static INumericValidatable<double> Run(this double? value, Action action) => new NumericValidatorNullable<double>(value, action);
        #endregion

        #region decimal
        public static INumericValidatable<decimal> Run(this decimal value, Action action) => new NumericValidator<decimal>(value, action);

        public static INumericValidatable<decimal> Run(this decimal? value, Action action) => new NumericValidatorNullable<decimal>(value, action);
        #endregion

        #region string
        public static IStringValidatable Run(this string value, Action action) => new StringValidator(value, action);
        #endregion

        #region DateTime
        public static IDateTimeValidatable Run(this DateTime value, Action action) => new DateTimeValidator(value, action);

        public static IDateTimeValidatable Run(this DateTime? value, Action action) => new DateTimeValidator(value, action);
        #endregion

        #region bool
        public static IBooleanValidatable Run(this bool value, Action action) => new BooleanValidator(value, action);

        public static IBooleanValidatable Run(this bool? value, Action action) => new BooleanValidator(value, action);
        #endregion

        #region enum
        public static IEnumValidatable Run(this Enum value, Action action) => new EnumValidator(value, action);
        #endregion

        #region custom-objects
        public static ICustomTypeValidatable<T> Run<T>(this T value, Action action) where T : class => new CustomValidator<T>(value, action);
        #endregion

        #region collections
        public static ICollectionValidatable<T> Run<T>(this ICollection<T> value, Action action) => new CollectionValidator<T>(value, action);
        #endregion

        #region Type
        public static ITypeValidatable Run(this Type value, Action action) => new TypeValidator(value, action);
        #endregion

    }
}
