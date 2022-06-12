/// <summary>
/// Boundary restriction rules when comparing a value with respect to left (lower-bound) and right (upper-bound) margins.
/// </summary>
public enum Boundary
{
    /// <summary>
    /// Include both left and right margins while evaluating the range.
    /// </summary>
    Inclusive,

    /// <summary>
    /// Exclude both left and right margins while evaluating the range.
    /// </summary>
    Exclusive,

    /// <summary>
    /// Include only left but not the right margins while evaluating the range.
    /// </summary>
    LeftOnly,

    /// <summary>
    /// Include only right but not the left margins while evaluating the range.
    /// </summary>
    RightOnly
}