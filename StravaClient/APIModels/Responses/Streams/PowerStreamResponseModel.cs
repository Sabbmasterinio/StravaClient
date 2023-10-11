namespace StravaClient
{
    /// <summary>
    /// Represents a power stream.
    /// </summary>
    /// <remarks>
    /// Data: The sequence of power values for this stream, in watts.
    /// </remarks>
    public class PowerStreamResponseModel : BaseEnumerableDataStreamResponseModel<int>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PowerStreamResponseModel() : base()
        {

        }

        #endregion
    }
}