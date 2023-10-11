namespace StravaClient
{
    /// <summary>
    /// Represents a smooth velocity stream.
    /// </summary>
    /// <remarks>
    /// Data: The sequence of velocity values for this stream, in meters per second.
    /// </remarks>
    public class SmoothVelocityStreamResponseModel : BaseEnumerableDataStreamResponseModel<float>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SmoothVelocityStreamResponseModel() : base()
        {

        }

        #endregion
    }
}