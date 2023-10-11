namespace StravaClient
{
    /// <summary>
    /// Represents a cadence stream.
    /// </summary>
    /// <remarks>
    /// The sequence of cadence values for this stream, in rotations per minute.
    /// </remarks>
    public class CadenceStreamResponseModel : BaseEnumerableDataStreamResponseModel<int>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CadenceStreamResponseModel() : base()
        {

        }

        #endregion
    }
}