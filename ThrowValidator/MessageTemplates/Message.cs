﻿namespace ThrowValidator.MessageTemplates
{
    internal class Message
    {
        internal const string NULL = "Value cannot be null.";
        internal const string EQUALS = "Value cannot equal to '{0}'.";
        internal const string NOT_EQUALS = "Value is not equal to '{0}'.";
        internal const string GREATER = "Value cannot greater than '{0}'.";
        internal const string GREATER_EQ = "Value cannot greater than or equal to '{0}'.";
        internal const string LESSER = "Value cannot less than '{0}'.";
        internal const string LESSER_EQ = "Value cannot less than or equal to '{0}'.";
        internal const string POSITIVE = "Value cannot be positive.";
        internal const string NEGATIVE = "Value cannot be negative.";
        internal const string ZERO = "Value cannot be zero.";
        internal const string CONDITION = "The condition does not meet.";
        internal const string IN_RANGE = "Value cannot be in range of {0} with '{1}'.";
        internal const string OUT_OF_RANGE = "Value cannot be out of range of {0} with '{1}'.";

        internal const string WHITESPACES = "Value cannot contain only white-spaces.";
        internal const string EMPTY_STRING = "Value cannot be an empty string.";
        internal const string EQUALS_STRING = "Value cannot equal to the given string.";
        internal const string NOT_EQUALS_STRING = "Value is not equal to the given string.";
        internal const string LENGTH_EQUALS = "Value length cannot equal to '{0}'.";
        internal const string LENGTH_NOT_EQUALS = "Value length is not equal to '{0}'.";
        internal const string MAX_LENGTH = "Value length cannot exceed the maximum length of '{0}'.";
        internal const string MIN_LENGTH = "Value length is not up to the minimum length of '{0}'.";
        internal const string PATTERN_MATCH = "Value cannot match with the given pattern.";
        internal const string PATTERN_NOT_MATCH = "Value does not matched with the given pattern.";
        internal const string STRING_CONTAINS = "Value cannot contain '{0}'.";
        internal const string STRING_NOT_CONTAINS = "Value does not contain '{0}'.";
        internal const string STRING_STARTS_WITH = "Value cannot start with '{0}'.";
        internal const string STRING_NOT_STARTS_WITH = "Value does not start with '{0}'.";
        internal const string STRING_ENDS_WITH = "Value cannot end with '{0}'.";
        internal const string STRING_NOT_ENDS_WITH = "Value does not end with '{0}'.";

        internal const string TRUE = "Value cannot be true.";
        internal const string FALSE = "Value cannot be false.";

        internal const string ENUM_OUT_OF_RANGE = "Index '{0}' is not defined in '{1}' enumeration.";

        internal const string PREDICATE_MEET = "The condition does not meet by satisfying the rule.";
        internal const string PREDICATE_NOT_MEET = "The condition does not meet by not satisfying the rule.";

        internal const string LIST_CONTAIN = "Collection cannot contain the value.";
        internal const string LIST_NOT_CONTAIN = "Value not found in the collection.";
        internal const string LIST_COUNT_EQUALS = "Collection element count cannot equal to '{0}'.";
        internal const string LIST_COUNT_NOT_EQUALS = "Collection element count does not equal to '{0}'.";
        internal const string LIST_COUNT_LESSER = "Collection element count cannot less than '{0}'.";
        internal const string LIST_COUNT_LESSER_EQ = "Collection element count cannot less than or equal to '{0}'.";
        internal const string LIST_COUNT_GREATER = "Collection element count cannot greater than '{0}'.";
        internal const string LIST_COUNT_GREATER_EQ = "Collection element count cannot greater than or equal to '{0}'.";
        internal const string LIST_EMPTY = "Collection cannot be empty.";
        internal const string LIST_NOT_EMPTY = "Collection is not empty.";
        internal const string LIST_NULL = "Collection cannot be null.";
        internal const string LIST_ANY = "Collection cannot contain any element which satisfies the rule.";

        internal const string TYPE_NULL = "Type cannot be null.";
        internal const string TYPE_EQUALS = "Type cannot equal to '{0}'.";
        internal const string TYPE_NOT_EQUALS = "Type is not equal to '{0}'.";
    }
}
