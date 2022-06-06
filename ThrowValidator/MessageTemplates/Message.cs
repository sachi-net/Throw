namespace ThrowValidator.MessageTemplates
{
    internal class Message
    {
        internal const string NULL = "Value cannot be null.";
        internal const string EQUALS = "Value cannot be equal to \'{0}\'.";
        internal const string NOT_EQUALS = "Value is not equal to \'{0}\'.";
        internal const string GREATER = "Value cannot be greater than \'{0}\'.";
        internal const string GREATER_EQ = "Value cannot be greater than or equal to \'{0}\'.";
        internal const string LESSER = "Value cannot be less than \'{0}\'.";
        internal const string LESSER_EQ = "Value cannot be less than or equal to \'{0}\'.";
        internal const string POSITIVE = "Value cannot be positive.";
        internal const string NEGATIVE = "Value cannot be negative.";
        internal const string ZERO = "Value cannot be zero.";
        internal const string CONDITION = "The condition does not meet.";
        internal const string IN_RANGE = "Value cannot be in range of {0} with '{1}'.";
        internal const string OUT_OF_RANGE = "Value cannot be out of range of {0} with '{1}'.";
    }
}
