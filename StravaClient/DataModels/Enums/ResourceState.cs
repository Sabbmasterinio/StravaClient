namespace StravaClient
{
    /// <summary>
    /// Provides enumeration over the resource states
    /// </summary>
    /// <remarks>
    /// Possible values: 1 -> "meta", 2 -> "summary", 3 -> "detail".
    /// </remarks>
    public enum ResourceState
    {
        /// <summary>
        /// Meta
        /// </summary>
        Meta = 1,

        /// <summary>
        /// Summary
        /// </summary>
        Summary,

        /// <summary>
        /// Detail
        /// </summary>
        Detail
    }

}