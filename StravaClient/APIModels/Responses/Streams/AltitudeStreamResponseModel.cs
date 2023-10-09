namespace StravaClient
{
    /// <summary>
    /// Represents an altitude stream.
    /// </summary>
    /// <remarks>
    /// Data: The sequence of altitude values for this stream, in meters.
    /// </remarks>

    public class AltitudeStreamResponseModel : BaseEnumerableDataStreamResponseModel<float>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AltitudeStreamResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

}