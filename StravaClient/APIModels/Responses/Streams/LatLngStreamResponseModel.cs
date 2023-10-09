namespace StravaClient
{
    /// <summary>
    /// Represents a lat lng stream.
    /// </summary>
    /// <remarks>
    /// Data: The sequence of lat/long values for this stream.
    /// </remarks>
    public class LatLngStreamResponseModel : BaseEnumerableDataStreamResponseModel<float>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LatLngStreamResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IEnumerable<float> GetFallbackValue() => Enumerable.Empty<float>();

        #endregion
    }

}