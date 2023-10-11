namespace StravaClient
{
    /// <summary>
    /// Represents a smooth velocity stream.
    /// </summary>
    /// <remarks>
    /// Data: The sequence of heart rate values for this stream, in beats per minute.
    /// </remarks>
    public class HeartrateStreamResponseModel : BaseEnumerableDataStreamResponseModel<int>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public HeartrateStreamResponseModel() : base()
        {

        }

        #endregion
    }
}